namespace Leder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PurchaseSpellingCorrection : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Procurements", "PurchaseDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Procurements", "PuchuseDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Procurements", "PuchuseDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Procurements", "PurchaseDate");
        }
    }
}
