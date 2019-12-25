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
            return View();
        }

        [HttpPost]
        public ActionResult AddToWishlist(int productId)
        {
            WishlistRepository repo = new WishlistRepository();
            var currentList = repo.GetCurrentWishlist();  //取得當前的商品的資料
            return PartialView("_WishlistPartial", currentList);
           
        }

        public ActionResult RemoveWishlit(int id)
        {
            WishlistRepository repo = new WishlistRepository();
            var currentList = repo.GetCurrentWishlist();  //取得要刪除的那一筆資料
            return PartialView("_WishlistPartial", currentList);
        }





    }
}