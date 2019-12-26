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


            //Product/ChangeCategory
            routes.MapRoute(
                name: "ChangeCategory",
                url: "Product/ChangeCategory",
                defaults: new { controller = "Product", action = "ChangeCategory" }

            );

            //Product/Pagination
            routes.MapRoute(
                name: "Pagination",
                url: "Product/Pagination",
                defaults: new { controller = "Product", action = "Pagination"}

            );

            //Product/{Category}
            routes.MapRoute(
                name: "ProductCategory",
                url: "Product/{Category}",
                defaults: new { controller = "Product", action = "Index", Category = UrlParameter.Optional }

            );

            //商品頁面Id/{Id}         
            routes.MapRoute(
               name: "FindProductById",
               url: "Detail/{Id}",
               defaults: new { controller = "Product", action = "ProductDetail", Id = UrlParameter.Optional }
           );


            //購物車
            routes.MapRoute(
                name: "ShoppingCart",
                url: "ShoppingCart",
                defaults: new { controller = "ShoppingCart", action = "Index" }
            );
            //結帳頁面
            routes.MapRoute(
                name: "Checkout",
                url: "Checkout",
                defaults: new { controller = "ShoppingCart", action = "Checkout" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
