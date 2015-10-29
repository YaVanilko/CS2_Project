namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RolePerson : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PermissionRoles", "Permission_Id", "dbo.Permissions");
            DropForeignKey("dbo.PermissionRoles", "Role_Id", "dbo.Roles");
            DropIndex("dbo.PermissionRoles", new[] { "Permission_Id" });
            DropIndex("dbo.PermissionRoles", new[] { "Role_Id" });
            AddColumn("dbo.Permissions", "Role_Id", c => c.Int());
            CreateIndex("dbo.Permissions", "Role_Id");
            AddForeignKey("dbo.Permissions", "Role_Id", "dbo.Roles", "Id");
            DropTable("dbo.PermissionRoles");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PermissionRoles",
                c => new
                    {
                        Permission_Id = c.Int(nullable: false),
                        Role_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Permission_Id, t.Role_Id });
            
            DropForeignKey("dbo.Permissions", "Role_Id", "dbo.Roles");
            DropIndex("dbo.Permissions", new[] { "Role_Id" });
            DropColumn("dbo.Permissions", "Role_Id");
            CreateIndex("dbo.PermissionRoles", "Role_Id");
            CreateIndex("dbo.PermissionRoles", "Permission_Id");
            AddForeignKey("dbo.PermissionRoles", "Role_Id", "dbo.Roles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PermissionRoles", "Permission_Id", "dbo.Permissions", "Id", cascadeDelete: true);
        }
    }
}
