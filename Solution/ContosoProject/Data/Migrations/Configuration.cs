namespace Data.Migrations
{
    using Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.EFData.ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Data.EFData.ProjectContext context)
        {
            var role = new Role() { Name = "Administrator" };
            var person = new PersonalInfo { FirstName = "John", LastName = "Doe", MiddleName = "Anonim" };
            var user = new User { Login = "admin", Password = "123", PersonalInfo = person, Role = role };

            context.Users.AddOrUpdate(user);
            context.SaveChanges();
        }
    }
}
