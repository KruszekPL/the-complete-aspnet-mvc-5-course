namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixMembershipTypesDurationinMonthsValues : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET DurationInMonths=0 WHERE Id=1");
            Sql("UPDATE MembershipTypes SET DurationInMonths=1 WHERE Id=2");
            Sql("UPDATE MembershipTypes SET DurationInMonths=3 WHERE Id=3");
            Sql("UPDATE MembershipTypes SET DurationInMonths=12 WHERE Id=4");
        }

        public override void Down()
        {
        }
    }
}
