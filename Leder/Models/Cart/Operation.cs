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

        static Cart cart = new Cart();

        public static Cart GetCurrentCart()
        {

            ObjectCache cache = MemoryCache.Default;
            string fileContents = cache["filecontents"] as string;
            if (fileContents == null)
            {
                CacheItemPolicy policy = new CacheItemPolicy();
                //Update.UpdataCartId(cart.CartId);
                cart.UpdataCartId();
                if (cache["Cart"] == null)
                {
                    policy.SlidingExpiration = TimeSpan.FromDays(3);
                    cache.Set("Cart", cart, policy);
                }
                return (Cart)cache["Cart"];
            }
            else
            {
                throw new InvalidOperationException("System.Wed.HttpContext.Current為空，請檢查");
            }
        }
    }

}