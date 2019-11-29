namespace Leder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductsSectionData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductsSectionViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        Category = c.String(),
                        Photo = c.String(),
                        ProductPage = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProductsSectionViewModels");
        }
    }
}
