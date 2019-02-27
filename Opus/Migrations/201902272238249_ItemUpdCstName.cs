namespace Opus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ItemUpdCstName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "CustomerName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "CustomerName");
        }
    }
}
