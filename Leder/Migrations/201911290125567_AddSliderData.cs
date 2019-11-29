namespace Leder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSliderData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SliderPartialViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ADTopic = c.String(),
                        ADUrl = c.String(),
                        ADStatement = c.String(),
                        ADDiscount = c.String(),
                        ADPageLink = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SliderPartialViewModels");
        }
    }
}
