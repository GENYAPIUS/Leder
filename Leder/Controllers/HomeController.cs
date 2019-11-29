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
            ViewData["promoteProductsData"] = db.promoteProducts.ToList();
            ViewData["SlidersData"] = db.sliders.ToList();
            ViewData["ProductsSectionData"] = db.productsSections.ToList();



            return View();
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