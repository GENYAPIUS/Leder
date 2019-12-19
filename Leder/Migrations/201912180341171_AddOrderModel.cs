namespace Leder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderDetailId = c.Int(nullable: false, identity: true),
                        OrderId = c.Guid(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Price = c.Decimal(precision: 18, scale: 2),
                        Quantity = c.Int(),
                        Amount = c.Decimal(precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderDetailId)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Guid(nullable: false),
                        Email = c.String(),
                        RecieverName = c.String(nullable: false, maxLength: 30),
                        RecieverPhone = c.String(nullable: false, maxLength: 15),
                        RecieverAddress = c.String(nullable: false, maxLength: 256),
                        OrderDate = c.DateTime(nullable: false),
                        RecieverZipCode = c.String(nullable: false, maxLength: 5),
                        TotalAmount = c.Decimal(precision: 18, scale: 2),
                        PayStatus = c.String(),
                        OrderStatus = c.String(),
                    })
                .PrimaryKey(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders");
            DropIndex("dbo.OrderDetails", new[] { "ProductId" });
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
        }
    }
}
