using Leder.Models;
using Leder.Repository;
using Leder.ViewModels;
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
        private CategoryRepository categoryRepo;

       
        //預設是側背包
        //呼叫Repository類別裡面的GetProductInCatagory方法
        public ActionResult Index()
        {
            repo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);

            List<ProductViewModel> productVM = new List<ProductViewModel>();
            var ProductList = repo.GetAll().ToList();
            foreach(var i in ProductList)
            {
                //把資料庫的值塞入ViewModel
                productVM.Add(new ProductViewModel
                {
                    Id = i.ProductId,
                    Name = i.Name,
                    Category = categoryRepo.GetCategoryNameById(i.CategoryId),
                    Price = (int)i.Price,
                    Photo = "Totebag1.jpg"
                });
                
            }

            return View(productVM);
           
        }

        //後背包
        public ActionResult Backpack()
        {
            repo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);

            List<ProductViewModel> productVM = new List<ProductViewModel>();
            var ProductList = repo.GetAll().ToList();
            foreach (var i in ProductList)
            {
                //把資料庫的值塞入ViewModel
                productVM.Add(new ProductViewModel
                {
                    Id = i.ProductId,
                    Name = i.Name,
                    Category = categoryRepo.GetCategoryNameById(i.CategoryId),
                    Price = (int)i.Price,
                    Photo = "Backpack1.jpg"
                });

            }

            return View(productVM);

        }

        //長夾
        public ActionResult Longclip()
        {
            repo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);

            List<ProductViewModel> productVM = new List<ProductViewModel>();
            var ProductList = repo.GetAll().ToList();
            foreach (var i in ProductList)
            {
                //把資料庫的值塞入ViewModel
                productVM.Add(new ProductViewModel
                {
                    Id = i.ProductId,
                    Name = i.Name,
                    Category = categoryRepo.GetCategoryNameById(i.CategoryId),
                    Price = (int)i.Price,
                    Photo = "Longclip1.jpg"
                });

            }

            return View(productVM);

        }

        //零錢包
        public ActionResult Coinwallet()
        {
            repo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);

            List<ProductViewModel> productVM = new List<ProductViewModel>();
            var ProductList = repo.GetAll().ToList();
            foreach (var i in ProductList)
            {
                //把資料庫的值塞入ViewModel
                productVM.Add(new ProductViewModel
                {
                    Id = i.ProductId,
                    Name = i.Name,
                    Category = categoryRepo.GetCategoryNameById(i.CategoryId),
                    Price = (int)i.Price,
                    Photo = "Coinwallet1.jpg"
                });

            }

            return View(productVM);
        }

        //名片夾
        public ActionResult Namecard()
        {
            repo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);

            List<ProductViewModel> productVM = new List<ProductViewModel>();
            var ProductList = repo.GetAll().ToList();
            foreach (var i in ProductList)
            {
                //把資料庫的值塞入ViewModel
                productVM.Add(new ProductViewModel
                {
                    Id = i.ProductId,
                    Name = i.Name,
                    Category = categoryRepo.GetCategoryNameById(i.CategoryId),
                    Price = (int)i.Price,
                    Photo = "Namecard1.jpg"
                });

            }

            return View(productVM);
        }

        public ActionResult ProductDetail(int? Id)
        {
            repo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);

            var item = repo.GetAll().FirstOrDefault((x) => x.ProductId == Id);
            if (item == null)
            {
                return RedirectToAction("Index", "Home");
            }

            //我是用FirstOrDefault找出唯一的一組，如果這邊寫成List<ProductViewModel>會報錯
            ProductViewModel productVM = new ProductViewModel() 
            {
                Id = item.ProductId,
                Name = item.Name,
                Category = categoryRepo.GetCategoryNameById(item.CategoryId),
                Price = (int)item.Price,
                Photo = item.Photo
            };

            return View(productVM);

        }

    }
}