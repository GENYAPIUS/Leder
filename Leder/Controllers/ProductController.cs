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
        
        //private int CurrentPage = 1;   


        //Index側背包
        public ActionResult Index()
        {
            productRepo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);

            List<ProductViewModel> productVM = new List<ProductViewModel>();

            var ProductList = productRepo.GetProductInCatagory(1).ToList();

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

            
            int pageSize = 6;  //一頁放六個產品
            //Math.Ceiling無條件進位
            //Count()計算有幾個商品
            ViewData["totalPage"] = (int)Math.Ceiling((decimal)productVM.Count() / pageSize); //用ViewData傳給View

            productVM = productVM.Take(6).ToList(); //預設第一頁，放六個產品

            return View(productVM);
        }

        //把商品排序
        //如果沒點選任何排序方法，預設用ID排序
        public List<ProductViewModel> Sorted(int value)
        {
            productRepo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);
            List<ProductViewModel> productVM = new List<ProductViewModel>();
            var ProductList = productRepo.GetProductInCatagory(1).ToList();

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

            List<ProductViewModel> sortedProduct = new List<ProductViewModel>();  //判斷是哪種排序法
            //用名稱分類
            if (value == 2)
            {
                sortedProduct = productVM.OrderBy(x => x.Name).ToList();
            }
            //用價格分類(從低到高)  
            else if (value == 3)
            {
                sortedProduct = productVM.OrderBy(x => x.Price).ToList();             
            }
            //用價格分類(從高到低)
            else if (value == 4)
            {
                sortedProduct = productVM.OrderByDescending(x => x.Price).ToList();     

            }
            else
            {
                sortedProduct = productVM;  //沒選任何排序方法就用ID排序
            }

            return sortedProduct;
        }


        [HttpPost] //只要按下頁碼，或是點選排序方法都會呼叫Pagination方法
        public ActionResult Pagination(int value, int PageNumber)
        {
            
            var sortedProduct = Sorted(value);   //呼叫Sorted方法，回傳"排序後"的全部商品

            List<ProductViewModel> pagedProduct = new List<ProductViewModel>();
            //CurrentPage = (int)PageNumber;
            if (PageNumber==1) 
            {
                
             pagedProduct = sortedProduct.Skip(6 * (PageNumber - 1)).Take(6).ToList();
             return PartialView("_ProductPartial", pagedProduct);

            }
            else 
            {
              pagedProduct = sortedProduct.Skip(6 * (PageNumber - 1)).Take(6).ToList();
              return PartialView("_ProductPartial", pagedProduct);
            }

        }


        public ActionResult Backpack()
        {
            productRepo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);

            List<ProductViewModel> productVM = new List<ProductViewModel>();
            var ProductList = productRepo.GetProductInCatagory(2).ToList();
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


        //長夾
        public ActionResult Longclip()
        {
            productRepo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);

            List<ProductViewModel> productVM = new List<ProductViewModel>();
            var ProductList = productRepo.GetProductInCatagory(3).ToList();
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


        //零錢包
        public ActionResult Coinwallet()
        { 
            productRepo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);

            List<ProductViewModel> productVM = new List<ProductViewModel>();
            var ProductList = productRepo.GetProductInCatagory(4).ToList();
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


        //名片夾
        public ActionResult Namecard()
        {
            productRepo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);

            List<ProductViewModel> productVM = new List<ProductViewModel>();
            var ProductList = productRepo.GetProductInCatagory(5).ToList();
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
     
        //商品介紹
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