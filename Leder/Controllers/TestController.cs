using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Leder.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCart()
        {
            var cart = Models.Cart.Operation.GetCurrentCart();
            if(cart.cartItems.Count==0)
            {
                cart.cartItems.Add(
                    new Models.Cart.CartItem()
                    {
                        Id = 1,
                        Name = "測試",
                        Quantity = 1,
                        Price = 100m
                    });  
            }
            else
            {
                cart.cartItems.First().Quantity += 1;
            }
            return Content(string.Format("目前購物車總共:{0}元", cart.TotalAmount));
        }
    }
}