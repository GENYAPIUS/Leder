using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Leder.Models;
using Leder.ViewModels;

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
        [Authorize]
        public ActionResult Checkout()
        {
            
            var userData = db.UserDetail.Where(x => x.Email == HttpContext.User.Identity.Name);
            var currentCart = Models.Cart.Operation.GetCurrentCart();

            ViewData["UserData"] = userData;
            ViewData["CurrentCart"] = currentCart;


            return View(currentCart.ToList());
        }
        [Authorize]
        [HttpPost]
        public ActionResult Order(string Email, string RecieverName, string RecieverPhone, string RecieverAddress, string RecieverZipCode)
        {
            ViewData["Email"] = Email;
            ViewData["RecieverName"] = RecieverName;
            ViewData["RecieverPhone"] = RecieverPhone;
            ViewData["RecieverAddress"] = RecieverAddress;
            ViewData["RecieverZipCode"] = RecieverZipCode;
            ViewBag.Email = Email;
            

            var currentCart = Models.Cart.Operation.GetCurrentCart();
            return View(currentCart.ToList());
        }

        [Authorize]
        [HttpPost]
        public ActionResult CashOrder(string Email, string RecieverName, string RecieverPhone, string RecieverAddress, string RecieverZipCode)
        {
            OrderViewModel orders = new OrderViewModel();
            orders.Email = Email;           
            orders.RecieverName = RecieverName;
            orders.RecieverPhone = RecieverPhone;
            orders.RecieverAddress = RecieverAddress;
            orders.RecieverZipCode = RecieverZipCode;
            orders.Carts = Models.Cart.Operation.GetCurrentCart();
            ViewData["RecieverData"] = orders;


            var currentCart = Models.Cart.Operation.GetCurrentCart();
            return View(currentCart.ToList());
        }

        public ActionResult AddToCart(int id,int? inQuantity)
        {
            var currentCart = Models.Cart.Operation.GetCurrentCart();
            currentCart.AddProduct(id, inQuantity);
            return PartialView("_CartPartial");
        }
        public ActionResult EditToCart(int id, int? inQuantity)
        {
            var currentCart = Models.Cart.Operation.GetCurrentCart();
            currentCart.EditProduct(id, inQuantity);
            return PartialView("_CartPartial");
        }
        public ActionResult RemoveFromCart(int id)
        {
            var currentCart = Models.Cart.Operation.GetCurrentCart();
            currentCart.RemoveProduct(id);
            return PartialView("_CartPartial");
        }

        public ActionResult ClearCart()
        {
            var currentCart = Models.Cart.Operation.GetCurrentCart();
            currentCart.ClearCart();
            return PartialView("_CartPartial");
        }

        public ActionResult ShiftCartOK()
        {
            var currentCart = Models.Cart.Operation.GetCurrentCart();
            currentCart.Shift = false;
            return PartialView("_CartPartial");
        }





    }
}