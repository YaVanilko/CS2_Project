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
                new Permission{Name = "Ñïèñîê êëèåíòîâ", Type = Domain.PermissionType.ListClient},
                new Permission{Name = "Äîáàâëåíèå êëèåíòà", Type = Domain.PermissionType.NewClient},
                new Permission{Name = "Ðåäàêòèðîâàíèå êëèåíòà", Type = Domain.PermissionType.EditClient},
                new Permission{Name = "Ñïèñîê çàêàçîâ", Type = Domain.PermissionType.ListOrder},
                new Permission{Name = "Íîâûé çàêàç", Type = Domain.PermissionType.NewOrder},
                new Permission{Name = "Ðåäàêòèðîâàíèå çàêàçà", Type = Domain.PermissionType.EditOrder},
                new Permission{Name = "Ñïèñîê òîâàðîâ", Type = Domain.PermissionType.ListGoods},
                new Permission{Name = "Íîâûé òîâàð", Type = Domain.PermissionType.NewGoods},
                new Permission{Name = "Ðåäàêòèðîâàíèå òîâàðà", Type = Domain.PermissionType.EditGoods},
                new Permission{Name = "Ñïèñîê ïîëüçîâàòåëåé", Type = Domain.PermissionType.ListUser},
                new Permission{Name = "Íîâûé ïîëüçîâàòåëü", Type = Domain.PermissionType.NewUser},
                new Permission{Name = "Ðåäàêòèðîâàíèå ïîëüçîâàòåëÿ", Type = Domain.PermissionType.EditUser},
                new Permission{Name = "Ñîõðàíèòü ñïèñîê êëèåíòîâ", Type = Domain.PermissionType.SaveListClients},
                new Permission{Name = "Ñîõðàíèòü ñïèñîê çàêàçîâ", Type = Domain.PermissionType.SaveListOrders},
                new Permission{Name = "Ñîõðàíèòü ñïèñîê òîâàðîâ", Type = Domain.PermissionType.SaveListGoods},
                new Permission{Name = "Ñîõðàíèòü ñïèñîê ïîëüçîâàòåëåé", Type = Domain.PermissionType.SaveListUsers},
                new Permission{Name = "Ïå÷àòàòü îò÷åò ïî êëèåíòàì", Type = Domain.PermissionType.PrintReportClients},
                new Permission{Name = "Ïå÷àòàòü îò÷åò ïî çàêàçàì", Type = Domain.PermissionType.PrintReportOrders},
                new Permission{Name = "Ïå÷àòàòü îò÷åò ïî òîâàðàì", Type = Domain.PermissionType.PrintReportGoods},
                new Permission{Name = "Ïå÷àòàòü îò÷åò ïî ïîëüçîâàòåëÿì", Type = Domain.PermissionType.PrintReportUsers},

                new Permission{Name = "Ñïèñîê ðîëåé", Type = Domain.PermissionType.ListRoles},
                new Permission{Name = "Äîáàâëåíèå ðîëè", Type = Domain.PermissionType.NewRole},
                new Permission{Name = "Ðåäàêòèðîâàíèå ðîëè", Type = Domain.PermissionType.EditRole},
                new Permission{Name = "Ðåäàêòèðîâàíèå êàòåãîðèè òîâàðîâ", Type = Domain.PermissionType.EditProductCategory}
            };

            var role = new Role { Name = "Administrator", Permissions = permissions };
            context.Roles.AddOrUpdate(x => x.Name, new Role[] { role });
            var info = new PersonalInfo { FirstName = "admin", LastName = "admin", MiddleName = "admin" };
            context.PersonalInfoes.AddOrUpdate(info);
            var admin = new User { Login = "admin", Password = "21232f297a57a5a743894a0e4a801fc3", Role = role, PersonalInfo = info };
            context.Users.AddOrUpdate(x => x.Login, new User[] { admin });

            var statuses = new List<OrderStatus>()
            {
                new OrderStatus() { Status = "Открыт"},
                new OrderStatus() { Status = "Оплачен"},
                new OrderStatus() { Status = "Готов"},
                new OrderStatus() { Status = "Отгружен"},
                new OrderStatus() { Status = "Закрыт"},
            };

            context.OrderStatus.AddRange(statuses);

            context.SaveChanges();

        }
    }
}
