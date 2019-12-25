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
        LederContext db = new LederContext();

        // GET: Wishlist
        public ActionResult Index()
        {
            WishlistRepository repo = new WishlistRepository();
            var currentList = repo.GetCurrentWishlist();

            return View(currentList);
        }

        [HttpPost]
        public ActionResult AddToWishlist(int productId)
        {
            
            CategoryRepository categoryRepo = new CategoryRepository(db);
            var product = db.Products.FirstOrDefault(x => x.ProductId == productId);
            WishlistRepository Wishlistrepo = new WishlistRepository();

            var currentList = Wishlistrepo.GetCurrentWishlist();  

            if (currentList.Find(x => x.Id == productId) == null)
            {
                Wishlist wishitem = new Wishlist
                {
                    Id = productId,
                    Name = product.Name,
                    Category = categoryRepo.GetCategoryNameById(productId),
                    Photo = product.Photos.Split(',')[0],
                    Price = product.Price
                };
                currentList.Add(wishitem);

                Session["Wishlist"] = currentList;
            }            

            return PartialView("_WishlistPartial", currentList);
           
        }

        [HttpPost]
        public ActionResult RemoveWishlist(int id)
        {
            WishlistRepository repo = new WishlistRepository();
            var currentList = repo.GetCurrentWishlist();
            var item = currentList.FirstOrDefault(x => x.Id == id);
            currentList.Remove(item);

            Session["Wishlist"] = currentList;

            return PartialView("_WishlistPartial", currentList);
        }





    }
}