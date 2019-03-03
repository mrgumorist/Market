namespace WindowsFormsApp15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "LastPrice", c => c.Double(nullable: false));
            AlterColumn("dbo.Product", "PriceByOne", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Product", "PriceByOne", c => c.Int(nullable: false));
            DropColumn("dbo.Product", "LastPrice");
        }
    }
}
