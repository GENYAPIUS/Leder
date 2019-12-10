using System;
using System.Runtime.Caching;
using System.Web;
using System.Web.Services;

namespace Leder.Models.Cart
{
    //這個類別是提供購物車操作，目前我們僅新增一個方法GetCurrentCart()，功能是取得當前的購物車

    //購物車操作類別

    public static class Operation
    {
        [WebMethod(EnableSession = true)] //啟用Session
        public static Cart GetCurrentCart()
        {
            ObjectCache cache = MemoryCache.Default;  
            CacheItemPolicy policy = new CacheItemPolicy();
            bool shift = false;  //用來判斷是否需要轉移購物車的變數(預設為false 不用轉移)

            if (HttpContext.Current.User.Identity.IsAuthenticated )
            {   
                if (((Cart)cache[HttpContext.Current.Session["Non-membersId"].ToString()]).Count != 0 && HttpContext.Current.Session["CartId"].ToString() != HttpContext.Current.User.Identity.Name)
                {
                    shift = true;   //設定為需要轉移
                }
                //有登入的話ID套用UserName
                HttpContext.Current.Session["CartId"] = HttpContext.Current.User.Identity.Name;
                HttpContext.Current.Session["MemberId"] = HttpContext.Current.Session["CartId"];
            }
            else
            {
                if (HttpContext.Current.Session["CartId"] == null || HttpContext.Current.Session["CartId"] == HttpContext.Current.Session["MemberId"])
                {   //還沒有Id 或者 剛登出  的話，給他一組GUID當Id
                    Guid tempCartId = Guid.NewGuid();
                    HttpContext.Current.Session["CartId"] = tempCartId.ToString();
                    HttpContext.Current.Session["Non-membersId"] = HttpContext.Current.Session["CartId"];
                }
            }

            string UserId = HttpContext.Current.Session["CartId"].ToString();
            if (cache[UserId] == null)
            {
                Cart cart = new Cart();
                policy.SlidingExpiration = TimeSpan.FromMinutes(30);
                cache.Set(UserId, cart, policy);
            }
            if (shift == true)
            {   //將需要轉移購物車的訊息存至Cart，並將shift改回預設值
                ((Cart)cache[UserId]).Shift = true;
                shift = false;
            }
            return (Cart)cache[UserId];

        }

        public static Cart GetShiftCart()
        {
            return (Cart)MemoryCache.Default[HttpContext.Current.Session["Non-membersId"].ToString()];
        }
    }

}