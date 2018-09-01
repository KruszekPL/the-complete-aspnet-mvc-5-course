namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'3bb1cfcc-0502-4899-aad7-903f00d7dd21', N'guest@kruszynscy.pl', 0, N'ANYwLXYnc9yjiHC0bz7vWut1DMbriUTGmSVyDFgrwM4KLzaAt87X6EMEaZrTeG8n1w==', N'57f432e2-a1f7-457d-97ff-669c3133eba3', NULL, 0, 0, NULL, 1, 0, N'guest@kruszynscy.pl')
            INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'3e2a9ea3-48ab-4eaf-b7fe-a5c3e0fa7b63', N'admin@kruszynscy.pl', 0, N'ACI2HlOH0mUlD4rGrfNo/gIa6nUKaHlyv6PkwSeQQgEKcJVAqFmNugjVijEMg1Y3dg==', N'feb1f397-d3ec-490b-80da-38f2c860fdf3', NULL, 0, 0, NULL, 1, 0, N'admin@kruszynscy.pl')
            
            INSERT INTO[dbo].[AspNetRoles] ([Id], [Name]) VALUES(N'c7838b3c-e03f-4247-b32b-6e13f8d8892d', N'CanManageMovies')
            
            INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'3e2a9ea3-48ab-4eaf-b7fe-a5c3e0fa7b63', N'c7838b3c-e03f-4247-b32b-6e13f8d8892d')"
            );
        }

    public override void Down()
        {
        }
    }
}
