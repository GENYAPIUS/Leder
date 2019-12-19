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
            //ViewData["promoteProductsData"] = db.promoteProducts.ToList();
            //ViewData["SlidersData"] = db.sliders.ToList();
            //ViewData["ProductsSectionData"] = db.productsSections.ToList();
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
                    //Photo = i.Photos,
                    ProductPage = "#"
                });                    
            }
          
            ViewData["ProductsSectionData"] = productsSections;

            List<SliderPartialViewModel> sliders = new List<SliderPartialViewModel>()
            {
                new SliderPartialViewModel
                {
                    Id = 1,
                    ADTopic = "Leder Collection No.1",
                    ADUrl = "/Assets/images/HomeImages/top_picture1.jpg",
                    ADStatement = "Share with you. Leder.",
                    ADDiscount = "Save Up to 25% Off",
                    ADPageLink = "#"

                },
                new SliderPartialViewModel
                {
                    Id = 2,
                    ADTopic = "Leder Collection No.2",
                    ADUrl = "/Assets/images/HomeImages/top_picture2.jpg",
                    ADStatement = "Share with you. Leder.",
                    ADDiscount = "Save Up to 30% Off",
                    ADPageLink = "#"

                },
                new SliderPartialViewModel
                {
                    Id = 3,
                    ADTopic = "Leder Collection No.3",
                    ADUrl = "/Assets/images/HomeImages/top_picture3.jpg",
                    ADStatement = "Share with you. Leder.",
                    ADDiscount = "Save Up to 35% Off",
                    ADPageLink = "#"

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
                    DiscountWord = "15% Off",
                    Statement = "For Gift"
                },
                new PromoteProductViewModel
                {
                    Id = 2,
                    Section = "Promo section 1",
                    ProductName = "Xmas",
                    PhotoUrl = "/Assets/images/HomeImages/img_main_images2.jpg",
                    DiscountWord = "15% Off",
                    Statement = "For X'mas"
                },
                new PromoteProductViewModel
                {
                    Id = 3,
                    Section = "Promo section 2 one",
                    ProductName = "pmpd01",
                    PhotoUrl = "/Assets/images/HomeImages/pickupleft1.jpg",
                    DiscountWord = "10% Off",
                    Statement = "For Women"
                },
                new PromoteProductViewModel
                {
                    Id = 4,
                    Section = "Promo section 2 four",
                    ProductName = "pmpd02",
                    PhotoUrl = "/Assets/images/HomeImages/pickupright1.jpg",
                    DiscountWord = "10% Off",
                    Statement = "For Women"
                },
                new PromoteProductViewModel
                {
                    Id = 5,
                    Section = "Promo section 2 four",
                    ProductName = "pmpd03",
                    PhotoUrl = "/Assets/images/HomeImages/pickupright3.jpg",
                    DiscountWord = "10% Off",
                    Statement = "For Women"
                },
                new PromoteProductViewModel
                {
                    Id = 6,
                    Section = "Promo section 2 four",
                    ProductName = "pmpd04",
                    PhotoUrl = "/Assets/images/HomeImages/pickupright3.jpg",
                    DiscountWord = "10% Off",
                    Statement = "For Women"
                },
                new PromoteProductViewModel
                {
                    Id = 7,
                    Section = "Promo section 2 four",
                    ProductName = "pmpd05",
                    PhotoUrl = "/Assets/images/HomeImages/pickupright2.jpg",
                    DiscountWord = "10% Off",
                    Statement = "For Women"
                },
                new PromoteProductViewModel
                {
                    Id = 8,
                    Section = "Promo section 3 four",
                    ProductName = "pmpd06",
                    PhotoUrl = "/Assets/images/HomeImages/pickup2left1.jpg",
                    DiscountWord = "10% Off",
                    Statement = "For Men"
                },
                new PromoteProductViewModel
                {
                    Id = 9,
                    Section = "Promo section 3 four",
                    ProductName = "pmpd07",
                    PhotoUrl = "/Assets/images/HomeImages/pickup2left2.jpg",
                    DiscountWord = "10% Off",
                    Statement = "For Men"
                },
                new PromoteProductViewModel
                {
                    Id = 10,
                    Section = "Promo section 3 four",
                    ProductName = "pmpd08",
                    PhotoUrl = "/Assets/images/HomeImages/pickup2left2.jpg",
                    DiscountWord = "10% Off",
                    Statement = "For Men"
                },
                new PromoteProductViewModel
                {
                    Id = 11,
                    Section = "Promo section 3 four",
                    ProductName = "pmpd09",
                    PhotoUrl = "/Assets/images/HomeImages/pickup2left3.jpg",
                    DiscountWord = "10% Off",
                    Statement = "For Men"
                },
                new PromoteProductViewModel
                {
                    Id = 12,
                    Section = "Promo section 3 one",
                    ProductName = "pmpd10",
                    PhotoUrl = "/Assets/images/HomeImages/pickup2right1.jpg",
                    DiscountWord = "10% Off",
                    Statement = "For Men"
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