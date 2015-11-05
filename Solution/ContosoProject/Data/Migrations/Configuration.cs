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
            AutomaticMigrationsEnabled = true;
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
                new Permission{Name = "Редактирование пользователя", Type = Domain.PermissionType.EditUser},
                new Permission{Name = "Сохранить список клиентов", Type = Domain.PermissionType.SaveListClients},
                new Permission{Name = "Сохранить список заказов", Type = Domain.PermissionType.SaveListOrders},
                new Permission{Name = "Сохранить список товаров", Type = Domain.PermissionType.SaveListGoods},
                new Permission{Name = "Сохранить список пользователей", Type = Domain.PermissionType.SaveListUsers},
                new Permission{Name = "Печатать отчет по клиентам", Type = Domain.PermissionType.PrintReportClients},
                new Permission{Name = "Печатать отчет по заказам", Type = Domain.PermissionType.PrintReportOrders},
                new Permission{Name = "Печатать отчет по товарам", Type = Domain.PermissionType.PrintReportGoods},
                new Permission{Name = "Печатать отчет по пользователям", Type = Domain.PermissionType.PrintReportUsers},

                new Permission{Name = "Список ролей", Type = Domain.PermissionType.ListRoles},
                new Permission{Name = "Добавление роли", Type = Domain.PermissionType.NewRole},
                new Permission{Name = "Редактирование роли", Type = Domain.PermissionType.EditRole},
                new Permission{Name = "Редактирование категории товаров", Type = Domain.PermissionType.EditProductCategory}
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

            if (context.OrderStatus.Count() == 0)
            {
                context.OrderStatus.AddRange(statuses);
            }

            // Dummy data
            var cars = new List<ProductCategory>
            {
                new ProductCategory{CategoryName="cat1"},
                new ProductCategory{CategoryName="cat2"},
                new ProductCategory{CategoryName="cat3"},
                new ProductCategory{CategoryName="cat4"}
            };
            var prods = new List<Goods>
            {
                new Goods{Name="Goods1",Price=10,SKU="SKU1",Count=3,Category=cars[0]},
                new Goods{Name="Goods2",Price=10,SKU="SKU2",Count=5,Category=cars[1]},
                new Goods{Name="Goods3",Price=10,SKU="SKU3",Count=2,Category=cars[0]},
                new Goods{Name="Goods4",Price=10,SKU="SKU4",Count=6,Category=cars[2]},
                new Goods{Name="Goods5",Price=10,SKU="SKU5",Count=8,Category=cars[0]}
            };

            var cust = new List<Customer>
            {
                new Customer
                {
                    Contacts = new ContactInfo{Adress="addres",City="city",},
                    PersonalInfo = new PersonalInfo{FirstName="Ivan",LastName="Ivanov"},
                },
                new Customer
                {
                    Contacts = new ContactInfo{Adress="addres",City="city",},
                    PersonalInfo = new PersonalInfo{FirstName="Petr",LastName="Petrov"},
                },
                new Customer
                {
                    Contacts = new ContactInfo{Adress="addres",City="city",},
                    PersonalInfo = new PersonalInfo{FirstName="Sidor",LastName="Sidorov"},
                }
            };

            var orders = new List<Order>
            {
                new Order
                {
                    Status = statuses[0], 
                    Customer = cust[0], 
                    GoodsList = 
                    {
                        new GoodsRow{Goods = prods[0],Price=10,Count=1},
                        new GoodsRow{Goods = prods[1],Price=20,Count=2},
                        new GoodsRow{Goods = prods[2],Price=30,Count=3}
                    },
                },
                new Order
                {
                    Status = statuses[1], 
                    Customer = cust[1], 
                    GoodsList = 
                    {
                        new GoodsRow{Goods = prods[2],Price=10,Count=1},
                        new GoodsRow{Goods = prods[3],Price=20,Count=2},
                        new GoodsRow{Goods = prods[4],Price=30,Count=3}
                    },
                },
            };

            if (context.Categories.Count() == 0)
            {
                context.Categories.AddRange(cars);
            }

            if (context.Products.Count() == 0)
            {
                context.Products.AddRange(prods);
            }
            if (context.Customers.Count()==0)
            {
                context.Customers.AddRange(cust);
            }
            if (context.Orders.Count()==0)
            {
                context.Orders.AddRange(orders);
            }

            context.SaveChanges();

        }
    }
}
