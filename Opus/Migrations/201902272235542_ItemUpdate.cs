namespace Opus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ItemUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Items", "OriginalCustomer_Id", "dbo.Customers");
            DropIndex("dbo.Items", new[] { "OriginalCustomer_Id" });
            RenameColumn(table: "dbo.Items", name: "OriginalCustomer_Id", newName: "CustomerId");
            AlterColumn("dbo.Items", "CustomerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Items", "CustomerId");
            AddForeignKey("dbo.Items", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Items", new[] { "CustomerId" });
            AlterColumn("dbo.Items", "CustomerId", c => c.Int());
            RenameColumn(table: "dbo.Items", name: "CustomerId", newName: "OriginalCustomer_Id");
            CreateIndex("dbo.Items", "OriginalCustomer_Id");
            AddForeignKey("dbo.Items", "OriginalCustomer_Id", "dbo.Customers", "Id");
        }
    }
}
