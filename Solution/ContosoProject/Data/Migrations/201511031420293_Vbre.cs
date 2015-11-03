namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Vbre : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.GoodsRows", "Price");
            DropColumn("dbo.GoodsRows", "TotalPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GoodsRows", "TotalPrice", c => c.Double(nullable: false));
            AddColumn("dbo.GoodsRows", "Price", c => c.Double(nullable: false));
        }
    }
}
