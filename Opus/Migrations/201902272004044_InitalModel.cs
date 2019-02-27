namespace Opus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitalModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NumberOfTransactions = c.Int(nullable: false),
                        FinancialStabilityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FinancialStabilities", t => t.FinancialStabilityId, cascadeDelete: true)
                .Index(t => t.FinancialStabilityId);
            
            CreateTable(
                "dbo.FinancialStabilities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StabilityType = c.String(),
                        PeakLoanValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CouldBeADebtor = c.Boolean(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Weight = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "FinancialStabilityId", "dbo.FinancialStabilities");
            DropIndex("dbo.Customers", new[] { "FinancialStabilityId" });
            DropTable("dbo.Items");
            DropTable("dbo.FinancialStabilities");
            DropTable("dbo.Customers");
        }
    }
}
