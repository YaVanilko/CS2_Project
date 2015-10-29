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
                new Permission{Name = "������ ��������", Type = Domain.PermissionType.ListClient},
                new Permission{Name = "���������� �������", Type = Domain.PermissionType.NewClient},
                new Permission{Name = "�������������� �������", Type = Domain.PermissionType.EditClient},
                new Permission{Name = "������ �������", Type = Domain.PermissionType.ListOrder},
                new Permission{Name = "����� �����", Type = Domain.PermissionType.NewOrder},
                new Permission{Name = "�������������� ������", Type = Domain.PermissionType.EditOrder},
                new Permission{Name = "������ �������", Type = Domain.PermissionType.ListGoods},
                new Permission{Name = "����� �����", Type = Domain.PermissionType.NewGoods},
                new Permission{Name = "�������������� ������", Type = Domain.PermissionType.EditGoods},
                new Permission{Name = "������ �������������", Type = Domain.PermissionType.ListUser},
                new Permission{Name = "����� ������������", Type = Domain.PermissionType.NewUser},
                new Permission{Name = "�������������� ������������", Type = Domain.PermissionType.EditUser},
                new Permission{Name = "��������� ������ ��������", Type = Domain.PermissionType.SaveListClients},
                new Permission{Name = "��������� ������ �������", Type = Domain.PermissionType.SaveListOrders},
                new Permission{Name = "��������� ������ �������", Type = Domain.PermissionType.SaveListGoods},
                new Permission{Name = "��������� ������ �������������", Type = Domain.PermissionType.SaveListUsers},
                new Permission{Name = "�������� ����� �� ��������", Type = Domain.PermissionType.PrintReportClients},
                new Permission{Name = "�������� ����� �� �������", Type = Domain.PermissionType.PrintReportOrders},
                new Permission{Name = "�������� ����� �� �������", Type = Domain.PermissionType.PrintReportGoods},
                new Permission{Name = "�������� ����� �� �������������", Type = Domain.PermissionType.PrintReportUsers},

                new Permission{Name = "������ �����", Type = Domain.PermissionType.ListRoles},
                new Permission{Name = "���������� ����", Type = Domain.PermissionType.NewRole},
                new Permission{Name = "�������������� ����", Type = Domain.PermissionType.EditRole}
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
