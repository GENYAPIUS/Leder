namespace Leder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductViewMode : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "MorePhotos");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "MorePhotos", c => c.String());
        }
    }
}
