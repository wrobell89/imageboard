namespace ImageBoard.Migrations
{
    using ImageBoard.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Security;
    using WebMatrix.WebData;

    internal sealed class Configuration : DbMigrationsConfiguration<ImageBoard.Models.ImageBoardDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ImageBoard.Models.ImageBoardDb context)
        {
            #region Users

            WebSecurity.InitializeDatabaseConnection(
                "ImageBoardConn",
                "UserProfile",
                "Id",
                "UserName", autoCreateTables: true);

            if (!Roles.RoleExists("Administrator"))
                Roles.CreateRole("Administrator");

            if (!WebSecurity.UserExists("Admin"))
                WebSecurity.CreateUserAndAccount(
                    "Admin",
                    "Admin"
                    );

            if (!Roles.GetRolesForUser("Admin").Contains("Administrator"))
                Roles.AddUsersToRoles(new[] { "Admin" }, new[] { "Administrator" });

            if (!Roles.RoleExists("Member"))
                Roles.CreateRole("Member");

            if (!WebSecurity.UserExists("Stefan"))
                WebSecurity.CreateUserAndAccount(
                    "Stefan",
                    "Stefan"
                    );

            if (!Roles.GetRolesForUser("Stefan").Contains("Member"))
                Roles.AddUsersToRoles(new[] { "Stefan" }, new[] { "Member" });

            if (!WebSecurity.UserExists("Julia"))
                WebSecurity.CreateUserAndAccount(
                    "Julia",
                    "Julia"
                    );

            if (!Roles.GetRolesForUser("Julia").Contains("Member"))
                Roles.AddUsersToRoles(new[] { "Julia" }, new[] { "Member" });

            context.Users.AddOrUpdate(x => x.UserName,
                new UserProfile
                {
                    UserName = "Admin",
                    HomeUrl = "http://wrobell.deviantart.com/",
                    Description = "This is admin account. He's basicly a god here",
                    AvatarUrl = "http://puccinodesigns.com/wp-content/uploads/evil-eyesthe-evil-eye-by-xtoldnwv.png"
                },
                new UserProfile
                {
                    UserName = "Stefan",
                    HomeUrl = "http://stefan.deviantart.com/",
                    Description = "Hi I'm Stefan and I love dogs!",
                },
                new UserProfile
                {
                    UserName = "Julia",
                    Description = "Hi I'm Julia and I love cats!",
                }
            );

            #endregion
            
        }
    }
}
