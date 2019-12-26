namespace Leder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeMoneyTypeToDecimal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrderDetails", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Procurements", "UnitPrize", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Procurements", "UnitPrize", c => c.Int(nullable: false));
            AlterColumn("dbo.OrderDetails", "Amount", c => c.Decimal(precision: 18, scale: 2));
        }
    }
}
