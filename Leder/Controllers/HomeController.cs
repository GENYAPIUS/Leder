using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Leder.Models;

namespace Leder.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<HomePartialViewModel> PMSL = new List<HomePartialViewModel>
            {
                new HomePartialViewModel{
                    Section = "Promo section 1-L",
                    ClassSize = "col-md-6",
                    ProductName = "Bag1",
                    Category = "Bags",
                    PhotoUrl = "/Assets/images/HomeImages/img_main_images1.jpg",
                    Discount = 0.15m,
                    Statement = "For Gift"
                },
                new HomePartialViewModel{
                    Section = "Promo section 1-R",
                    ClassSize = "col-md-6",
                    ProductName = "Bag2",
                    Category = "Bags",
                    PhotoUrl = "/Assets/images/HomeImages/img_main_images2.jpg",
                    Discount = 0.15m,
                    Statement = "For X'mas"
                }

            };

            return View(PMSL);
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