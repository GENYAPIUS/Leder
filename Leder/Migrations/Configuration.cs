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
               new Product { Id = 1, Name = "Diario �g�A�H��תӳU", Price= 12856 , Category = "Totebag" },
                new Product { Id = 2, Name = "Clarte �yĬ�g�A�c���]", Price = 15438 , Category = "Totebag"},
                new Product { Id = 3, Name = "Tone Oilnume �g�A�l�t�]", Price = 18378, Category = "Totebag"},
                new Product { Id = 4, Name = "Tone Oilnume ��Φ��S�]", Price = 26648, Category = "Totebag"},
                new Product { Id = 5, Name = "Tone Oilnume ����׭I�]", Price = 25729, Category = "Totebag"},
                new Product { Id = 6, Name = "Plota ������α׭I�]", Price = 12497, Category = "Totebag"},

                new Product { Id = 7, Name = "Tone Oilnume ������I�]", Price = 27199, Category = "Backpack"},
                new Product { Id = 8, Name = "Tone Oilnume ��I�]", Price = 28670, Category = "Backpack"},

                new Product { Id = 9, Name = "Belchord ����", Price = 22605, Category = "Longclip"},
                new Product { Id = 10, Name = "Diario ����", Price = 9189, Category = "Longclip"},
                new Product { Id = 11, Name = "Tone Oilnume ��L���s������", Price = 8822, Category = "Longclip"},
                new Product { Id = 12, Name = "Tone Oilnume ��¶������", Price = 8454, Category = "Longclip" },
                new Product { Id = 13, Name = "Urbano ���֧�", Price = 9924, Category = "Longclip" },

                new Product { Id = 14, Name = "Belchord �s���]", Price =  7719, Category = "Coinwallet"},
                new Product { Id = 15, Name = "Urbano �s���]", Price = 4044, Category = "Coinwallet"},
                new Product { Id = 16, Name = "Bridle ��ιs���]", Price = 3910, Category = "Coinwallet"},
                new Product { Id = 17, Name = "Tone Oilnume ��L���s���U", Price =  5514, Category = "Coinwallet"},
                new Product { Id = 18, Name = "Diario �������s���]", Price = 2757, Category = "Coinwallet"},
                new Product { Id = 19, Name = "Tone Oilnume ��L���g�A�s���]", Price = 2573, Category = "Coinwallet"},

                new Product { Id = 20, Name = "Bridle �W����", Price = 5113, Category = "Namecard" },
                new Product { Id = 21, Name = "Clarte �H�ʦW����", Price = 3492, Category = "Namecard"},
                new Product { Id = 22, Name = "Cordovan ���v�֦W����", Price = 7719, Category = "Namecard"},
                new Product { Id = 23, Name = "Cordovan ���v�ֲ��d�M", Price = 4962, Category = "Namecard"},
                new Product { Id = 24, Name = "Urbano �W����", Price = 6249, Category = "Namecard"},
                new Product { Id = 25, Name = "Urbano ����d����", Price = 5514, Category = "Namecard"}
               );


        }
    }
}
