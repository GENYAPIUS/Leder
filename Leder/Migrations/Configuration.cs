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
                x => x.SectionId,
                new PromoteProductViewModel
                {
                    SectionId = "Promo section 1-L",
                    ProductName = "NewYear",
                    PhotoUrl = "/Assets/images/HomeImages/img_main_images1.jpg",
                    DiscountWord = "15% Off",
                    Statement = "For Gift"
                },
                new PromoteProductViewModel
                {
                    SectionId = "Promo section 1-R",
                    ProductName = "Xmas",
                    PhotoUrl = "/Assets/images/HomeImages/img_main_images2.jpg",
                    DiscountWord = "15% Off",
                    Statement = "For X'mas"
                }
                );
        }
    }
}
