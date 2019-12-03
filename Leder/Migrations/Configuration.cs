namespace Leder.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Leder.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Leder.Models.ApplicationDbContext";
        }

        protected override void Seed(Leder.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.sliders.AddOrUpdate(
                x => x.Id,
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

                );


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


            context.productsSections.AddOrUpdate(
                x => x.Id,
                new ProductsSectionViewModel { Id = 1, Name = "Clarte �yĬ�g�A�c���]", Price = 8888, Category = "Totebag", Photo = "/Assets/images/ProductImages/Totebag/Totebag1.jpg", ProductPage = "#" },
                new ProductsSectionViewModel { Id = 2, Name = "Diario �g�A�H��תӳU", Price = 8888, Category = "Totebag", Photo = "/Assets/images/ProductImages/Totebag/Totebag2.jpg", ProductPage = "#" },
                new ProductsSectionViewModel { Id = 3, Name = "Plota ������α׭I�]", Price = 8888, Category = "Totebag", Photo = "/Assets/images/ProductImages/Totebag/Totebag3.jpg", ProductPage = "#" },
                new ProductsSectionViewModel { Id = 4, Name = "Tone Oilnume ��Φ��S�]", Price = 8888, Category = "Totebag", Photo = "/Assets/images/ProductImages/Totebag/Totebag4.jpg", ProductPage = "#" },
                new ProductsSectionViewModel { Id = 5, Name = "Tone Oilnume ����׭I�]", Price = 8888, Category = "Totebag", Photo = "/Assets/images/ProductImages/Totebag/Totebag5.jpg", ProductPage = "#" },
                new ProductsSectionViewModel { Id = 6, Name = "Tone Oilnume �g�A�l�t�]", Price = 8888, Category = "Totebag", Photo = "/Assets/images/ProductImages/Totebag/Totebag6.jpg", ProductPage = "#" },

                new ProductsSectionViewModel { Id = 7, Name = "Tone Oilnume ������I�]", Price = 8888, Category = "Backpack", Photo = "/Assets/images/ProductImages/Backpack/Backpack1.jpg", ProductPage = "#" },
                new ProductsSectionViewModel { Id = 8, Name = "Tone Oilnume ��I�]", Price = 8888, Category = "Backpack", Photo = "/Assets/images/ProductImages/Backpack/Backpack2.jpg", ProductPage = "#" },

                new ProductsSectionViewModel { Id = 9, Name = "Belchord ����", Price = 8888, Category = "Longclip", Photo = "/Assets/images/ProductImages/Longclip/Longclip1.jpg", ProductPage = "#" },
                new ProductsSectionViewModel { Id = 10, Name = "Diario ����", Price = 8888, Category = "Longclip", Photo = "/Assets/images/ProductImages/Longclip/Longclip2.jpg", ProductPage = "#" },
                new ProductsSectionViewModel { Id = 11, Name = "Tone Oilnume ��L���s������", Price = 8888, Category = "Longclip", Photo = "/Assets/images/ProductImages/Longclip/Longclip3.jpg", ProductPage = "#" },
                new ProductsSectionViewModel { Id = 12, Name = "Tone Oilnume ��¶������", Price = 8888, Category = "Longclip", Photo = "/Assets/images/ProductImages/Longclip/Longclip4.jpg", ProductPage = "#" },
                new ProductsSectionViewModel { Id = 13, Name = "Urbano ���֧�", Price = 8888, Category = "Longclip", Photo = "/Assets/images/ProductImages/Longclip/Longclip5.jpg", ProductPage = "#" },

                new ProductsSectionViewModel { Id = 14, Name = "Belchord�s���]", Price = 8888, Category = "Coinwallet", Photo = "/Assets/images/ProductImages/Coinwallet/Coinwallet1.jpg", ProductPage = "#" },
                new ProductsSectionViewModel { Id = 15, Name = "Bridle��ιs���]", Price = 8888, Category = "Coinwallet", Photo = "/Assets/images/ProductImages/Coinwallet/Coinwallet2.jpg", ProductPage = "#" },
                new ProductsSectionViewModel { Id = 16, Name = "Diario �������s���]", Price = 8888, Category = "Coinwallet", Photo = "/Assets/images/ProductImages/Coinwallet/Coinwallet3.jpg", ProductPage = "#" },
                new ProductsSectionViewModel { Id = 17, Name = "Tone Oilnume ��L���g�A�s���]", Price = 8888, Category = "Coinwallet", Photo = "/Assets/images/ProductImages/Coinwallet/Coinwallet4.jpg", ProductPage = "#" },
                new ProductsSectionViewModel { Id = 18, Name = "Tone Oilnume ��L���s���U", Price = 8888, Category = "Coinwallet", Photo = "/Assets/images/ProductImages/Coinwallet/Coinwallet5.jpg", ProductPage = "#" },
                new ProductsSectionViewModel { Id = 19, Name = "Urbano�s���]", Price = 8888, Category = "Coinwallet", Photo = "/Assets/images/ProductImages/Coinwallet/Coinwallet6.jpg", ProductPage = "#" },

                new ProductsSectionViewModel { Id = 20, Name = "Bridle �W����", Price = 8888, Category = "Namecard", Photo = "/Assets/images/ProductImages/Namecard/Namecard1.jpg", ProductPage = "#" },
                new ProductsSectionViewModel { Id = 21, Name = "Clarte �H�ʦW����", Price = 8888, Category = "Namecard", Photo = "/Assets/images/ProductImages/Namecard/Namecard2.jpg", ProductPage = "#" },
                new ProductsSectionViewModel { Id = 22, Name = "Cordovan ���v�֦W����", Price = 8888, Category = "Namecard", Photo = "/Assets/images/ProductImages/Namecard/Namecard3.jpg", ProductPage = "#" },
                new ProductsSectionViewModel { Id = 23, Name = "Cordovan ���v�ֲ��d�M", Price = 8888, Category = "Namecard", Photo = "/Assets/images/ProductImages/Namecard/Namecard4.jpg", ProductPage = "#" },
                new ProductsSectionViewModel { Id = 24, Name = "Urbano �W����", Price = 8888, Category = "Namecard", Photo = "/Assets/images/ProductImages/Namecard/Namecard5.jpg", ProductPage = "#" },
                new ProductsSectionViewModel { Id = 25, Name = "Urbano ����d����", Price = 8888, Category = "Namecard", Photo = "/Assets/images/ProductImages/Namecard/Namecard6.jpg", ProductPage = "#" }
                );
        }
    }
}
