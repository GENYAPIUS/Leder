namespace Leder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addColor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Color", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Color");
        }
    }
}
