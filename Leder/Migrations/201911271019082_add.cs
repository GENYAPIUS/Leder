namespace Leder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Role", newName: "AspNetRoles");
            RenameTable(name: "dbo.UserRole", newName: "AspNetUserRoles");
            RenameTable(name: "dbo.User", newName: "AspNetUsers");
            RenameTable(name: "dbo.UserClame", newName: "AspNetUserClaims");
            RenameTable(name: "dbo.UserLogin", newName: "AspNetUserLogins");
            RenameColumn(table: "dbo.AspNetRoles", name: "RoleID", newName: "Id");
            RenameColumn(table: "dbo.AspNetUsers", name: "UserID", newName: "Id");
            RenameColumn(table: "dbo.AspNetUserClaims", name: "UserClameId", newName: "Id");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.AspNetUserClaims", name: "Id", newName: "UserClameId");
            RenameColumn(table: "dbo.AspNetUsers", name: "Id", newName: "UserID");
            RenameColumn(table: "dbo.AspNetRoles", name: "Id", newName: "RoleID");
            RenameTable(name: "dbo.AspNetUserLogins", newName: "UserLogin");
            RenameTable(name: "dbo.AspNetUserClaims", newName: "UserClame");
            RenameTable(name: "dbo.AspNetUsers", newName: "User");
            RenameTable(name: "dbo.AspNetUserRoles", newName: "UserRole");
            RenameTable(name: "dbo.AspNetRoles", newName: "Role");
        }
    }
}
