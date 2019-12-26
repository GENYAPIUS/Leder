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

            if (currentCart.TotalAmount == 0.0m)
            {
                return View("Index");
            }            

            ViewData["UserData"] = userData;
            ViewData["CurrentCart"] = currentCart;


            return View(currentCart.ToList());
        }
        [Authorize]        
        public ActionResult Order()
        {
            OrderViewModel receiverData = (OrderViewModel)Session["ReceiverData"];

            return View(receiverData);
        }        
        [Authorize]        
        public ActionResult CashOrder()
        {
            OrderViewModel receiverData = (OrderViewModel)Session["ReceiverData"];         
                           
            return View(receiverData);
        }
        
        [HttpPost]
        public ActionResult OrderData(string Email, string RecieverName, string RecieverPhone, string RecieverAddress, string RecieverZipCode,string PayStatus)
        {
            OrderViewModel orders = new OrderViewModel();
            orders.Email = Email;
            orders.RecieverName = RecieverName;
            orders.RecieverPhone = RecieverPhone;
            orders.RecieverAddress = RecieverAddress;
            orders.RecieverZipCode = RecieverZipCode;
            orders.PayStatus = PayStatus;
            orders.Carts = Models.Cart.Operation.GetCurrentCart();
            orders.CartItems = orders.Carts.ToList();

            Session["ReceiverData"] = orders;

            return View();
        }

        [HttpPost]
        public ActionResult UpdataOrderPayStatus(string PayStatus,string TotalAmount)
        {
            OrderViewModel orders = (OrderViewModel)Session["ReceiverData"];
            if (TotalAmount == orders.Carts.TotalAmount.ToString())
            { orders.PayStatus = PayStatus; }
            else
            { orders.PayStatus = "異常的款項"; }
            return View();
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