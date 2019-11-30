namespace Leder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPrice : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Price", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Price", c => c.String());
        }
    }
}
