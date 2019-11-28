namespace Leder.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Leder.ViewModels;

    internal sealed class Configuration : DbMigrationsConfiguration<Leder.ViewModels.HomeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Leder.ViewModels.HomeContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.promoteProducts.AddOrUpdate(
                x => x.Id,
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
                );
        }
    }
}
