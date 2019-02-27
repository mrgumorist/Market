namespace WindowsFormsApp15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductsHistory",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        dateTransaction = c.DateTime(nullable: false),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Product", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        PriceByOne = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Descriprion = c.String(),
                        WeightOrVolume = c.String(),
                        SpecialCode = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(),
                        TypeOfAccount = c.Int(nullable: false),
                        LastLogin = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductsHistory", "ProductID", "dbo.Product");
            DropForeignKey("dbo.Product", "ProductID", "dbo.Products");
            DropIndex("dbo.Product", new[] { "ProductID" });
            DropIndex("dbo.ProductsHistory", new[] { "ProductID" });
            DropTable("dbo.Users");
            DropTable("dbo.Products");
            DropTable("dbo.Product");
            DropTable("dbo.ProductsHistory");
        }
    }
}
