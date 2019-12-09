using System;
using System.Collections.Generic;
using System.Linq;
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
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {   //有登入的話ID套用UserName
                HttpContext.Current.Session["CartId"] = HttpContext.Current.User.Identity.Name;
                HttpContext.Current.Session["MemberId"] = HttpContext.Current.Session["CartId"];
            }
            else
            {
                if (HttpContext.Current.Session["CartId"] == null || HttpContext.Current.Session["CartId"] == HttpContext.Current.Session["MemberId"])
                {   //沒登入而且還沒有Id的話，給他一組GUID當Id
                    Guid tempCartId = Guid.NewGuid();
                    HttpContext.Current.Session["CartId"] = tempCartId.ToString();
                }
            }
            ObjectCache cache = MemoryCache.Default;  //啟用預設MemoryCache
            CacheItemPolicy policy = new CacheItemPolicy();

            string UserId = HttpContext.Current.Session["CartId"].ToString();
            if (cache[UserId] == null)
            {
                Cart cart = new Cart();
                policy.SlidingExpiration = TimeSpan.FromMinutes(30);
                cache.Set(UserId, cart, policy);
            }
            return (Cart)cache[UserId];

        }
    }

}