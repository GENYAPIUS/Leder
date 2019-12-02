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
            cart.AddProduct(1);

            return Content(string.Format("目前購物車總共:{0}元", cart.TotalAmount));
        }
    }
}