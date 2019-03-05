namespace WindowsFormsApp15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductsHistory", "Type", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductsHistory", "Type", c => c.String());
        }
    }
}
