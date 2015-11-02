namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PersonalInfoes", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.PersonalInfoes", "EditTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PersonalInfoes", "EditTime");
            DropColumn("dbo.PersonalInfoes", "IsActive");
        }
    }
}
