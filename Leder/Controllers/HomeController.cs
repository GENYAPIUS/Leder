using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Leder.Models;
using Leder.ViewModels;
using Leder.Repository;

namespace Leder.Controllers
{
    public class HomeController : Controller
    {
        LederContext db = new LederContext();
        ProductRepository productRepo;
        CategoryRepository categoryRepo;
        
        public ActionResult Index()
        {            
            productRepo = new ProductRepository(db);
            categoryRepo = new CategoryRepository(db);
            
            List<ProductsSectionViewModel> productsSections = new List<ProductsSectionViewModel>();

            var Product = productRepo.GetAll().ToList();

            foreach(var i in Product)
            {
                productsSections.Add(new ProductsSectionViewModel()
                {
                    Id = i.ProductId,
                    Name = i.Name,
                    Price = i.Price,
                    Category = categoryRepo.GetCategoryNameById(i.CategoryId),
                    Photo = i.Photos.Split(',')[0]                    
                });                    
            }
          
            ViewData["ProductsSectionData"] = productsSections;

            List<ProductViewModel> productVM = new List<ProductViewModel>();
            foreach (var i in Product)
            {
                productVM.Add(new ProductViewModel()
                {
                    Id = i.ProductId,
                    Name = i.Name,
                    Price = i.Price,
                    Category = categoryRepo.GetCategoryNameById(i.CategoryId),
                    Photos = i.Photos.Split(',')
                });
            }
            ViewData["ProductsSectionQuickViewData"] = productVM;


            List<SliderPartialViewModel> sliders = new List<SliderPartialViewModel>()
            {
                new SliderPartialViewModel
                {
                    Id = 1,
                    ADTopic = "Leder Collection",
                    ADUrl = "/Assets/images/HomeImages/top_picture1.jpg",
                    ADStatement = "Share with you. Leder.",
                    ADDiscount = "On Sale!",
                    ADPageLink = "/Product/Totebag"

                },
                new SliderPartialViewModel
                {
                    Id = 2,
                    ADTopic = "Leder Collection",
                    ADUrl = "/Assets/images/HomeImages/top_picture2.jpg",
                    ADStatement = "Share with you. Leder.",
                    ADDiscount = "On Sale!",
                    ADPageLink = "/Product/Totebag"

                },
                new SliderPartialViewModel
                {
                    Id = 3,
                    ADTopic = "Leder Collection",
                    ADUrl = "/Assets/images/HomeImages/top_picture3.jpg",
                    ADStatement = "Share with you. Leder.",
                    ADDiscount = "On Sale!",
                    ADPageLink = "/Product/Totebag"

                }
            };

            ViewData["SlidersData"] = sliders;

            List<PromoteProductViewModel> promoteProducts = new List<PromoteProductViewModel>()
            {
                new PromoteProductViewModel
                {
                    Id = 1,
                    Section = "Promo section 1",
                    ProductName = "NewYear",
                    PhotoUrl = "/Assets/images/HomeImages/img_main_images1.jpg",
                    DiscountWord = "",
                    Statement = "For Gift"
                },
                new PromoteProductViewModel
                {
                    Id = 2,
                    Section = "Promo section 1",
                    ProductName = "Xmas",
                    PhotoUrl = "/Assets/images/HomeImages/img_main_images2.jpg",
                    DiscountWord = "",
                    Statement = "For X'mas"
                },
                new PromoteProductViewModel
                {
                    Id = 3,
                    Section = "Promo section 2 one",
                    ProductName = "pmpd01",
                    PhotoUrl = "/Assets/images/HomeImages/pickupleft1.jpg",
                    DiscountWord = "",
                    Statement = ""
                },
                new PromoteProductViewModel
                {
                    Id = 4,
                    Section = "Promo section 2 four",
                    ProductName = "pmpd02",
                    PhotoUrl = "/Assets/images/HomeImages/pickupright1.jpg",
                    DiscountWord = "",
                    Statement = ""
                },
                new PromoteProductViewModel
                {
                    Id = 5,
                    Section = "Promo section 2 four",
                    ProductName = "pmpd03",
                    PhotoUrl = "/Assets/images/HomeImages/pickupright2.jpg",
                    DiscountWord = "",
                    Statement = ""
                },
                new PromoteProductViewModel
                {
                    Id = 6,
                    Section = "Promo section 2 four",
                    ProductName = "pmpd04",
                    PhotoUrl = "/Assets/images/HomeImages/pickupright3.jpg",
                    DiscountWord = "",
                    Statement = ""
                },
                new PromoteProductViewModel
                {
                    Id = 7,
                    Section = "Promo section 2 four",
                    ProductName = "pmpd05",
                    PhotoUrl = "/Assets/images/HomeImages/pickupright4.jpg",
                    DiscountWord = "",
                    Statement = ""
                },
                new PromoteProductViewModel
                {
                    Id = 8,
                    Section = "Promo section 3 four",
                    ProductName = "pmpd06",
                    PhotoUrl = "/Assets/images/HomeImages/pickup2left1.jpg",
                    DiscountWord = "",
                    Statement = ""
                },
                new PromoteProductViewModel
                {
                    Id = 9,
                    Section = "Promo section 3 four",
                    ProductName = "pmpd07",
                    PhotoUrl = "/Assets/images/HomeImages/pickup2left2.jpg",
                    DiscountWord = "",
                    Statement = ""
                },
                new PromoteProductViewModel
                {
                    Id = 10,
                    Section = "Promo section 3 four",
                    ProductName = "pmpd08",
                    PhotoUrl = "/Assets/images/HomeImages/pickup2left3.jpg",
                    DiscountWord = "",
                    Statement = ""
                },
                new PromoteProductViewModel
                {
                    Id = 11,
                    Section = "Promo section 3 four",
                    ProductName = "pmpd09",
                    PhotoUrl = "/Assets/images/HomeImages/pickup2left4.jpg",
                    DiscountWord = "",
                    Statement = ""
                },
                new PromoteProductViewModel
                {
                    Id = 12,
                    Section = "Promo section 3 one",
                    ProductName = "pmpd10",
                    PhotoUrl = "/Assets/images/HomeImages/pickup2right1.jpg",
                    DiscountWord = "",
                    Statement = ""
                }
            };

            ViewData["promoteProductsData"] = promoteProducts;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}