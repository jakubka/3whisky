    namespace _3whisky.db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductActive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Product_Id", c => c.Int());
            AddColumn("dbo.Products", "Active", c => c.Boolean(nullable: false));
            CreateIndex("dbo.Orders", "Product_Id");
            AddForeignKey("dbo.Orders", "Product_Id", "dbo.Products", "Id");
            DropColumn("dbo.Orders", "ProductId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "ProductId", c => c.String());
            DropForeignKey("dbo.Orders", "Product_Id", "dbo.Products");
            DropIndex("dbo.Orders", new[] { "Product_Id" });
            DropColumn("dbo.Products", "Active");
            DropColumn("dbo.Orders", "Product_Id");
        }
    }
}
