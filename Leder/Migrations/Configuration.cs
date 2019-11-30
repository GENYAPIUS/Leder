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
               new Product { Id = 1, Name = "Diario �g�A�H��תӳU", Category = "Totebag", Photo = "Totebag1.jpg" },
                new Product { Id = 2, Name = "Clarte �yĬ�g�A�c���]", Category = "Totebag", Photo = "Totebag2.jpg" },
                new Product { Id = 3, Name = "Tone Oilnume �g�A�l�t�]", Category = "Totebag", Photo = "Totebag3.jpg" },
                new Product { Id = 4, Name = "Tone Oilnume ��Φ��S�]", Category = "Totebag", Photo = "Totebag4.jpg" },
                new Product { Id = 5, Name = "Tone Oilnume ����׭I�]", Category = "Totebag", Photo = "Totebag5.jpg" },
                new Product { Id = 6, Name = "Plota ������α׭I�]", Category = "Totebag", Photo = "Totebag6.jpg" },

                new Product { Id = 7, Name = "Tone Oilnume ������I�]", Category = "Backpack", Photo = "Backpack1.jpg" },
                new Product { Id = 8, Name = "Tone Oilnume ��I�]", Category = "Backpack", Photo = "Backpack2.jpg" },

                new Product { Id = 9, Name = "Belchord ����", Category = "Longclip", Photo = "Longclip1.jpg" },
                new Product { Id = 10, Name = "Diario ����", Category = "Longclip", Photo = "Longclip2.jpg" },
                new Product { Id = 11, Name = "Tone Oilnume ��L���s������", Category = "Longclip", Photo = "Longclip3.jpg" },
                new Product { Id = 12, Name = "Tone Oilnume ��¶������", Category = "Longclip", Photo = "Longclip4.jpg" },
                new Product { Id = 13, Name = "Urbano ���֧�", Category = "Longclip", Photo = "Longclip5.jpg" },

                new Product { Id = 14, Name = "Belchord�s���]", Category = "Coinwallet", Photo = "Coinwallet1.jpg" },
                new Product { Id = 15, Name = "Urbano�s���]", Category = "Coinwallet", Photo = "Coinwallet2.jpg" },
                new Product { Id = 16, Name = "Bridle��ιs���]", Category = "Coinwallet", Photo = "Coinwallet3.jpg" },
                new Product { Id = 17, Name = "Tone Oilnume ��L���s���U", Category = "Coinwallet", Photo = "Coinwallet4.jpg" },
                new Product { Id = 18, Name = "Diario �������s���]", Category = "Coinwallet", Photo = "Coinwallet5.jpg" },
                new Product { Id = 19, Name = "Tone Oilnume ��L���g�A�s���]", Category = "Coinwallet", Photo = "Coinwallet6.jpg" },

                new Product { Id = 20, Name = "Bridle �W����", Category = "Namecard", Photo = "Namecard1.jpg" },
                new Product { Id = 21, Name = "Clarte �H�ʦW����", Category = "Namecard", Photo = "Namecard2.jpg" },
                new Product { Id = 22, Name = "Cordovan ���v�֦W����", Category = "Namecard", Photo = "Namecard3.jpg" },
                new Product { Id = 23, Name = "Cordovan ���v�ֲ��d�M", Category = "Namecard", Photo = "Namecard4.jpg" },
                new Product { Id = 24, Name = "Urbano �W����", Category = "Namecard", Photo = "Namecard5.jpg" },
                new Product { Id = 25, Name = "Urbano ����d����", Category = "Namecard", Photo = "Namecard6.jpg" }
               );


        }
    }
}
