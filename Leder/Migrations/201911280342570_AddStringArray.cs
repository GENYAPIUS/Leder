namespace Leder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStringArray : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PromoteProductViewModels", "ProductName");
            DropColumn("dbo.PromoteProductViewModels", "PhotoUrl");
            DropColumn("dbo.PromoteProductViewModels", "DiscountWord");
            DropColumn("dbo.PromoteProductViewModels", "Statement");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PromoteProductViewModels", "Statement", c => c.String());
            AddColumn("dbo.PromoteProductViewModels", "DiscountWord", c => c.String());
            AddColumn("dbo.PromoteProductViewModels", "PhotoUrl", c => c.String());
            AddColumn("dbo.PromoteProductViewModels", "ProductName", c => c.String());
        }
    }
}
