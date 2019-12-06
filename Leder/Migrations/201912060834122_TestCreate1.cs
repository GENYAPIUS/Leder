namespace Leder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "UnitInStock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "UnitInStock");
        }
    }
}
