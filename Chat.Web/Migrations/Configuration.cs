namespace Chat.Web.Migrations
{
    using Chat.Web.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Diagnostics;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Chat.Web.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Chat.Web.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            string[] roles = new string[] { "Admin" };
            foreach (string role in roles)
            {
                if (!context.Roles.Any(r => r.Name == role))
                {
                    context.Roles.Add(new IdentityRole(role));
                }
            }

            //create user UserName:Owner Role:Admin
            if (!context.Users.Any(u => u.UserName == "Admin"))
            {
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var user = new ApplicationUser
                {
                    UserName = "Admin",
                    DisplayName = "Admin",
                    Avatar = "data:image/png;base64,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",
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    PasswordHash = userManager.PasswordHasher.HashPassword("admin")
                };
                userManager.Create(user);
                userManager.AddToRole(user.Id, Roles.AdminRoleName);
            }

            context.SaveChanges();
        }
    }
}
