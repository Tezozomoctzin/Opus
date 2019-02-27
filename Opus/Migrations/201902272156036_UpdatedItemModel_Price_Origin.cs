namespace Opus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedItemModel_Price_Origin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Items", "OriginalCustomer_Id", c => c.Int());
            CreateIndex("dbo.Items", "OriginalCustomer_Id");
            AddForeignKey("dbo.Items", "OriginalCustomer_Id", "dbo.Customers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "OriginalCustomer_Id", "dbo.Customers");
            DropIndex("dbo.Items", new[] { "OriginalCustomer_Id" });
            DropColumn("dbo.Items", "OriginalCustomer_Id");
            DropColumn("dbo.Items", "Price");
        }
    }
}
