namespace Leder.Migrations
{
    using Leder.Models;
    using Leder.ViewModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Leder.Models.LederContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LederContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Products.AddOrUpdate(
               x => x.ProductId,
                new Product { ProductId = 1, Name = "Diario 迷你隨行斜肩袋", Price = 12856, CategoryId = 1, Photo = "/Assets/images/Totebag/Totebag1.jpg"},
                new Product { ProductId = 2, Name = "Clarte 流蘇迷你箱型包", Price = 15438, CategoryId = 1, Photo = "/Assets/images/Totebag/Totebag2.jpg" },
                new Product { ProductId = 3, Name = "Tone Oilnume 迷你郵差包", Price = 18378, CategoryId = 1, Photo = "/Assets/images/Totebag/Totebag3.jpg" },
                new Product { ProductId = 4, Name = "Tone Oilnume 兩用托特包", Price = 26648, CategoryId = 1, Photo = "/Assets/images/Totebag/Totebag4.jpg" },
                new Product { ProductId = 5, Name = "Tone Oilnume 拉鍊斜背包", Price = 25729, CategoryId = 1, Photo = "/Assets/images/Totebag/Totebag5.jpg" },
                new Product { ProductId = 6, Name = "Plota 防水兩用斜背包", Price = 12497, CategoryId = 1, Photo = "/Assets/images/Totebag/Totebag6.jpg" },
                new Product { ProductId = 7, Name = "Urbano 公事托特包", Price = 38717, CategoryId = 1, Photo = " /Assets/images/Totebag/Totebag7.jpg" },
                new Product { ProductId = 8, Name = "Armas 水牛皮兩用直式托特包", Price = 27655, CategoryId = 1, Photo = "/Assets/images/Totebag/Totebag8.jpg" },


                new Product { ProductId = 9, Name = "Tone Oilnume 中型後背包", Price = 27199, CategoryId = 2, Photo = "/Assets/images/Backpack/Backpack1.jpg" },
                new Product { ProductId = 10, Name = "Tone Oilnume 後背包", Price = 28670, CategoryId = 2, Photo = "/Assets/images/Backpack/Backpack2.jpg" },

                new Product { ProductId = 11, Name = "Belchord 長夾", Price = 22605, CategoryId = 3, Photo = "/Assets/images/Longclip/Longclip1.jpg" },
                new Product { ProductId = 12, Name = "Diario 長夾", Price = 9189, CategoryId = 3, Photo = "/Assets/images/Longclip/Longclip2.jpg" },
                new Product { ProductId = 13, Name = "Tone Oilnume 蛙嘴式零錢長夾", Price = 8822, CategoryId = 3, Photo = "/Assets/images/Longclip/Longclip3.jpg" },
                new Product { ProductId = 14, Name = "Tone Oilnume 纏繞式長夾", Price = 8454, CategoryId = 3, Photo = "/Assets/images/Longclip/Longclip4.jpg" },
                new Product { ProductId = 15, Name = "Urbano 長皮夾", Price = 9924, CategoryId = 3, Photo = "/Assets/images/Longclip/Longclip5.jpg" },

                new Product { ProductId = 16, Name = "Belchord 零錢包", Price = 7719, CategoryId = 4, Photo = "/Assets/images/Coinwallet/Coinwallet1.jpg" },
                new Product { ProductId = 17, Name = "Urbano 零錢包", Price = 4044, CategoryId = 4, Photo = "/Assets/images/Coinwallet/Coinwallet2.jpg" },
                new Product { ProductId = 18, Name = "BrProductIdle 方形零錢包", Price = 3910, CategoryId = 4, Photo = "/Assets/images/Coinwallet/Coinwallet3.jpg" },
                new Product { ProductId = 19, Name = "Tone Oilnume 蛙嘴式零錢袋", Price = 5514, CategoryId = 4, Photo = "/Assets/images/Coinwallet/Coinwallet4.jpg" },
                new Product { ProductId = 20, Name = "Diario 雙釦式零錢包", Price = 2757, CategoryId = 4, Photo = "/Assets/images/Coinwallet/Coinwallet5.jpg" },
                new Product { ProductId = 21, Name = "Tone Oilnume 蛙嘴式迷你零錢包", Price = 2573, CategoryId = 4, Photo = "/Assets/images/Coinwallet/Coinwallet6.jpg" },

                new Product { ProductId = 22, Name = "Bridle 名片夾", Price = 5113, CategoryId = 5, Photo = "/Assets/images/Namecard/Namecard1.jpg" },
                new Product { ProductId = 23, Name = "Clarte 信封名片夾", Price = 3492, CategoryId = 5, Photo = "/Assets/images/Namecard/Namecard2.jpg" },
                new Product { ProductId = 24, Name = "Cordovan 馬臀皮名片夾", Price = 7719, CategoryId = 5, Photo = "/Assets/images/Namecard/Namecard3.jpg" },
                new Product { ProductId = 25, Name = "Cordovan 馬臀皮票卡套", Price = 4962, CategoryId = 5, Photo = "/Assets/images/Namecard/Namecard4.jpg" },
                new Product { ProductId = 26, Name = "Urbano 名片夾", Price = 6249, CategoryId = 5, Photo = "/Assets/images/Namecard/Namecard5.jpg" },
                new Product { ProductId = 27, Name = "Urbano 拉鍊卡片夾", Price = 5514, CategoryId = 5, Photo = "/Assets/images/Namecard/Namecard6.jpg" }
               );

            context.Categories.AddOrUpdate(
              x => x.CategoryId,
              new Category { CategoryId = 1, CategoryName = "Totebag" },
              new Category { CategoryId = 2, CategoryName = "Backpack" },
              new Category { CategoryId = 3, CategoryName = "Longclip" },
              new Category { CategoryId = 4, CategoryName = "Coinwallet" },
              new Category { CategoryId = 5, CategoryName = "Namecard" }
              );

            
        }
    }
}
