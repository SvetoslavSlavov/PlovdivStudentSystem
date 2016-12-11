namespace PlovdivUniversity.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Drawing;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PlovdivUniversity.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(PlovdivUniversity.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            if (!(context.Users.Any(u => u.UserName == "dj@dj.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "dj@dj.com", PhoneNumber = "0797697898" };
                userManager.Create(userToInsert, "Password@123");
            }
            if (!(context.Users.Any(u => u.Email == "student1@student.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "student1@student.com", PhoneNumber = "0797697898"  };
                userManager.Create(userToInsert, "Password@123");
            }
            if (!(context.Users.Any(u => u.Email == "student2@student.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "student2@student.com", PhoneNumber = "0797697898", Email="student2@student.com",};
                userManager.Create(userToInsert, "Password@123");
            }
            if (!(context.Users.Any(u => u.Email == "student3@student.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "student3@student.com", PhoneNumber = "0797697898",};
                userManager.Create(userToInsert, "Password@123");
            }
            if (!(context.Users.Any(u => u.Email == "student4@student.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "student4@student.com", PhoneNumber = "0797697898" };
                userManager.Create(userToInsert, "Password@123");
            }
            if (!(context.Users.Any(u => u.Email == "student5@student.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "student5@student.com", PhoneNumber = "0797697898" };
                userManager.Create(userToInsert, "Password@123");
            }
            if (!(context.Users.Any(u => u.Email == "student6@student.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "student6@student.com", PhoneNumber = "0797697898" };
                userManager.Create(userToInsert, "Password@123");
            }
            if (!(context.Users.Any(u => u.Email == "student7@student.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "student7@student.com", PhoneNumber = "0797697898" };
                userManager.Create(userToInsert, "Password@123");
            }
            if (!(context.Users.Any(u => u.Email == "student8@student.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "student8@student.com", PhoneNumber = "0797697898" };
                userManager.Create(userToInsert, "Password@123");
            }
            if (!(context.Users.Any(u => u.UserName == "student9@student.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "student9@student.com", PhoneNumber = "0797697898" };
                userManager.Create(userToInsert, "Password@123");
            }
        }
    }
}
