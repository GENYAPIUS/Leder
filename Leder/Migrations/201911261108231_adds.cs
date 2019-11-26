namespace Leder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adds : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserDetails", "CellPhone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserDetails", "CellPhone", c => c.String());
        }
    }
}
