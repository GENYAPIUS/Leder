namespace Leder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class identityModified : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AspNetRoles", newName: "Role");
            RenameTable(name: "dbo.AspNetUserRoles", newName: "UserRole");
            RenameTable(name: "dbo.AspNetUsers", newName: "User");
            RenameTable(name: "dbo.AspNetUserClaims", newName: "UserClame");
            RenameTable(name: "dbo.AspNetUserLogins", newName: "UserLogin");
            RenameColumn(table: "dbo.Role", name: "Id", newName: "RoleID");
            RenameColumn(table: "dbo.User", name: "Id", newName: "UserID");
            RenameColumn(table: "dbo.UserClame", name: "Id", newName: "UserClameId");
            CreateTable(
                "dbo.UserDetails",
                c => new
                    {
                        UserDetailID = c.Int(nullable: false, identity: true),
                        CellPhone = c.String(),
                        Address = c.String(nullable: false),
                        ShipAddress = c.String(nullable: false),
                        BirthDay = c.DateTime(nullable: false),
                        IdentityCard = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserDetailID);
            
            AddColumn("dbo.User", "UserDetailId", c => c.Int());
            CreateIndex("dbo.User", "UserDetailId");
            AddForeignKey("dbo.User", "UserDetailId", "dbo.UserDetails", "UserDetailID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "UserDetailId", "dbo.UserDetails");
            DropIndex("dbo.User", new[] { "UserDetailId" });
            DropColumn("dbo.User", "UserDetailId");
            DropTable("dbo.UserDetails");
            RenameColumn(table: "dbo.UserClame", name: "UserClameId", newName: "Id");
            RenameColumn(table: "dbo.User", name: "UserID", newName: "Id");
            RenameColumn(table: "dbo.Role", name: "RoleID", newName: "Id");
            RenameTable(name: "dbo.UserLogin", newName: "AspNetUserLogins");
            RenameTable(name: "dbo.UserClame", newName: "AspNetUserClaims");
            RenameTable(name: "dbo.User", newName: "AspNetUsers");
            RenameTable(name: "dbo.UserRole", newName: "AspNetUserRoles");
            RenameTable(name: "dbo.Role", newName: "AspNetRoles");
        }
    }
}
