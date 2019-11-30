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
               new Product { Id = 1, Name = "Diario 迷你隨行斜肩袋", Price= 12856 , Category = "Totebag" },
                new Product { Id = 2, Name = "Clarte 流蘇迷你箱型包", Price = 15438 , Category = "Totebag"},
                new Product { Id = 3, Name = "Tone Oilnume 迷你郵差包", Price = 18378, Category = "Totebag"},
                new Product { Id = 4, Name = "Tone Oilnume 兩用托特包", Price = 26648, Category = "Totebag"},
                new Product { Id = 5, Name = "Tone Oilnume 拉鍊斜背包", Price = 25729, Category = "Totebag"},
                new Product { Id = 6, Name = "Plota 防水兩用斜背包", Price = 12497, Category = "Totebag"},

                new Product { Id = 7, Name = "Tone Oilnume 中型後背包", Price = 27199, Category = "Backpack"},
                new Product { Id = 8, Name = "Tone Oilnume 後背包", Price = 28670, Category = "Backpack"},

                new Product { Id = 9, Name = "Belchord 長夾", Price = 22605, Category = "Longclip"},
                new Product { Id = 10, Name = "Diario 長夾", Price = 9189, Category = "Longclip"},
                new Product { Id = 11, Name = "Tone Oilnume 蛙嘴式零錢長夾", Price = 8822, Category = "Longclip"},
                new Product { Id = 12, Name = "Tone Oilnume 纏繞式長夾", Price = 8454, Category = "Longclip" },
                new Product { Id = 13, Name = "Urbano 長皮夾", Price = 9924, Category = "Longclip" },

                new Product { Id = 14, Name = "Belchord 零錢包", Price =  7719, Category = "Coinwallet"},
                new Product { Id = 15, Name = "Urbano 零錢包", Price = 4044, Category = "Coinwallet"},
                new Product { Id = 16, Name = "Bridle 方形零錢包", Price = 3910, Category = "Coinwallet"},
                new Product { Id = 17, Name = "Tone Oilnume 蛙嘴式零錢袋", Price =  5514, Category = "Coinwallet"},
                new Product { Id = 18, Name = "Diario 雙釦式零錢包", Price = 2757, Category = "Coinwallet"},
                new Product { Id = 19, Name = "Tone Oilnume 蛙嘴式迷你零錢包", Price = 2573, Category = "Coinwallet"},

                new Product { Id = 20, Name = "Bridle 名片夾", Price = 5113, Category = "Namecard" },
                new Product { Id = 21, Name = "Clarte 信封名片夾", Price = 3492, Category = "Namecard"},
                new Product { Id = 22, Name = "Cordovan 馬臀皮名片夾", Price = 7719, Category = "Namecard"},
                new Product { Id = 23, Name = "Cordovan 馬臀皮票卡套", Price = 4962, Category = "Namecard"},
                new Product { Id = 24, Name = "Urbano 名片夾", Price = 6249, Category = "Namecard"},
                new Product { Id = 25, Name = "Urbano 拉鍊卡片夾", Price = 5514, Category = "Namecard"}
               );


        }
    }
}
