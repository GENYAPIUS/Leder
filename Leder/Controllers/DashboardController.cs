using Leder.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Leder.Controllers
{
    public class DashboardController : Controller
    {
        LederContext db = new LederContext();
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Procurement()
        {
            var procurement = db.Procurement.Include(p => p.Product);
            return View(procurement.ToList());
        }
    }
}