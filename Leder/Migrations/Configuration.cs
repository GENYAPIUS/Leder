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
               x => x.ProductId,
                new Product { ProductId = 1, Name = "Diario 迷你隨行斜肩袋", Price = 12856, CategoryId = 1 },
                new Product { ProductId = 2, Name = "Clarte 流蘇迷你箱型包", Price = 15438, CategoryId = 1 },
                new Product { ProductId = 3, Name = "Tone Oilnume 迷你郵差包", Price = 18378, CategoryId = 1 },
                new Product { ProductId = 4, Name = "Tone Oilnume 兩用托特包", Price = 26648, CategoryId = 1 },
                new Product { ProductId = 5, Name = "Tone Oilnume 拉鍊斜背包", Price = 25729, CategoryId = 1 },
                new Product { ProductId = 6, Name = "Plota 防水兩用斜背包", Price = 12497, CategoryId = 1 },

                new Product { ProductId = 7, Name = "Tone Oilnume 中型後背包", Price = 27199, CategoryId = 2 },
                new Product { ProductId = 8, Name = "Tone Oilnume 後背包", Price = 28670, CategoryId = 2 },

                new Product { ProductId = 9, Name = "Belchord 長夾", Price = 22605, CategoryId = 3 },
                new Product { ProductId = 10, Name = "Diario 長夾", Price = 9189, CategoryId = 3 },
                new Product { ProductId = 11, Name = "Tone Oilnume 蛙嘴式零錢長夾", Price = 8822, CategoryId = 3 },
                new Product { ProductId = 12, Name = "Tone Oilnume 纏繞式長夾", Price = 8454, CategoryId = 3 },
                new Product { ProductId = 13, Name = "Urbano 長皮夾", Price = 9924, CategoryId = 3 },

                new Product { ProductId = 14, Name = "Belchord 零錢包", Price = 7719, CategoryId = 4 },
                new Product { ProductId = 15, Name = "Urbano 零錢包", Price = 4044, CategoryId = 4 },
                new Product { ProductId = 16, Name = "BrProductIdle 方形零錢包", Price = 3910, CategoryId = 4 },
                new Product { ProductId = 17, Name = "Tone Oilnume 蛙嘴式零錢袋", Price = 5514, CategoryId = 4 },
                new Product { ProductId = 18, Name = "Diario 雙釦式零錢包", Price = 2757, CategoryId = 4 },
                new Product { ProductId = 19, Name = "Tone Oilnume 蛙嘴式迷你零錢包", Price = 2573, CategoryId = 4 },

                new Product { ProductId = 20, Name = "Bridle 名片夾", Price = 5113, CategoryId = 5 },
                new Product { ProductId = 21, Name = "Clarte 信封名片夾", Price = 3492, CategoryId = 5 },
                new Product { ProductId = 22, Name = "Cordovan 馬臀皮名片夾", Price = 7719, CategoryId = 5 },
                new Product { ProductId = 23, Name = "Cordovan 馬臀皮票卡套", Price = 4962, CategoryId = 5 },
                new Product { ProductId = 24, Name = "Urbano 名片夾", Price = 6249, CategoryId = 5 },
                new Product { ProductId = 25, Name = "Urbano 拉鍊卡片夾", Price = 5514, CategoryId = 5 }
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
