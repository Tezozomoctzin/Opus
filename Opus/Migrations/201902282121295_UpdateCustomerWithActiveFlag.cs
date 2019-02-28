namespace Opus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerWithActiveFlag : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsActiveClient", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsActiveClient");
        }
    }
}
