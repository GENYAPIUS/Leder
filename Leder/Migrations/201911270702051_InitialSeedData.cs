namespace Leder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSeedData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PromoteProducts",
                c => new
                    {
                        SectionId = c.String(nullable: false, maxLength: 128),
                        ProductName = c.String(),
                        PhotoUrl = c.String(),
                        DiscountWord = c.String(),
                        Statement = c.String(),
                    })
                .PrimaryKey(t => t.SectionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PromoteProducts");
        }
    }
}
