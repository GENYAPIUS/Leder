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

        protected override void Seed(Leder.Models.LederContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Products.AddOrUpdate(
                x => x.ProductId,
                new Product { ProductId = 1, Name = "Diario �g�A�H��תӳU", Price = 12856, CategoryId = 1, Photos = "Totebag1.jpg,Totebag1_D_1.jpg,Totebag1_D_2.jpg,Totebag1_D_3.jpg,Totebag1_D_4.jpg,Totebag1_D_5.jpg" },
                new Product { ProductId = 2, Name = "Clarte �yĬ�g�A�c���]", Price = 15438, CategoryId = 1, Photos = "Totebag2.jpg,Totebag2_D_1.jpg,Totebag2_D_2.jpg,Totebag2_D_3.jpg,Totebag2_D_4.jpg,Totebag2_D_5.jpg" },
                new Product { ProductId = 3, Name = "Tone Oilnume �g�A�l�t�]", Price = 18378, CategoryId = 1, Photos = "Totebag3.jpg,Totebag3_D_1.jpg,Totebag3_D_2.jpg,Totebag3_D_3.jpg,Totebag3_D_4.jpg,Totebag3_D_5.jpg" },
                new Product { ProductId = 4, Name = "Tone Oilnume ��Φ��S�]", Price = 26648, CategoryId = 1, Photos = "Totebag4.jpg,Totebag4_D_1.jpg,Totebag4_D_2.jpg,Totebag4_D_3.jpg,Totebag4_D_4.jpg,Totebag4_D_5.jpg" },
                new Product { ProductId = 5, Name = "Tone Oilnume ����׭I�]", Price = 25729, CategoryId = 1, Photos = "Totebag5.jpg,Totebag5_D_1.jpg,Totebag5_D_2.jpg,Totebag5_D_3.jpg,Totebag5_D_4.jpg,Totebag5_D_5.jpg" },
                new Product { ProductId = 6, Name = "Plota ������α׭I�]", Price = 12497, CategoryId = 1, Photos = "Totebag6.jpg,Totebag6_D_1.jpg,Totebag6_D_2.jpg,Totebag6_D_3.jpg,Totebag6_D_4.jpg,Totebag6_D_5.jpg" },
                new Product { ProductId = 7, Name = "Urbano ���Ʀ��S�]", Price = 38717, CategoryId = 1, Photos = "Totebag7.jpg,Totebag7_D_1.jpg,Totebag7_D_2.jpg,Totebag7_D_3.jpg,Totebag7_D_4.jpg,Totebag7_D_5.jpg" },
                new Product { ProductId = 8, Name = "Armas �����֨�Ϊ������S�]", Price = 27655, CategoryId = 1, Photos = "Totebag8.jpg,Totebag8_D_1.jpg,Totebag8_D_2.jpg,Totebag8_D_3.jpg,Totebag8_D_4.jpg,Totebag8_D_5.jpg" },

                new Product { ProductId = 9, Name = "Tone Oilnume ������I�]", Price = 27199, CategoryId = 2, Photos = "Backpack1.jpg,Backpack1_D_1.jpg,Backpack1_D_2.jpg,Backpack1_D_3.jpg,Backpack1_D_4.jpg,Backpack1_D_5.jpg" },
                new Product { ProductId = 10, Name = "Tone Oilnume ��I�]", Price = 28670, CategoryId = 2, Photos = "Backpack2.jpg,Backpack2_D_1.jpg,Backpack2_D_2.jpg,Backpack2_D_3.jpg,Backpack2_D_4.jpg,Backpack2_D_5.jpg" },

                new Product { ProductId = 11, Name = "Belchord ����", Price = 22605, CategoryId = 3, Photos = "Longclip1.jpg,Longclip1_D_1.jpg,Longclip1_D_2.jpg,Longclip1_D_3.jpg,Longclip1_D_4.jpg,Longclip1_D_5.jpg" },
                new Product { ProductId = 12, Name = "Diario ����", Price = 9189, CategoryId = 3, Photos = "Longclip2.jpg,Longclip2_D_1.jpg,Longclip2_D_2.jpg,Longclip2_D_3.jpg,Longclip2_D_4.jpg,Longclip2_D_5.jpg" },
                new Product { ProductId = 13, Name = "Tone Oilnume ��L���s������", Price = 8822, CategoryId = 3, Photos = "Longclip3.jpg,Longclip3_D_1.jpg,Longclip3_D_2.jpg,Longclip3_D_3.jpg,Longclip3_D_4.jpg,Longclip3_D_5.jpg" },
                new Product { ProductId = 14, Name = "Tone Oilnume ��¶������", Price = 8454, CategoryId = 3, Photos = "Longclip4.jpg,Longclip4_D_1.jpg,Longclip4_D_2.jpg,Longclip4_D_3.jpg,Longclip4_D_4.jpg,Longclip4_D_5.jpg" },
                new Product { ProductId = 15, Name = "Urbano ���֧�", Price = 9924, CategoryId = 3, Photos = "Longclip5.jpg,Longclip5_D_1.jpg,Longclip5_D_2.jpg,Longclip5_D_3.jpg,Longclip5_D_4.jpg,Longclip5_D_5.jpg" },

                new Product { ProductId = 16, Name = "Belchord �s���]", Price = 7719, CategoryId = 4, Photos = "Coinwallet1.jpg,Coinwallet1_D_1.jpg,Coinwallet1_D_2.jpg,Coinwallet1_D_3.jpg,Coinwallet1_D_4.jpg,Coinwallet1_D_5.jpg" },
                new Product { ProductId = 17, Name = "Urbano �s���]", Price = 4044, CategoryId = 4, Photos = "Coinwallet2.jpg,Coinwallet2_D_1.jpg,Coinwallet2_D_2.jpg,Coinwallet2_D_3.jpg,Coinwallet2_D_4.jpg,Coinwallet2_D_5.jpg" },
                new Product { ProductId = 18, Name = "Bridle ��ιs���]", Price = 3910, CategoryId = 4, Photos = "Coinwallet3.jpg,Coinwallet3_D_1.jpg,Coinwallet3_D_2.jpg,Coinwallet3_D_3.jpg,Coinwallet3_D_4.jpg,Coinwallet3_D_5.jpg" },
                new Product { ProductId = 19, Name = "Tone Oilnume ��L���s���U", Price = 5514, CategoryId = 4, Photos = "Coinwallet4.jpg,Coinwallet4_D_1.jpg,Coinwallet4_D_2.jpg,Coinwallet4_D_3.jpg,Coinwallet4_D_4.jpg,Coinwallet4_D_5.jpg" },
                new Product { ProductId = 20, Name = "Diario �������s���]", Price = 2757, CategoryId = 4, Photos = "Coinwallet5.jpg,Coinwallet5_D_1.jpg,Coinwallet5_D_2.jpg,Coinwallet5_D_3.jpg,Coinwallet5_D_4.jpg,Coinwallet5_D_5.jpg" },
                new Product { ProductId = 21, Name = "Tone Oilnume ��L���g�A�s���]", Price = 2573, CategoryId = 4, Photos = "Coinwallet6.jpg,Coinwallet6_D_1.jpg,Coinwallet6_D_2.jpg,Coinwallet6_D_3.jpg,Coinwallet6_D_4.jpg,Coinwallet6_D_5.jpg" },
                new Product { ProductId = 22, Name = "Cordovan ����ιs���]", Price = 8150, CategoryId = 4, Photos = "Coinwallet7.jpg,Coinwallet7_D_1.jpg,Coinwallet7_D_2.jpg,Coinwallet7_D_3.jpg,Coinwallet7_D_4.jpg,Coinwallet7_D_5.jpg" },
                new Product { ProductId = 23, Name = "Diario L������u��", Price = 4261, CategoryId = 4, Photos = "Coinwallet8.jpg,Coinwallet8_D_1.jpg,Coinwallet8_D_2.jpg,Coinwallet8_D_3.jpg,Coinwallet8_D_4.jpg,Coinwallet8_D_5.jpg" },

                new Product { ProductId = 24, Name = "Bridle �W����", Price = 5113, CategoryId = 5, Photos = "Namecard1.jpg,Namecard1_D_1.jpg,Namecard1_D_2.jpg,Namecard1_D_3.jpg,Namecard1_D_4.jpg,Namecard1_D_5.jpg" },
                new Product { ProductId = 25, Name = "Clarte �H�ʦW����", Price = 3492, CategoryId = 5, Photos = "Namecard2.jpg,Namecard2_D_1.jpg,Namecard2_D_2.jpg,Namecard2_D_3.jpg,Namecard2_D_4.jpg,Namecard2_D_5.jpg" },
                new Product { ProductId = 26, Name = "Urbano �W����", Price = 7719, CategoryId = 5, Photos = "Namecard3.jpg,Namecard3_D_1.jpg,Namecard3_D_2.jpg,Namecard3_D_3.jpg,Namecard3_D_4.jpg,Namecard3_D_5.jpg" },
                new Product { ProductId = 27, Name = "Cordovan ���v�֦W����", Price = 4962, CategoryId = 5, Photos = "Namecard4.jpg,Namecard4_D_1.jpg,Namecard4_D_2.jpg,Namecard4_D_3.jpg,Namecard4_D_4.jpg,Namecard4_D_5.jpg" },
                new Product { ProductId = 28, Name = "Cordovan ���v�ֲ��d�M", Price = 6249, CategoryId = 5, Photos = "Namecard5.jpg,Namecard5_D_1.jpg,Namecard5_D_2.jpg,Namecard5_D_3.jpg,Namecard5_D_4.jpg,Namecard5_D_5.jpg" },
                new Product { ProductId = 29, Name = "Urbano ����d����", Price = 5514, CategoryId = 5, Photos = "Namecard6.jpg,Namecard6_D_1.jpg,Namecard6_D_2.jpg,Namecard6_D_3.jpg,Namecard6_D_4.jpg,Namecard6_D_5.jpg" },
                new Product { ProductId = 30, Name = "Bridle ����d����", Price = 5153, CategoryId = 5, Photos = "Namecard7.jpg,Namecard7_D_1.jpg,Namecard7_D_2.jpg,Namecard7_D_3.jpg,Namecard7_D_4.jpg,Namecard7_D_5.jpg" }

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
