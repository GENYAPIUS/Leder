namespace Leder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditViewModel : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.PromoteProductViewModels");
            AddColumn("dbo.PromoteProductViewModels", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.PromoteProductViewModels", "Section", c => c.String());
            AddColumn("dbo.PromoteProductViewModels", "ProductName", c => c.String());
            AddColumn("dbo.PromoteProductViewModels", "PhotoUrl", c => c.String());
            AddColumn("dbo.PromoteProductViewModels", "DiscountWord", c => c.String());
            AddColumn("dbo.PromoteProductViewModels", "Statement", c => c.String());
            AddPrimaryKey("dbo.PromoteProductViewModels", "Id");
            DropColumn("dbo.PromoteProductViewModels", "SectionId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PromoteProductViewModels", "SectionId", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.PromoteProductViewModels");
            DropColumn("dbo.PromoteProductViewModels", "Statement");
            DropColumn("dbo.PromoteProductViewModels", "DiscountWord");
            DropColumn("dbo.PromoteProductViewModels", "PhotoUrl");
            DropColumn("dbo.PromoteProductViewModels", "ProductName");
            DropColumn("dbo.PromoteProductViewModels", "Section");
            DropColumn("dbo.PromoteProductViewModels", "Id");
            AddPrimaryKey("dbo.PromoteProductViewModels", "SectionId");
        }
    }
}
