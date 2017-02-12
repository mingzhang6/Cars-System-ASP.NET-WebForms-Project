namespace CarsSystem.Data.Migrations
{
    using Common;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<CarsSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CarsSystemDbContext context)
        {
            this.SeedRoles(context);
        }

        private void SeedRoles(CarsSystemDbContext context)
        {
            if (!context.Roles.Any())
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);

                var adminRole = new IdentityRole { Name = ApplicationConstants.AdminRole };
                roleManager.Create(adminRole);

                var userRole = new IdentityRole { Name = ApplicationConstants.UserRole };
                roleManager.Create(userRole);

                context.SaveChanges();
            }
        }
    }
}
