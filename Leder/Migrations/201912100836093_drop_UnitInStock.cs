namespace Leder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class drop_UnitInStock : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "UnitInStock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "UnitInStock", c => c.Int(nullable: false));
        }
    }
}
