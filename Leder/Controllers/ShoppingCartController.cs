using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Leder.Models;

namespace Leder.Controllers
{
    public class ShoppingCartController : Controller
    {
        ShoppingCartContext db = new ShoppingCartContext();
        // GET: ShoppingCart
        public ActionResult Index()   //購物車測試用假登入頁
        {
            return View();
        }

        public ActionResult MyCart()    //購物車頁面
        {
            
            return View();
        }
    }
}