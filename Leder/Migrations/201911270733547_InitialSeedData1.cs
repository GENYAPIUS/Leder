namespace Leder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSeedData1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.PromoteProducts", newName: "PromoteProductViewModels");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.PromoteProductViewModels", newName: "PromoteProducts");
        }
    }
}
