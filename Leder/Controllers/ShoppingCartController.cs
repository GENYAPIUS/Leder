using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Leder.Models;

namespace Leder.Controllers
{
    public class ShoppingCartController : Controller
    {
        LederContext db = new LederContext();
        // GET: ShoppingCart
        public ActionResult Index()
        {
            var currentCart = Models.Cart.Operation.GetCurrentCart();
            return View(currentCart.ToList()); 
        }

        public ActionResult Checkout()
        {
            var currentCart = Models.Cart.Operation.GetCurrentCart();
            return View(currentCart.ToList());
        }
        //取得目前購物車頁面
        public ActionResult GetCart()
        {
            return PartialView("_CartPartial");
        }
        public ActionResult AddToCart(int id)
        {
            var currentCart = Models.Cart.Operation.GetCurrentCart();
            currentCart.AddProduct(id);
            return PartialView("_CartPartial");
        }





    }
}