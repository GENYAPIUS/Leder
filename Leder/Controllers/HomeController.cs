using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Leder.Models;
using Leder.ViewModels;

namespace Leder.Controllers
{
    public class HomeController : Controller
    {
        HomeContext db = new HomeContext();
        public ActionResult Index()
        {
            var promoteProductsData = db.promoteProducts.ToList();
            //List<PromoteProduct> promote = new List<PromoteProduct>
            //{
            //    new PromoteProduct{
            //        SectionId = "Promo section 1-L",                                       
            //        ProductName = "NewYear",                    
            //        PhotoUrl = "/Assets/images/HomeImages/img_main_images1.jpg",
            //        DiscountWord = "15% Off",
            //        Statement = "For Gift"
            //    },
            //    new PromoteProduct{
            //        SectionId = "Promo section 1-R",                                       
            //        ProductName = "Xmas",                    
            //        PhotoUrl = "/Assets/images/HomeImages/img_main_images2.jpg",
            //        DiscountWord = "15% Off",
            //        Statement = "For X'mas"
            //    }

            //};

            return View(promoteProductsData);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}