namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Hangover', 5, '2009-06-05', '2010-04-02', 5)");
            Sql("INSERT INTO Movies(Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Die Hard', 1, '1988-07-12', '2012-05-07', 3)");
            Sql("INSERT INTO Movies(Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Terminator', 1, '1984-10-26', '1999-02-19', 5)");
            Sql("INSERT INTO Movies(Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Toy Story', 3, '1995-11-22', '2014-10-03', 8)");
            Sql("INSERT INTO Movies(Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Titanic', 4, '1997-12-19', '1998-04-03', 3)");
        }
        
        public override void Down()
        {
        }
    }
}
