namespace Opus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FillFS2 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT FinancialStabilities ON");
            Sql("INSERT INTO FinancialStabilities (Id, StabilityType, PeakLoanValue, CouldBeADebtor) VALUES (1, 'Strong', 3000, 1)");
            Sql("INSERT INTO FinancialStabilities (Id, StabilityType, PeakLoanValue, CouldBeADebtor) VALUES (2, 'Confident', 2500, 1)");
            Sql("INSERT INTO FinancialStabilities (Id, StabilityType, PeakLoanValue, CouldBeADebtor) VALUES (3, 'Stable', 2000, 1)");
            Sql("INSERT INTO FinancialStabilities (Id, StabilityType, PeakLoanValue, CouldBeADebtor) VALUES (4, 'Reliable', 1300, 1)");
            Sql("INSERT INTO FinancialStabilities (Id, StabilityType, PeakLoanValue, CouldBeADebtor) VALUES (5, 'Questionable', 800, 0)");
            Sql("INSERT INTO FinancialStabilities (Id, StabilityType, PeakLoanValue, CouldBeADebtor) VALUES (6, 'Weak', 300, 0)");
            Sql("INSERT INTO FinancialStabilities (Id, StabilityType, PeakLoanValue, CouldBeADebtor) VALUES (7, 'Nonexistent', 0, 0)");
        }
        
        public override void Down()
        {
        }
    }
}
