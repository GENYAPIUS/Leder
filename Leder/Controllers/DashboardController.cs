﻿using Leder.Models;
using Leder.ViewModels;
using Leder.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

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
        [HttpGet]
        public ActionResult GetAllProduct()
        {
            ProductRepository productRepo = new ProductRepository(db);
            CategoryRepository categoryRepo = new CategoryRepository(db);
            List<ProductViewModel> productViewModel = new List<ProductViewModel>();
            foreach (Product p in productRepo.GetAll().ToList())
            {
                ProductViewModel productVM = new ProductViewModel()
                {
                    Id = p.ProductId,
                    Name = p.Name,
                    Price = (int)p.Price,
                    Category = categoryRepo.GetCategoryNameById(p.CategoryId),
                    Photos = p.Photos,
                    Description = p.Description
                };
                productViewModel.Add(productVM);
            }
            return Json(productViewModel, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult GetAllProcurements()
        {
            ProductRepository productRepo = new ProductRepository(db);
            ProcurementRepository procurementRepo = new ProcurementRepository(db);
            List<ProcurementViewModel> procurements = new List<ProcurementViewModel>();
            foreach (Procurement item in procurementRepo.GetAll().ToList())
            {
                ProcurementViewModel procurementVM = new ProcurementViewModel()
                {
                    ProcurementId = item.ProcurementId,
                    ProductName = productRepo.GetProductNameByID(item.ProductId),
                    PurchaseDate = item.PurchaseDate.ToString("yyyy/MM/dd hh:mm:ss"),
                    Quantity = item.Quantity,
                    UnitPrize = item.UnitPrize,
                    ProductId = item.ProductId
                };
                procurements.Add(procurementVM);
            }

            return Json(procurements, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult EditProcurement([Bind(Include = "ProcurementId, ProductName, PurchaseDate, Quantity, UnitPrize, ProductId")]Procurement procurement)
        {
            //var procurement = JsonConvert.DeserializeObject<Procurement>(procurementJson);
            ProductRepository productRepo = new ProductRepository(db);
            ProcurementRepository procurementRepo = new ProcurementRepository(db);
            List<ProcurementViewModel> procurements = new List<ProcurementViewModel>();
            //將變更儲存在資料庫
            if (ModelState.IsValid)
            {
                db.Entry(procurement).State = EntityState.Modified;
                db.SaveChanges();
            }
            //抓取改變後的資料
            foreach (Procurement item in procurementRepo.GetAll().ToList())
            {
                ProcurementViewModel procurementVM = new ProcurementViewModel()
                {
                    ProductName = productRepo.GetProductNameByID(item.ProductId),
                    ProcurementId = item.ProcurementId,
                    PurchaseDate = item.PurchaseDate.ToString("yyyy/MM/dd hh:mm:ss"),
                    Quantity = item.Quantity,
                    UnitPrize = item.UnitPrize,
                };
                procurements.Add(procurementVM);
            }
            return Json(procurements);
        }
        [HttpGet]
        public void GetAllSales()
        {

        }
    }
}