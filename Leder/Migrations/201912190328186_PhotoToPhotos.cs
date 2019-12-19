namespace Leder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhotoToPhotos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Photos", c => c.String());
            DropColumn("dbo.Products", "Photo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Photo", c => c.String());
            DropColumn("dbo.Products", "Photos");
        }
    }
}
