namespace Leder.Migrations
{
    using Leder.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Leder.Models.LederContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Leder.Models.LederContext";
        }

        protected override void Seed(Leder.Models.LederContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Products.AddOrUpdate(
                x => x.Id,
                new Product { Id = 1, Name = "Clarte �yĬ�g�A�c���]", Category = "Totebag", Photo = "Totebag1.jpg", Price = 100 },
                new Product { Id = 2, Name = "Diario �g�A�H��תӳU", Category = "Totebag", Photo = "Totebag2.jpg", Price = 80 },
                new Product { Id = 3, Name = "Plota ������α׭I�]", Category = "Totebag", Photo = "Totebag3.jpg", Price = 90 },
                new Product { Id = 4, Name = "Tone Oilnume ��Φ��S�]", Category = "Totebag", Photo = "Totebag4.jpg", Price = 70 },
                new Product { Id = 5, Name = "Tone Oilnume ����׭I�]", Category = "Totebag", Photo = "Totebag5.jpg", Price = 85 },
                new Product { Id = 6, Name = "Tone Oilnume �g�A�l�t�]", Category = "Totebag", Photo = "Totebag6.jpg", Price = 95 },

                new Product { Id = 7, Name = "Tone Oilnume ������I�]", Category = "Backpack", Photo = "Backpack1.jpg", Price = 150 },
                new Product { Id = 8, Name = "Tone Oilnume ��I�]", Category = "Backpack", Photo = "Backpack2.jpg", Price = 300 },

                new Product { Id = 9, Name = "Belchord ����", Category = "Longclip", Photo = "Longclip1.jpg", Price = 160 },
                new Product { Id = 10, Name = "Diario ����", Category = "Longclip", Photo = "Longclip2.jpg", Price = 180 },
                new Product { Id = 11, Name = "Tone Oilnume ��L���s������", Category = "Longclip", Photo = "Longclip3.jpg", Price = 600 },
                new Product { Id = 12, Name = "Tone Oilnume ��¶������", Category = "Longclip", Photo = "Longclip4.jpg", Price = 805 },
                new Product { Id = 13, Name = "Urbano ���֧�", Category = "Longclip", Photo = "Longclip5.jpg", Price = 90 },

                new Product { Id = 14, Name = "Belchord�s���]", Category = "Coinwallet", Photo = "Coinwallet1.jpg", Price = 600 },
                new Product { Id = 15, Name = "Bridle��ιs���]", Category = "Coinwallet", Photo = "Coinwallet2.jpg", Price = 400 },
                new Product { Id = 16, Name = "Diario �������s���]", Category = "Coinwallet", Photo = "Coinwallet3.jpg", Price = 399 },
                new Product { Id = 17, Name = "Tone Oilnume ��L���g�A�s���]", Category = "Coinwallet", Photo = "Coinwallet4.jpg", Price = 260 },
                new Product { Id = 18, Name = "Tone Oilnume ��L���s���U", Category = "Coinwallet", Photo = "Coinwallet5.jpg", Price = 500 },
                new Product { Id = 19, Name = "Urbano�s���]", Category = "Coinwallet", Photo = "Coinwallet6.jpg", Price = 260 },

                new Product { Id = 20, Name = "Bridle �W����", Category = "Namecard", Photo = "Namecard1.jpg", Price = 265 },
                new Product { Id = 21, Name = "Clarte �H�ʦW����", Category = "Namecard", Photo = "Namecard2.jpg", Price = 780 },
                new Product { Id = 22, Name = "Cordovan ���v�֦W����", Category = "Namecard", Photo = "Namecard3.jpg", Price = 605 },
                new Product { Id = 23, Name = "Cordovan ���v�ֲ��d�M", Category = "Namecard", Photo = "Namecard4.jpg", Price = 455 },
                new Product { Id = 24, Name = "Urbano �W����", Category = "Namecard", Photo = "Namecard5.jpg", Price = 280 },
                new Product { Id = 25, Name = "Urbano ����d����", Category = "Namecard", Photo = "Namecard6.jpg", Price = 350 }


                );
        }
    }
}
