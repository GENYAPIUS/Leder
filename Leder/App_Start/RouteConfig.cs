using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Leder
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //商品頁面
            //從Product/ProductDetail/id變成ProductDetail/id，精簡了一點
            routes.MapRoute(
               name: "ProductDetail",
               url: "ProductDetail/{Id}",
               defaults: new { controller = "Product", action = "ProductDetail", Id = UrlParameter.Optional }
           );


            //購物車
            routes.MapRoute(
                name: "ShoppingCart",
                url: "ShoppingCart",
                defaults: new { controller = "ShoppingCart", action = "Index", id = UrlParameter.Optional }
            );
            //結帳頁面
            routes.MapRoute(
                name: "Checkout",
                url: "Checkout",
                defaults: new { controller = "ShoppingCart", action = "Checkout", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
