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
    
        private LederContext db = new LederContext();
        private ProductRepository repo;
        private CategoryRepository categoryRepo;

       
        //預設是側背包
        //呼叫Repository類別裡面的GetProductInCatagory方法
        public ActionResult Index()
        {
            repo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);

            List<ProductViewModel> productVM = new List<ProductViewModel>();
            //var ProductList = repo.GetAll().ToList(); 用GetAll()會抓到全部25個產品秀在頁面上
            var ProductList = repo.GetProductInCatagory(1).ToList();
            foreach (var i in ProductList)
            {
                //把資料庫的值塞入ViewModel
                productVM.Add(new ProductViewModel
                {
                    Id = i.ProductId,
                    Name = i.Name,
                    Category = categoryRepo.GetCategoryNameById(i.CategoryId),
                    Price = (int)i.Price,
                    Photo = i.Photo
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
            var ProductList = repo.GetProductInCatagory(2).ToList();
            foreach (var i in ProductList)
            {
                //把資料庫的值塞入ViewModel
                productVM.Add(new ProductViewModel
                {
                    Id = i.ProductId,
                    Name = i.Name,
                    Category = categoryRepo.GetCategoryNameById(i.CategoryId),
                    Price = (int)i.Price,
                    Photo = i.Photo
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
            var ProductList = repo.GetProductInCatagory(3).ToList();
            foreach (var i in ProductList)
            {
                //把資料庫的值塞入ViewModel
                productVM.Add(new ProductViewModel
                {
                    Id = i.ProductId,
                    Name = i.Name,
                    Category = categoryRepo.GetCategoryNameById(i.CategoryId),
                    Price = (int)i.Price,
                    Photo = i.Photo
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
            var ProductList = repo.GetProductInCatagory(4).ToList();
            foreach (var i in ProductList)
            {
                //把資料庫的值塞入ViewModel
                productVM.Add(new ProductViewModel
                {
                    Id = i.ProductId,
                    Name = i.Name,
                    Category = categoryRepo.GetCategoryNameById(i.CategoryId),
                    Price = (int)i.Price,
                    Photo = i.Photo
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
            var ProductList = repo.GetProductInCatagory(5).ToList();
            foreach (var i in ProductList)
            {
                //把資料庫的值塞入ViewModel
                productVM.Add(new ProductViewModel
                {
                    Id = i.ProductId,
                    Name = i.Name,
                    Category = categoryRepo.GetCategoryNameById(i.CategoryId),
                    Price = (int)i.Price,
                    Photo = i.Photo
                });

            }

            return View(productVM);
        }

        public ActionResult ProductDetail(int? Id)
        {
            repo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);

            var i = repo.GetAll().FirstOrDefault((x) => x.ProductId == Id);
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
                Price = (int)i.Price,
                Photo = i.Photo
            };

            return View(productVM);

        }

    }
}