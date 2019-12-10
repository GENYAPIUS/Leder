﻿using System;
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
        [Authorize]
        public ActionResult Checkout()
        {
            var currentCart = Models.Cart.Operation.GetCurrentCart();
            return View(currentCart.ToList());
        }
        [Authorize]
        public ActionResult Order()
        {
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