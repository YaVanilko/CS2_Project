namespace Data.Migrations
{
    using Domain.Entities;
    using System;
    using System.Collections.Generic;
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
            var permissions = new List<Permission>
            {
                new Permission{Name = "Список клиентов", Type = Domain.PermissionType.ListClient},
                new Permission{Name = "Добавление клиента", Type = Domain.PermissionType.NewClient},
                new Permission{Name = "Редактирование клиента", Type = Domain.PermissionType.EditClient},
                new Permission{Name = "Список заказов", Type = Domain.PermissionType.ListOrder},
                new Permission{Name = "Новый заказ", Type = Domain.PermissionType.NewOrder},
                new Permission{Name = "Редактирование заказа", Type = Domain.PermissionType.EditOrder},
                new Permission{Name = "Список товаров", Type = Domain.PermissionType.ListGoods},
                new Permission{Name = "Новый товар", Type = Domain.PermissionType.NewGoods},
                new Permission{Name = "Редактирование товара", Type = Domain.PermissionType.EditGoods},
                new Permission{Name = "Список пользователей", Type = Domain.PermissionType.ListUser},
                new Permission{Name = "Новый пользователь", Type = Domain.PermissionType.NewUser},
                new Permission{Name = "Редактирование пользователя", Type = Domain.PermissionType.EditUser}
            };
            
            var role = new Role { Name = "Administrator", Permissions = permissions };
            context.Roles.AddOrUpdate(x => x.Name, new Role[]{role});
            var info = new PersonalInfo { FirstName = "admin", LastName = "admin", MiddleName = "admin" };
            var admin = new User { Login = "admin", Password = "admin", Role = role, PersonalInfo = info };
            context.Users.AddOrUpdate(x => x.Login, new User[]{admin});

            context.SaveChanges();
        }
    }
}
