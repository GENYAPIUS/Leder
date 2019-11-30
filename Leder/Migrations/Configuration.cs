namespace Leder.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Leder.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Leder.Models.ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProductContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            context.Products.AddOrUpdate(
               x => x.Id,
               new Product { Id = 1, Name = "Diario 迷你隨行斜肩袋", Category = "Totebag", Photo = "Totebag1.jpg" },
                new Product { Id = 2, Name = "Clarte 流蘇迷你箱型包", Category = "Totebag", Photo = "Totebag2.jpg" },
                new Product { Id = 3, Name = "Tone Oilnume 迷你郵差包", Category = "Totebag", Photo = "Totebag3.jpg" },
                new Product { Id = 4, Name = "Tone Oilnume 兩用托特包", Category = "Totebag", Photo = "Totebag4.jpg" },
                new Product { Id = 5, Name = "Tone Oilnume 拉鍊斜背包", Category = "Totebag", Photo = "Totebag5.jpg" },
                new Product { Id = 6, Name = "Plota 防水兩用斜背包", Category = "Totebag", Photo = "Totebag6.jpg" },

                new Product { Id = 7, Name = "Tone Oilnume 中型後背包", Category = "Backpack", Photo = "Backpack1.jpg" },
                new Product { Id = 8, Name = "Tone Oilnume 後背包", Category = "Backpack", Photo = "Backpack2.jpg" },

                new Product { Id = 9, Name = "Belchord 長夾", Category = "Longclip", Photo = "Longclip1.jpg" },
                new Product { Id = 10, Name = "Diario 長夾", Category = "Longclip", Photo = "Longclip2.jpg" },
                new Product { Id = 11, Name = "Tone Oilnume 蛙嘴式零錢長夾", Category = "Longclip", Photo = "Longclip3.jpg" },
                new Product { Id = 12, Name = "Tone Oilnume 纏繞式長夾", Category = "Longclip", Photo = "Longclip4.jpg" },
                new Product { Id = 13, Name = "Urbano 長皮夾", Category = "Longclip", Photo = "Longclip5.jpg" },

                new Product { Id = 14, Name = "Belchord零錢包", Category = "Coinwallet", Photo = "Coinwallet1.jpg" },
                new Product { Id = 15, Name = "Urbano零錢包", Category = "Coinwallet", Photo = "Coinwallet2.jpg" },
                new Product { Id = 16, Name = "Bridle方形零錢包", Category = "Coinwallet", Photo = "Coinwallet3.jpg" },
                new Product { Id = 17, Name = "Tone Oilnume 蛙嘴式零錢袋", Category = "Coinwallet", Photo = "Coinwallet4.jpg" },
                new Product { Id = 18, Name = "Diario 雙釦式零錢包", Category = "Coinwallet", Photo = "Coinwallet5.jpg" },
                new Product { Id = 19, Name = "Tone Oilnume 蛙嘴式迷你零錢包", Category = "Coinwallet", Photo = "Coinwallet6.jpg" },

                new Product { Id = 20, Name = "Bridle 名片夾", Category = "Namecard", Photo = "Namecard1.jpg" },
                new Product { Id = 21, Name = "Clarte 信封名片夾", Category = "Namecard", Photo = "Namecard2.jpg" },
                new Product { Id = 22, Name = "Cordovan 馬臀皮名片夾", Category = "Namecard", Photo = "Namecard3.jpg" },
                new Product { Id = 23, Name = "Cordovan 馬臀皮票卡套", Category = "Namecard", Photo = "Namecard4.jpg" },
                new Product { Id = 24, Name = "Urbano 名片夾", Category = "Namecard", Photo = "Namecard5.jpg" },
                new Product { Id = 25, Name = "Urbano 拉鍊卡片夾", Category = "Namecard", Photo = "Namecard6.jpg" }
               );


        }
    }
}
