namespace Opus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reworkFS : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.FinancialStabilities", "DateAdded");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FinancialStabilities", "DateAdded", c => c.DateTime(nullable: false));
        }
    }
}
