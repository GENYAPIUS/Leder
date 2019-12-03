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

            //�u�ק��Ʈw���e�A���N��update-database���O�N�n
            context.Products.AddOrUpdate(
               x => x.ProductId,
                new Product { ProductId = 1, Name = "Diario �g�A�H��תӳU", Price = 12856, CategoryId = 1 },
                new Product { ProductId = 2, Name = "Clarte �yĬ�g�A�c���]", Price = 15438, CategoryId = 1 },
                new Product { ProductId = 3, Name = "Tone Oilnume �g�A�l�t�]", Price = 18378, CategoryId = 1 },
                new Product { ProductId = 4, Name = "Tone Oilnume ��Φ��S�]", Price = 26648, CategoryId = 1 },
                new Product { ProductId = 5, Name = "Tone Oilnume ����׭I�]", Price = 25729, CategoryId = 1 },
                new Product { ProductId = 6, Name = "Plota ������α׭I�]", Price = 12497, CategoryId = 1 },

                new Product { ProductId = 7, Name = "Tone Oilnume ������I�]", Price = 27199, CategoryId = 2 },
                new Product { ProductId = 8, Name = "Tone Oilnume ��I�]", Price = 28670, CategoryId = 2 },

                new Product { ProductId = 9, Name = "Belchord ����", Price = 22605, CategoryId = 3 },
                new Product { ProductId = 10, Name = "Diario ����", Price = 9189, CategoryId = 3 },
                new Product { ProductId = 11, Name = "Tone Oilnume ��L���s������", Price = 8822, CategoryId = 3 },
                new Product { ProductId = 12, Name = "Tone Oilnume ��¶������", Price = 8454, CategoryId = 3 },
                new Product { ProductId = 13, Name = "Urbano ���֧�", Price = 9924, CategoryId = 3 },

                new Product { ProductId = 14, Name = "Belchord �s���]", Price = 7719, CategoryId = 4 },
                new Product { ProductId = 15, Name = "Urbano �s���]", Price = 4044, CategoryId = 4 },
                new Product { ProductId = 16, Name = "BrProductIdle ��ιs���]", Price = 3910, CategoryId = 4 },
                new Product { ProductId = 17, Name = "Tone Oilnume ��L���s���U", Price = 5514, CategoryId = 4 },
                new Product { ProductId = 18, Name = "Diario �������s���]", Price = 2757, CategoryId = 4 },
                new Product { ProductId = 19, Name = "Tone Oilnume ��L���g�A�s���]", Price = 2573, CategoryId = 4 },

                new Product { ProductId = 20, Name = "Bridle �W����", Price = 5113, CategoryId = 5 },
                new Product { ProductId = 21, Name = "Clarte �H�ʦW����", Price = 3492, CategoryId = 5 },
                new Product { ProductId = 22, Name = "Cordovan ���v�֦W����", Price = 7719, CategoryId = 5 },
                new Product { ProductId = 23, Name = "Cordovan ���v�ֲ��d�M", Price = 4962, CategoryId = 5 },
                new Product { ProductId = 24, Name = "Urbano �W����", Price = 6249, CategoryId = 5 },
                new Product { ProductId = 25, Name = "Urbano ����d����", Price = 5514, CategoryId = 5 }
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
