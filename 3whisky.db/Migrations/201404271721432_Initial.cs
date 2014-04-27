namespace _3whisky.db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Name = c.String(),
                        DeliveryAddress = c.String(),
                        Note = c.String(),
                        PaymentMethod = c.String(),
                        ShipmentMethod = c.String(),
                        ProductId = c.String(),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Created = c.DateTime(nullable: false),
                        Enabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
        }
    }
}
