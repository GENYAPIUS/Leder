using Leder.Models;
using Leder.ViewModels;
using Leder.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

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
        public ActionResult GetAllProcuments()
        {
            ProductRepository productRepo = new ProductRepository(db);
            ProcurementRepository procurementRepo = new ProcurementRepository(db);
            List<ProcurementViewModel> procurements = new List<ProcurementViewModel>();
                foreach(Procurement item in procurementRepo.GetAll().ToList())
            {
                ProcurementViewModel procurementVM = new ProcurementViewModel()
                {
                    Name = productRepo.GetProductNameByID(item.ProductId),
                    ProcurementId = item.ProcurementId,
                    PuchuseDate = item.PurchaseDate,
                    Quantity = item.Quantity,
                    UnitPrize = item.UnitPrize,
                    

                };
                procurements.Add(procurementVM);
            }

            return Json(procurements, JsonRequestBehavior.AllowGet);
        }
    }
}