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

        
        public ActionResult Index(string Category) //接收路由傳來的參數Category
        {
            
            productRepo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);

            List<ProductViewModel> productVM = new List<ProductViewModel>();

            //傳入路由的類別名稱(ex:Totebag)取得CategoryId
            int CategoryId = categoryRepo.GetCategoryId(Category);
            if (CategoryId == 0)
            {
                return RedirectToAction("Index", "Home");  //如果由路由輸入的類別無法辨識，就跳回首頁
            }

            var ProductList = productRepo.GetProductInCatagory(CategoryId).ToList();

            foreach (var i in ProductList)
            {
                //把資料庫的值塞入ViewModel
                productVM.Add(new ProductViewModel
                {
                    Id = i.ProductId,
                    Name = i.Name,
                    Category = categoryRepo.GetCategoryNameById(i.CategoryId),
                    Price = i.Price,
                    Photos = i.Photos.Split(',')
                });

            }

            ViewData["totalPage"] = PageCount(productVM); //用PageCount方法去計算要有幾頁

            productVM = productVM.Take(6).ToList(); //預設第一頁，放六個產品

            return View(productVM);
        }

        [HttpPost] 
        public ActionResult ChangeCategory(string Category) //Sidebar的商品類別是用ajax呼叫
        {

            productRepo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);

            List<ProductViewModel> productVM = new List<ProductViewModel>();
            int CategoryId = categoryRepo.GetCategoryId(Category);

            var ProductList = productRepo.GetProductInCatagory(CategoryId).ToList();

            foreach (var i in ProductList)
            {
                //把資料庫的值塞入ViewModel
                productVM.Add(new ProductViewModel
                {
                    Id = i.ProductId,
                    Name = i.Name,
                    Category = categoryRepo.GetCategoryNameById(i.CategoryId),
                    Price = i.Price,                   
                    Photos = i.Photos.Split(',')
                });

            }

            ViewData["totalPage"] = PageCount(productVM); //用PageCount()去計算要有幾頁

            productVM = productVM.Take(6).ToList(); //預設第一頁，放六個產品

            return PartialView("_ProductPartial", productVM);
        }
        public int PageCount(List<ProductViewModel> productVM)
        {
            int pageSize = 6;  //一頁放六個產品
            //Math.Ceiling無條件進位
            //Count()計算有幾個商品
            ViewData["totalPage"] = (int)Math.Ceiling((decimal)productVM.Count() / pageSize); //用ViewData傳給View
            var page = (int)ViewData["totalPage"];
            return page;
        }

        //判斷在哪一個頁數
        [HttpPost]
        public ActionResult Pagination(int Value, int PageNumber, string RoutePath)
        {
            //在/Product/Totebag抓我要的值
            var category = RoutePath.Replace("/Product/", ""); 

            categoryRepo = new CategoryRepository(db);
            int CategoryId = categoryRepo.GetCategoryId(category);

            var sortedProduct = Sorted(Value, CategoryId);   //呼叫Sorted方法，回傳"排序後"的全部商品
            ViewData["totalPage"] = PageCount(sortedProduct);
            List<ProductViewModel> pagedProduct = new List<ProductViewModel>();
            pagedProduct = sortedProduct.Skip(6 * (PageNumber - 1)).Take(6).ToList();
            return PartialView("_ProductPartial", pagedProduct);           

        }

        //把商品排序
        //如果沒點選任何排序方法，預設用ID排序
        public List<ProductViewModel> Sorted(int value, int categoryId)
        {
            productRepo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);
            List<ProductViewModel> productVM = new List<ProductViewModel>();
            var ProductList = productRepo.GetProductInCatagory(categoryId).ToList();

            foreach (var i in ProductList)
            {
                productVM.Add(new ProductViewModel
                {
                    Id = i.ProductId,
                    Name = i.Name,
                    Category = categoryRepo.GetCategoryNameById(i.CategoryId),
                    Price = i.Price,
                    Photos = i.Photos.Split(',')
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
                Photos = i.Photos.Split(','),
                Description = i.Description
            };

            return View(productVM);
        }
    }
}