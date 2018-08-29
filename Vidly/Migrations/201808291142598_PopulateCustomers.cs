namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers(Name, IsSubscribedToNewsletter, MembershipTypeId, BirthDate) VALUES ('John Smith', 0, 1, '1979-02-06')");
            Sql("INSERT INTO Customers(Name, IsSubscribedToNewsletter, MembershipTypeId, BirthDate) VALUES ('Mary Williams', 1, 2, NULL)");
        }
        
        public override void Down()
        {
        }
    }
}
