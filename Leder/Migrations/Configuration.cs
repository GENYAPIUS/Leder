namespace Leder.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Leder.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Leder.Models.ShoppingCartContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Leder.Models.ShoppingCartContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Users.AddOrUpdate(
                x=>x.UserId,
                new User { UserId=1,Name="���Ѹ}�񨮺ƨg�S���M"},
                new User { UserId=2,Name="�÷ٮ�a����"},
                new User { UserId=3,Name="�g�ɤp��"}
                );
            context.Products.AddOrUpdate(
                x=>x.Id,
                new Product { Id = 1, Name = "Belchord�s���]", Category = "CoinWallet",Price=20,Photo= "Belchord�s���].jpg" },
                new Product { Id = 2, Name = "Bridle��ιs���]", Category = "CoinWallet",Price=25,Photo = "Bridle��ιs���].jpg" },
                new Product { Id = 3, Name = "Diario �������s���]", Category = "CoinWallet",Price=40, Photo = "Diario �������s���].jpg" },
                new Product { Id = 4, Name = "Tone Oilnume ��L���g�A�s���]", Category = "CoinWallet",Price=50, Photo = "Tone Oilnume ��L���g�A�s���].jpg" },
                new Product { Id = 5, Name = "Tone Oilnume ��I�]", Category = "Backpack",Price=500, Photo = "Tone Oilnume ��I�].jpg" },
                new Product { Id = 6, Name = "Clarte �H�ʦW����", Category = "Namecard",Price=30, Photo = "Clarte �H�ʦW����.jpg" }
                );
            context.Order_Details.AddOrUpdate(
                x => x.Order_DetailsId,
                new Order_Details { Order_DetailsId = 1, OrderId = 1, ProductId = 1, Quantity = 2 },
                new Order_Details { Order_DetailsId = 2, OrderId = 1, ProductId = 3, Quantity = 5 },
                new Order_Details { Order_DetailsId = 3, OrderId = 1, ProductId = 4, Quantity = 2 },
                new Order_Details { Order_DetailsId = 4, OrderId = 1, ProductId = 5, Quantity = 3 },
                new Order_Details { Order_DetailsId = 5, OrderId = 2, ProductId = 1, Quantity = 4 },
                new Order_Details { Order_DetailsId = 6, OrderId = 2, ProductId = 2, Quantity = 5 },
                new Order_Details { Order_DetailsId = 7, OrderId = 2, ProductId = 6, Quantity = 6 },
                new Order_Details { Order_DetailsId = 8, OrderId = 3, ProductId = 2, Quantity = 1 },
                new Order_Details { Order_DetailsId = 9, OrderId = 3, ProductId = 3, Quantity = 3 },
                new Order_Details { Order_DetailsId = 10, OrderId = 3, ProductId = 5, Quantity = 2 }
                );
        }
    }
}
