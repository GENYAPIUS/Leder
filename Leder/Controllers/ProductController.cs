using Leder.Models;
using Leder.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Leder.Controllers
{
    public class ProductController : Controller
    {
    
        private ProductContext db = new ProductContext();
        private ProductRepository repo;

        //呼叫Repository類別裡面的GetAll方法
        public ActionResult ListAllProducts()
        {
            repo = new ProductRepository(db);
            return View(repo.GetAll().ToList());
        }

        //預設是側背包
        //呼叫Repository類別裡面的GetProductInCatagory方法
        public ActionResult Index()
        {
            repo = new ProductRepository(db);
            var result = repo.GetProductInCatagory("Totebag").ToList();
            return View(result);
        }

        //後背包
        public ActionResult Backpack()
        {
            repo = new ProductRepository(db);
            var result = repo.GetProductInCatagory("Backpack").ToList();
            return View(result);

        }

        //長夾
        public ActionResult Longclip()
        {
            repo = new ProductRepository(db);
            var result = repo.GetProductInCatagory("Longclip").ToList();
            return View(result);
        }

        //零錢包
        public ActionResult Coinwallet()
        {
            repo = new ProductRepository(db);
            var result = repo.GetProductInCatagory("Coinwallet").ToList();
            return View(result);
        }

        //名片夾
        public ActionResult Namecard()
        {
            repo = new ProductRepository(db);
            var result = repo.GetProductInCatagory("Namecard").ToList();
            return View(result);
        }

        public ActionResult ProductDetail(int? Id)
        {
            repo = new ProductRepository(db);
            var getAllItems = repo.GetAll().ToList();
            var item = getAllItems.FirstOrDefault((x) => x.Id == Id);
            if (item == null)  //找不到item就回傳null
            {
                return RedirectToAction("Index", "Home");

            }

            return View(item);
        }


    }
}