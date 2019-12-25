using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Leder.Models;
using Leder.Controllers;
using Leder.ViewModels;
using Leder.Repository;

namespace Leder.Controllers
{
    public class WishlistController : Controller
    {
        // GET: Wishlist
        public ActionResult Index()
        {
            var currentWishlist = Models.Wishlist.Operation.GetCurrentWishlist();
            return View(currentWishlist.ToList());
        }
        public ActionResult AddToWishlist(int id)
        {
            var currentWishlist = Models.Wishlist.Operation.GetCurrentWishlist();
            currentWishlist.AddProduct(id);

            return View();
        }

        public ActionResult RemoveWishlit(int id)
        {
            var currentWishlist = Models.Wishlist.Operation.GetCurrentWishlist();
            currentWishlist.RemoveProduct(id);
            return View();
        }





    }
}