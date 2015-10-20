namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Roles", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Roles", "Name");
        }
    }
}
