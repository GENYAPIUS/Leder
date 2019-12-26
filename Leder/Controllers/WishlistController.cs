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
            var currentList = (List<Wishlist>)Session["Wishlist"];

            return View(currentList);
        }

        [HttpPost]
        public ActionResult AddToWishlist(int productId)
        {
            List<Wishlist> currentList = new List<Wishlist>();
            var product = db.Products.FirstOrDefault(x => x.ProductId == productId);
            CategoryRepository categoryRepo = new CategoryRepository(db);

            if (Session["Wishlist"] == null)
            {
                Wishlist wishitem = new Wishlist
                {
                    Id = productId,
                    Name = product.Name,
                    Category = categoryRepo.GetCategoryNameById(product.CategoryId),
                    Photo = product.Photos.Split(',')[0],
                    Price = product.Price
                };
                currentList.Add(wishitem);

                Session["Wishlist"] = currentList;

            }
            else
            {
                currentList = (List<Wishlist>)Session["Wishlist"];
                if (currentList.Find(x => x.Id == productId) == null)
                {
                    Wishlist wishitem = new Wishlist
                    {
                        Id = productId,
                        Name = product.Name,
                        Category = categoryRepo.GetCategoryNameById(product.CategoryId),
                        Photo = product.Photos.Split(',')[0],
                        Price = product.Price
                    };
                    currentList.Add(wishitem);

                    Session["Wishlist"] = currentList;
                }
            }


            return PartialView("_WishlistPartial", currentList);

        }

        [HttpPost]
        public ActionResult RemoveWishlist(int id)
        {
            List<Wishlist> currentList = (List<Wishlist>)Session["Wishlist"];
            var item = currentList.FirstOrDefault(x => x.Id == id);
            currentList.Remove(item);

            Session["Wishlist"] = currentList;

            return PartialView("_WishlistPartial", currentList);
        }





    }
}