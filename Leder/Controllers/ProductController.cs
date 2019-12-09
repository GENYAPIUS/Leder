using Leder.Models;
using Leder.Repository;
using Leder.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


namespace Leder.Controllers
{
    public class ProductController : Controller
    {
    
        private LederContext db = new LederContext();
        private ProductRepository productRepo;
        private CategoryRepository categoryRepo;
       

        //Index側背包
        public ActionResult Index()
        {
            productRepo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);

            List<ProductViewModel> productVM = new List<ProductViewModel>();

            var ProductList = productRepo.GetProductInCatagory(1, "1").ToList();

            foreach (var i in ProductList)
            {
                //把資料庫的值塞入ViewModel
                productVM.Add(new ProductViewModel
                {
                    Id = i.ProductId,
                    Name = i.Name,
                    Category = categoryRepo.GetCategoryNameById(i.CategoryId),
                    Price = i.Price,
                    Photo = i.Photo
                });

            }

            return View(productVM);
        }
        public ActionResult Backpack()
        {
            productRepo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);

            List<ProductViewModel> productVM = new List<ProductViewModel>();
            var ProductList = productRepo.GetProductInCatagory(2, "1").ToList();
            foreach (var i in ProductList)
            {
                //把資料庫的值塞入ViewModel
                productVM.Add(new ProductViewModel
                {
                    Id = i.ProductId,
                    Name = i.Name,
                    Category = categoryRepo.GetCategoryNameById(i.CategoryId),
                    Price = i.Price,
                    Photo = i.Photo
                });
            }
            return View(productVM);
        }


        [HttpPost]
        public ActionResult Backpack(string sortedItem)
        {
            productRepo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);

            List<ProductViewModel> productVM = new List<ProductViewModel>();

            var ProductList = productRepo.GetProductInCatagory(2, sortedItem).ToList();

            foreach (var i in ProductList)
            {
                productVM.Add(new ProductViewModel
                {
                    Id = i.ProductId,
                    Name = i.Name,
                    Category = categoryRepo.GetCategoryNameById(i.CategoryId),
                    Price = i.Price,
                    Photo = i.Photo
                });
            }
            return View(productVM);
        }


        //長夾
        public ActionResult Longclip()
        {
            productRepo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);

            List<ProductViewModel> productVM = new List<ProductViewModel>();
            var ProductList = productRepo.GetProductInCatagory(3,"1").ToList();
            foreach (var i in ProductList)
            {
                //把資料庫的值塞入ViewModel
                productVM.Add(new ProductViewModel
                {
                    Id = i.ProductId,
                    Name = i.Name,
                    Category = categoryRepo.GetCategoryNameById(i.CategoryId),
                    Price = i.Price,
                    Photo = i.Photo
                });
            }
            return View(productVM);
        }

        [HttpPost]
        public ActionResult Longclip(string sortedItem)
        {
            productRepo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);

            List<ProductViewModel> productVM = new List<ProductViewModel>();

            var ProductList = productRepo.GetProductInCatagory(3, sortedItem).ToList();

            foreach (var i in ProductList)
            {
                productVM.Add(new ProductViewModel
                {
                    Id = i.ProductId,
                    Name = i.Name,
                    Category = categoryRepo.GetCategoryNameById(i.CategoryId),
                    Price = i.Price,
                    Photo = i.Photo
                });
            }
            return View(productVM);
        }

        //零錢包
        public ActionResult Coinwallet()
        { 
            productRepo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);

            List<ProductViewModel> productVM = new List<ProductViewModel>();
            var ProductList = productRepo.GetProductInCatagory(4,"1").ToList();
            foreach (var i in ProductList)
            {
                //把資料庫的值塞入ViewModel
                productVM.Add(new ProductViewModel
                {
                    Id = i.ProductId,
                    Name = i.Name,
                    Category = categoryRepo.GetCategoryNameById(i.CategoryId),
                    Price = i.Price,
                    Photo = i.Photo
                });
            }
            return View(productVM);
        }

        [HttpPost]
        public ActionResult Coinwallet(string sortedItem)
        {
            productRepo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);

            List<ProductViewModel> productVM = new List<ProductViewModel>();

            var ProductList = productRepo.GetProductInCatagory(4, sortedItem).ToList();

            foreach (var i in ProductList)
            {
                productVM.Add(new ProductViewModel
                {
                    Id = i.ProductId,
                    Name = i.Name,
                    Category = categoryRepo.GetCategoryNameById(i.CategoryId),
                    Price = i.Price,
                    Photo = i.Photo
                });
            }
            return View(productVM);
        }

        //名片夾
        public ActionResult Namecard()
        {
            productRepo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);

            List<ProductViewModel> productVM = new List<ProductViewModel>();
            var ProductList = productRepo.GetProductInCatagory(5,"1").ToList();
            foreach (var i in ProductList)
            {
                //把資料庫的值塞入ViewModel
                productVM.Add(new ProductViewModel
                {
                    Id = i.ProductId,
                    Name = i.Name,
                    Category = categoryRepo.GetCategoryNameById(i.CategoryId),
                    Price = i.Price,
                    Photo = i.Photo
                });
            }
            return View(productVM);
        }

        [HttpPost]
        public ActionResult Namecard(string sortedItem)
        {
            productRepo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);

            List<ProductViewModel> productVM = new List<ProductViewModel>();

            var ProductList = productRepo.GetProductInCatagory(5, sortedItem).ToList();

            foreach (var i in ProductList)
            {
                productVM.Add(new ProductViewModel
                {
                    Id = i.ProductId,
                    Name = i.Name,
                    Category = categoryRepo.GetCategoryNameById(i.CategoryId),
                    Price = i.Price,
                    Photo = i.Photo
                });
            }
            return View(productVM);
        }

        public ActionResult ProductDetail(int? Id)
        {
            productRepo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);

            var i = productRepo.GetAll().FirstOrDefault((x) => x.ProductId == Id);
            if (i == null)
            {
                return RedirectToAction("Index", "Home");
            }

            //我是用FirstOrDefault找出唯一的一組，如果這邊寫成List<ProductViewModel>會報錯
            ProductViewModel productVM = new ProductViewModel() 
            {
                Id = i.ProductId,
                Name = i.Name,
                Category = categoryRepo.GetCategoryNameById(i.CategoryId),
                Price = i.Price,
                Photo = i.Photo
            };

            return View(productVM);
        }
    }
}