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
                new Product { ProductId = 1, Name = "Diario 迷你隨行斜肩袋", Price = 12856, CategoryId = 1,Color= "brown", Photos = "Totebag1.jpg,Totebag1_D_1.jpg,Totebag1_D_2.jpg,Totebag1_D_3.jpg,Totebag1_D_4.jpg,Totebag1_D_5.jpg",Description = "「Diario」是義大利文中的「日記」之意。我們期望此系列製品能夠像日記一般， 將每天記錄下來， 就算是傷痕、髒污， 所有痕跡都是珍貴的回憶。Diario 系列採用產自北美的去勢成年牛皮， 以植物鞣法進行鞣製， 再浸泡於油脂裡完成「Oil Mellow Leather」後， 所製作而成；革面擁有虎斑紋理、肋部傷痕、色素黑點等天然皮革樣貌， 具有豐足厚度與張力；此外， 如果想要在手感柔順的皮革中， 保持堅固耐用的強韌度， 就需要製革職人的技術。" },
                new Product { ProductId = 2, Name = "Clarte 流蘇迷你箱型包", Price = 15438, CategoryId = 1, Color="pink", Photos = "Totebag2.jpg,Totebag2_D_1.jpg,Totebag2_D_2.jpg,Totebag2_D_3.jpg,Totebag2_D_4.jpg,Totebag2_D_5.jpg" },
                new Product { ProductId = 3, Name = "Tone Oilnume 迷你郵差包", Price = 18378, CategoryId = 1, Color="green", Photos = "Totebag3.jpg,Totebag3_D_1.jpg,Totebag3_D_2.jpg,Totebag3_D_3.jpg,Totebag3_D_4.jpg,Totebag3_D_5.jpg" },
                new Product { ProductId = 4, Name = "Tone Oilnume 兩用托特包", Price = 26648, CategoryId = 1, Color= "lightbrown", Photos = "Totebag4.jpg,Totebag4_D_1.jpg,Totebag4_D_2.jpg,Totebag4_D_3.jpg,Totebag4_D_4.jpg,Totebag4_D_5.jpg" },
                new Product { ProductId = 5, Name = "Tone Oilnume 拉鍊斜背包", Price = 25729, CategoryId = 1, Color="darkbrown", Photos = "Totebag5.jpg,Totebag5_D_1.jpg,Totebag5_D_2.jpg,Totebag5_D_3.jpg,Totebag5_D_4.jpg,Totebag5_D_5.jpg" },
                new Product { ProductId = 6, Name = "Plota 防水兩用斜背包", Price = 12497, CategoryId = 1, Color= "darkbrown", Photos = "Totebag6.jpg,Totebag6_D_1.jpg,Totebag6_D_2.jpg,Totebag6_D_3.jpg,Totebag6_D_4.jpg,Totebag6_D_5.jpg" },
                new Product { ProductId = 7, Name = "Urbano 公事托特包", Price = 38717, CategoryId = 1, Color= "darkbrown", Photos = "Totebag7.jpg,Totebag7_D_1.jpg,Totebag7_D_2.jpg,Totebag7_D_3.jpg,Totebag7_D_4.jpg,Totebag7_D_5.jpg" },
                new Product { ProductId = 8, Name = "Armas 水牛皮兩用直式托特包", Price = 27655, CategoryId = 1, Color= "black", Photos = "Totebag8.jpg,Totebag8_D_1.jpg,Totebag8_D_2.jpg,Totebag8_D_3.jpg,Totebag8_D_4.jpg,Totebag8_D_5.jpg" },

                new Product { ProductId = 9, Name = "Tone Oilnume 中型後背包", Price = 27199, CategoryId = 2, Color="grenn", Photos = "Backpack1.jpg,Backpack1_D_1.jpg,Backpack1_D_2.jpg,Backpack1_D_3.jpg,Backpack1_D_4.jpg,Backpack1_D_5.jpg" },
                new Product { ProductId = 10, Name = "Tone Oilnume 後背包", Price = 28670, CategoryId = 2, Color= "lightbrown", Photos = "Backpack2.jpg,Backpack2_D_1.jpg,Backpack2_D_2.jpg,Backpack2_D_3.jpg,Backpack2_D_4.jpg,Backpack2_D_5.jpg" },

                new Product { ProductId = 11, Name = "Belchord 長夾", Price = 22605, CategoryId = 3, Color="black", Photos = "Longclip1.jpg,Longclip1_D_1.jpg,Longclip1_D_2.jpg,Longclip1_D_3.jpg,Longclip1_D_4.jpg,Longclip1_D_5.jpg" },
                new Product { ProductId = 12, Name = "Diario 長夾", Price = 9189, CategoryId = 3, Color="brown", Photos = "Longclip2.jpg,Longclip2_D_1.jpg,Longclip2_D_2.jpg,Longclip2_D_3.jpg,Longclip2_D_4.jpg,Longclip2_D_5.jpg" },
                new Product { ProductId = 13, Name = "Tone Oilnume 蛙嘴式零錢長夾", Price = 8822, CategoryId = 3, Color="green", Photos = "Longclip3.jpg,Longclip3_D_1.jpg,Longclip3_D_2.jpg,Longclip3_D_3.jpg,Longclip3_D_4.jpg,Longclip3_D_5.jpg" },
                new Product { ProductId = 14, Name = "Tone Oilnume 纏繞式長夾", Price = 8454, CategoryId = 3, Color= "lightbrown", Photos = "Longclip4.jpg,Longclip4_D_1.jpg,Longclip4_D_2.jpg,Longclip4_D_3.jpg,Longclip4_D_4.jpg,Longclip4_D_5.jpg" },
                new Product { ProductId = 15, Name = "Urbano 長皮夾", Price = 9924, CategoryId = 3, Color="darkbrown", Photos = "Longclip5.jpg,Longclip5_D_1.jpg,Longclip5_D_2.jpg,Longclip5_D_3.jpg,Longclip5_D_4.jpg,Longclip5_D_5.jpg" },

                new Product { ProductId = 16, Name = "Belchord 零錢包", Price = 7719, CategoryId = 4, Color= "darkbrown", Photos = "Coinwallet1.jpg,Coinwallet1_D_1.jpg,Coinwallet1_D_2.jpg,Coinwallet1_D_3.jpg,Coinwallet1_D_4.jpg,Coinwallet1_D_5.jpg" },
                new Product { ProductId = 17, Name = "Urbano 零錢包", Price = 4044, CategoryId = 4, Color= "darkbrown", Photos = "Coinwallet2.jpg,Coinwallet2_D_1.jpg,Coinwallet2_D_2.jpg,Coinwallet2_D_3.jpg,Coinwallet2_D_4.jpg,Coinwallet2_D_5.jpg" },
                new Product { ProductId = 18, Name = "Bridle 方形零錢包", Price = 3910, CategoryId = 4, Color="black", Photos = "Coinwallet3.jpg,Coinwallet3_D_1.jpg,Coinwallet3_D_2.jpg,Coinwallet3_D_3.jpg,Coinwallet3_D_4.jpg,Coinwallet3_D_5.jpg" },
                new Product { ProductId = 19, Name = "Tone Oilnume 蛙嘴式零錢袋", Price = 5514, CategoryId = 4, Color="lightbrown", Photos = "Coinwallet4.jpg,Coinwallet4_D_1.jpg,Coinwallet4_D_2.jpg,Coinwallet4_D_3.jpg,Coinwallet4_D_4.jpg,Coinwallet4_D_5.jpg" },
                new Product { ProductId = 20, Name = "Diario 雙釦式零錢包", Price = 2757, CategoryId = 4, Color="brown", Photos = "Coinwallet5.jpg,Coinwallet5_D_1.jpg,Coinwallet5_D_2.jpg,Coinwallet5_D_3.jpg,Coinwallet5_D_4.jpg,Coinwallet5_D_5.jpg" },
                new Product { ProductId = 21, Name = "Tone Oilnume 蛙嘴式迷你零錢包", Price = 2573, CategoryId = 4, Color="lightbrown", Photos = "Coinwallet6.jpg,Coinwallet6_D_1.jpg,Coinwallet6_D_2.jpg,Coinwallet6_D_3.jpg,Coinwallet6_D_4.jpg,Coinwallet6_D_5.jpg" },
                new Product { ProductId = 22, Name = "Cordovan 馬蹄形零錢包", Price = 8150, CategoryId = 4, Color= "darkbrown", Photos = "Coinwallet7.jpg,Coinwallet7_D_1.jpg,Coinwallet7_D_2.jpg,Coinwallet7_D_3.jpg,Coinwallet7_D_4.jpg,Coinwallet7_D_5.jpg" },
                new Product { ProductId = 23, Name = "Diario L型拉鍊短夾", Price = 4261, CategoryId = 4, Color="brown", Photos = "Coinwallet8.jpg,Coinwallet8_D_1.jpg,Coinwallet8_D_2.jpg,Coinwallet8_D_3.jpg,Coinwallet8_D_4.jpg,Coinwallet8_D_5.jpg" },

                new Product { ProductId = 24, Name = "Bridle 名片夾", Price = 5113, CategoryId = 5, Color="black", Photos = "Namecard1.jpg,Namecard1_D_1.jpg,Namecard1_D_2.jpg,Namecard1_D_3.jpg,Namecard1_D_4.jpg,Namecard1_D_5.jpg" },
                new Product { ProductId = 25, Name = "Clarte 信封名片夾", Price = 3492, CategoryId = 5, Color= "blue", Photos = "Namecard2.jpg,Namecard2_D_1.jpg,Namecard2_D_2.jpg,Namecard2_D_3.jpg,Namecard2_D_4.jpg,Namecard2_D_5.jpg" },
                new Product { ProductId = 26, Name = "Urbano 名片夾", Price = 7719, CategoryId = 5, Color="darkbrown", Photos = "Namecard3.jpg,Namecard3_D_1.jpg,Namecard3_D_2.jpg,Namecard3_D_3.jpg,Namecard3_D_4.jpg,Namecard3_D_5.jpg" },
                new Product { ProductId = 27, Name = "Cordovan 馬臀皮名片夾", Price = 4962, CategoryId = 5, Color="black", Photos = "Namecard4.jpg,Namecard4_D_1.jpg,Namecard4_D_2.jpg,Namecard4_D_3.jpg,Namecard4_D_4.jpg,Namecard4_D_5.jpg" },
                new Product { ProductId = 28, Name = "Cordovan 馬臀皮票卡套", Price = 6249, CategoryId = 5, Color="brown", Photos = "Namecard5.jpg,Namecard5_D_1.jpg,Namecard5_D_2.jpg,Namecard5_D_3.jpg,Namecard5_D_4.jpg,Namecard5_D_5.jpg" },
                new Product { ProductId = 29, Name = "Urbano 拉鍊卡片夾", Price = 5514, CategoryId = 5, Color="darkbrown", Photos = "Namecard6.jpg,Namecard6_D_1.jpg,Namecard6_D_2.jpg,Namecard6_D_3.jpg,Namecard6_D_4.jpg,Namecard6_D_5.jpg" },
                new Product { ProductId = 30, Name = "Bridle 拉鍊卡片夾", Price = 5153, CategoryId = 5, Color="green", Photos = "Namecard7.jpg,Namecard7_D_1.jpg,Namecard7_D_2.jpg,Namecard7_D_3.jpg,Namecard7_D_4.jpg,Namecard7_D_5.jpg" }

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
