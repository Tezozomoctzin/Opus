namespace Opus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FillingItemsTable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Items ON");
            Sql("INSERT INTO Items(Id, Name, Weight, Price, OriginalCustomer_Id) VALUES (1, 'Kettle', 0.6, 70, 1)");
            Sql("INSERT INTO Items(Id, Name, Weight, Price, OriginalCustomer_Id) VALUES (2, 'TV', 8, 400, 2)");
            Sql("INSERT INTO Items(Id, Name, Weight, Price, OriginalCustomer_Id) VALUES (3, 'Bookshelf', 23, 120, 3)");
            Sql("INSERT INTO Items(Id, Name, Weight, Price, OriginalCustomer_Id) VALUES (4, 'Ring(gold)', 0.03 , 800, 1)");
            Sql("INSERT INTO Items(Id, Name, Weight, Price, OriginalCustomer_Id) VALUES (5, 'Ring(silver)', 0.015, 230, 1)");
            Sql("INSERT INTO Items(Id, Name, Weight, Price, OriginalCustomer_Id) VALUES (6, 'PS4 Controller', 0.3, 100, 2)");
            Sql("INSERT INTO Items(Id, Name, Weight, Price, OriginalCustomer_Id) VALUES (7, 'Nested Doll', 0.2, 90, 3)");
            Sql("INSERT INTO Items(Id, Name, Weight, Price, OriginalCustomer_Id) VALUES (8, 'Binoculars', 0.25, 500, 3)");
            Sql("INSERT INTO Items(Id, Name, Weight, Price, OriginalCustomer_Id) VALUES (9, 'Drone', 2.2, 880, 1)");
            Sql("INSERT INTO Items(Id, Name, Weight, Price, OriginalCustomer_Id) VALUES (10, 'Vase(ceramic)', 1.2, 55, 3)");
            Sql("INSERT INTO Items(Id, Name, Weight, Price, OriginalCustomer_Id) VALUES (11, 'Necklace(gold)', 0.1, 450, 3)");
            Sql("INSERT INTO Items(Id, Name, Weight, Price, OriginalCustomer_Id) VALUES (12, 'Boots', 0.8, 120, 2)");
            Sql("INSERT INTO Items(Id, Name, Weight, Price, OriginalCustomer_Id) VALUES (13, 'Suit(3 piece)', 2.4, 240, 2)");
            Sql("INSERT INTO Items(Id, Name, Weight, Price, OriginalCustomer_Id) VALUES (14, 'TV Remote', 0.2, 35, 3)");
            Sql("INSERT INTO Items(Id, Name, Weight, Price, OriginalCustomer_Id) VALUES (15, 'Glasses(-3.5d)', 0.1, 90, 2)");
            Sql("INSERT INTO Items(Id, Name, Weight, Price, OriginalCustomer_Id) VALUES (16, 'Bar(gold)', 8.5, 21000, 1)");
        }
        
        public override void Down()
        {
        }
    }
}
