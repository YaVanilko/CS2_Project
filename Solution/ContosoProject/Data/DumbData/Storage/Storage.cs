using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Data.DumbData
{
    public class Storage
    {
        #region Role
        public static List<Role> RoleCollection = new List<Role>()
        {
            new Role{Id=0, Name = "Администратор"},
            new Role{Id=1, Name = "Шеф"},
            new Role{Id=2, Name = "Менеджер"},
            new Role{Id=3, Name = "Друг Админа"},
            new Role{Id=4, Name = "Друг Шефа"},
            new Role{Id=5, Name = "Администратор"},
            new Role{Id=6, Name = "Менеджер"},
            new Role{Id=7, Name = "Менеджер"},
            new Role{Id=8, Name = "Менеджер"},
            new Role{Id=9, Name = "Менеджер"}
        };
        #endregion

        #region PersonalInfo
        public static List<PersonalInfo> PersonalInfoCollection = new List<PersonalInfo>()
        {
            new PersonalInfo()
            {
                Id = 0,
                FirstName = "Татьяна",
                MiddleName = "Витальевна",
                LastName = "Петрова"
            },
            new PersonalInfo()
            {
                Id = 1,
                FirstName = "Олег",
                MiddleName = "Евгеньевич",
                LastName = "Таромский"
            },
            new PersonalInfo()
            {
                Id = 2,
                FirstName = "Григорий",
                MiddleName = "Вениаминович",
                LastName = "Крашенберг"
            },
            new PersonalInfo()
            {
                Id = 3,
                FirstName = "Зиновия",
                MiddleName = "Сидоровна",
                LastName = "Белугина"
            },
            new PersonalInfo()
            {
                Id = 4,
                FirstName = "Раиса",
                MiddleName = "Васильевна",
                LastName = "Райская"
            },
            new PersonalInfo()
            {
                Id = 5,
                FirstName = "Матвей",
                MiddleName = "Иванович",
                LastName = "Костромской"
            },
            new PersonalInfo()
            {
                Id = 6,
                FirstName = "Антон",
                MiddleName = "Денисович",
                LastName = "Бесстужев"
            },
            new PersonalInfo()
            {
                Id = 7,
                FirstName = "Иполит",
                MiddleName = "Петрович",
                LastName = "Легкопаров"
            },
            new PersonalInfo()
            {
                Id = 8,
                FirstName = "Маргарита",
                MiddleName = "Альбертовна",
                LastName = "Королева"
            },
            new PersonalInfo()
            {
                Id = 9,
                FirstName = "Наталья",
                MiddleName = "Александровна",
                LastName = "Ростова"
            }
        };
        #endregion
        static string GetMd5Hash(string input)
        {
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        #region User
        public static List<User> UserCollection = new List<User>() 
        {
            new User {Id=0, Login="admin",Password=GetMd5Hash("123"),PersonalInfo = PersonalInfoCollection[0], Role = RoleCollection[0], /*IsActive = false*/},
            new User {Id=1, Login="manager",Password="admin",PersonalInfo = PersonalInfoCollection[1], Role = RoleCollection[1]},
            new User {Id=2, Login="boss",Password=GetMd5Hash("123"),PersonalInfo = PersonalInfoCollection[2], Role = RoleCollection[2]},
            new User {Id=3, Login="user3",Password=GetMd5Hash("123"),PersonalInfo = PersonalInfoCollection[3], Role = RoleCollection[3]},
            new User {Id=4, Login="user4",Password=GetMd5Hash("123"),PersonalInfo = PersonalInfoCollection[4], Role = RoleCollection[4]},
            new User {Id=5, Login="user5",Password=GetMd5Hash("123"),PersonalInfo = PersonalInfoCollection[5], Role = RoleCollection[5]},
            new User {Id=6, Login="user6",Password=GetMd5Hash("123"),PersonalInfo = PersonalInfoCollection[6], Role = RoleCollection[6]},
            new User {Id=7, Login="user7",Password=GetMd5Hash("123"),PersonalInfo = PersonalInfoCollection[7], Role = RoleCollection[7]},
            new User {Id=8, Login="user8",Password=GetMd5Hash("123"),PersonalInfo = PersonalInfoCollection[8], Role = RoleCollection[8]},
            new User {Id=9, Login="user9",Password=GetMd5Hash("123"),PersonalInfo = PersonalInfoCollection[9], Role = RoleCollection[9]},

        };
        #endregion

        #region ProductCategory
        public static List<ProductCategory> categoryCollection = new List<ProductCategory>()
        {
            new ProductCategory()
            {
                CategoryName = "Стулья",
            },
                        new ProductCategory()
            {
                CategoryName = "Столы",
            },
                        new ProductCategory()
            {
                CategoryName = "Шкафы",
            },
                        new ProductCategory()
            {
                CategoryName = "Диваны",
            },
                        new ProductCategory()
            {
                CategoryName = "Кровати",
            },
                        new ProductCategory()
            {
                CategoryName = "Полки",
            },
                        new ProductCategory()
            {
                CategoryName = "Кухонная мебель",
            },
                        new ProductCategory()
            {
                CategoryName = "Фурнитура",
            },
                        new ProductCategory()
            {
                CategoryName = "Комоды",
            },
                        new ProductCategory()
            {
                CategoryName = "Тумбы",
            }
        };
        #endregion

        #region OrderStatus
        public static List<OrderStatus> OrderStatusCollection = new List<OrderStatus>()
        { 
            new OrderStatus(){Id = 0, Status = "Открыт"},
            new OrderStatus(){Id = 1, Status = "Оплачен"},
            new OrderStatus(){Id = 2, Status = "Готов"},
            new OrderStatus(){Id = 3, Status = "Отгружен"},
            new OrderStatus(){Id = 4, Status = "Закрыт"}
        };
        #endregion

        #region ContactInfo
        public static List<ContactInfo> ContactInfoCollection = new List<ContactInfo>() 
        {
            new ContactInfo()
            {
                Id = 0,
                City = "Днепропетровск",
                Adress = "ул. Каруна, д.8, кв.14",
                Telephone = "066-309-55-89",
                Email = "ContactKar@gmail.com"
            },
            new ContactInfo()
            {
                Id = 1,
                City = "Киев",
                Adress = "ул. Институтская, д.15, кв.12",
                Telephone = "097-543-17-25",
                Email = "ContactIns@gmail.com"
            },
            new ContactInfo()
            {
                Id = 2,
                City = "Львов",
                Adress = "ул. Малиновского, д.23, кв.9",
                Telephone = "067-495-33-22",
                Email = "ContactMal@gmail.com"
            },
            new ContactInfo()
            {
                Id = 3,
                City = "Миргород",
                Adress = "ул. Баторжинского, д.55, кв.44",
                Telephone = "050-222-09-99",
                Email = "ContactBat@gmail.com"
            },
            new ContactInfo()
            {
                Id = 4,
                City = "Черновцы",
                Adress = "ул. Калугина, д.11, кв.22",
                Telephone = "097-543-17-25",
                Email = "ContactCalug@gmail.com"
            },
            new ContactInfo()
            {
                Id = 5,
                City = "Днепропетровск",
                Adress = "ул. Б.Хмельницкого, д.10, кв.2",
                Telephone = "067-111-77-17",
                Email = "ContactHmel@gmail.com"
            },
            new ContactInfo()
            {
                Id = 6,
                City = "Ужгород",
                Adress = "ул. Варшавская, д.233, кв.55",
                Telephone = "050-667-12-21",
                Email = "ContactVar@gmail.com"
            },
            new ContactInfo()
            {
                Id = 7,
                City = "Одесса",
                Adress = "ул. Курортная, д.44, кв.85",
                Telephone = "098-485-54-85",
                Email = "ContactKurort@gmail.com"
            },
            new ContactInfo()
            {
                Id = 8,
                City = "Днепропетровск",
                Adress = "ул. Кирова, д.2, кв.507",
                Telephone = "050-333-22-44",
                Email = "ContactKirova@gmail.com"
            },
            new ContactInfo()
            {
                Id = 9,
                City = "Софиевка",
                Adress = "ул. Казаческая, д.77, кв.27",
                Telephone = "097-662-55-99",
                Email = "ContactKozac@gmail.com"
            }
        };
        #endregion

        #region Comment
        public static List<Comment> CommentCollection = new List<Comment>()
            {
                new Comment(){Id = 0, Message="This order is for Mr.Been", Type=CommentType.Order},
                new Comment(){Id = 1,  Message= "Утром деньги, вечером стуья",Type=CommentType.Order},
                new Comment(){Id = 2,  Message= "Стулья ничего так, но себе лучше не брать", Type=CommentType.Goods},
                new Comment(){Id = 3,  Message="Брать предоплату 100%!!",Type= CommentType.Customer},
                new Comment(){Id = 4,  Message= "Норм чел. Никаких претензий или проблем",Type= CommentType.Customer},
                new Comment(){Id = 5,  Message="Ну и заказик... ", Type=CommentType.Order},
                new Comment(){Id = 6,  Message= "Шкафы классные, но на дверях лучше не кататься", Type=CommentType.Goods},
                new Comment(){Id = 7, Message= "Видимо кресло хорошее, т.к. шеф себе заказал",Type= CommentType.Goods},
                new Comment(){Id = 8, Message= "ЧП \"Ромашка\" для офиса. Опт", Type=CommentType.Order},
                new Comment(){Id = 9,  Message = "Необходимо привезти завтра до 10", Type=CommentType.Order }
       };
        #endregion

        #region Customer
        public static List<Customer> CustomerCollection = new List<Customer>()
        {
            new Customer()
            {
                Id = 0,
                PersonalInfo = PersonalInfoCollection[0],
                Contacts = ContactInfoCollection[0],
                Orders = new List<Order>(),
                Comments = new List<Comment>(){CommentCollection.Where(x => x.Type == CommentType.Customer).ToList()[0]}
            },
            new Customer()
            {
                Id = 1,
                PersonalInfo = PersonalInfoCollection[1],
                Contacts = ContactInfoCollection[1],
                Comments = new List<Comment>(){CommentCollection.Where(x => x.Type == CommentType.Customer).ToList()[0]}
            },
            new Customer()
            {
                Id = 2,
                PersonalInfo = PersonalInfoCollection[2],
                Contacts = ContactInfoCollection[2],
                Comments = new List<Comment>(){CommentCollection.Where(x => x.Type == CommentType.Customer).ToList()[1]}
            },
            new Customer()
            {
                Id = 3,
                PersonalInfo = PersonalInfoCollection[3],
                Contacts = ContactInfoCollection[3],
                Comments = new List<Comment>(){CommentCollection.Where(x => x.Type == CommentType.Customer).ToList()[0]}
            },
            new Customer()
            {
                Id = 9,
                PersonalInfo = PersonalInfoCollection[4],
                Contacts = ContactInfoCollection[4],
                Comments = new List<Comment>(){CommentCollection.Where(x => x.Type == CommentType.Customer).ToList()[1]}
            },
            new Customer()
            {
                Id = 4,
                PersonalInfo = PersonalInfoCollection[5],
                Contacts = ContactInfoCollection[5],
                Comments = new List<Comment>(){CommentCollection.Where(x => x.Type == CommentType.Customer).ToList()[1]}
            },
            new Customer()
            {
                Id = 5,
                PersonalInfo = PersonalInfoCollection[6],
                Contacts = ContactInfoCollection[6],
                Comments = new List<Comment>(){CommentCollection.Where(x => x.Type == CommentType.Customer).ToList()[0]}
            },
            new Customer()
            {
                Id = 6,
                PersonalInfo = PersonalInfoCollection[7],
                Contacts = ContactInfoCollection[7],
                Comments = new List<Comment>(){CommentCollection.Where(x => x.Type == CommentType.Customer).ToList()[1]}
            },
            new Customer()
            {
                Id = 7,
                PersonalInfo = PersonalInfoCollection[8],
                Contacts = ContactInfoCollection[8],
                Comments = new List<Comment>(){CommentCollection.Where(x => x.Type == CommentType.Customer).ToList()[0]}
            },
            new Customer()
            {
                Id = 8,
                PersonalInfo = PersonalInfoCollection[9],
                Contacts = ContactInfoCollection[9],
                Comments = new List<Comment>(){CommentCollection.Where(x => x.Type == CommentType.Customer).ToList()[1]}
            }
        };
        #endregion

        #region Goods
        public static List<Goods> goodsCollection = new List<Goods>()
        {
            new Goods(){Id = 0, Name="Стул Комфорт", Category = categoryCollection[0]},
            new Goods(){Id = 1, Name="Стол Венеция",Category = categoryCollection[1]},
            new Goods(){Id = 2, Name="Шкаф Марк",Category = categoryCollection[2]},
            new Goods(){Id = 3, Name="Диван Тина с кушеткой",Category = categoryCollection[3]},
            new Goods(){Id = 4, Name="Кровать Соната",Category = categoryCollection[4]},
            new Goods(){Id = 5, Name="Полка Юниор",Category = categoryCollection[5]},
            new Goods(){Id = 6, Name="Кухня Модерн",Category = categoryCollection[6]},
            new Goods(){Id = 7, Name="Ручка дверная Стерх",Category = categoryCollection[7]},
            new Goods(){Id = 8, Name="Комод Ришелье",Category = categoryCollection[8]},
            new Goods(){Id = 9, Name="Тумба Стандарт прикроватная",Category = categoryCollection[9]},
        };
        #endregion

        #region GoodsRow
        public static List<GoodsRow> GoodsRowCollection = new List<GoodsRow>() 
        { 
            new GoodsRow(){Id = 0,Goods = goodsCollection[0], Count=2},
            new GoodsRow(){Id = 1,Goods = goodsCollection[1], Count=1},
            new GoodsRow(){Id = 2,Goods = goodsCollection[2], Count=1},
            new GoodsRow(){Id = 3,Goods = goodsCollection[3], Count=1},
            new GoodsRow(){Id = 4,Goods = goodsCollection[4], Count=1},
            new GoodsRow(){Id = 5,Goods = goodsCollection[5], Count=2},
            new GoodsRow(){Id = 6,Goods = goodsCollection[6], Count=1},
            new GoodsRow(){Id = 7,Goods = goodsCollection[7], Count=4},
            new GoodsRow(){Id = 8,Goods = goodsCollection[8], Count=1},
            new GoodsRow(){Id = 9,Goods = goodsCollection[9], Count=2},
        };
        #endregion

        #region Order
        public static List<Order> OrderCollection = new List<Order>() 
        { 
            new Order(){Id = 0, Customer = CustomerCollection[0], Status = OrderStatusCollection[0], Comments = CommentCollection.Where(x => x.Type == CommentType.Order).ToList()},
            new Order(){Id = 1, Customer = CustomerCollection[1], Status = OrderStatusCollection[1], Comments = CommentCollection.Where(x => x.Type == CommentType.Order).ToList()},
            new Order(){Id = 2, Customer = CustomerCollection[2], Status = OrderStatusCollection[1], Comments = CommentCollection.Where(x => x.Type == CommentType.Order).ToList()},
            new Order(){Id = 3, Customer = CustomerCollection[3], Status = OrderStatusCollection[2], Comments = CommentCollection.Where(x => x.Type == CommentType.Order).ToList()},
            new Order(){Id = 4, Customer = CustomerCollection[4], Status = OrderStatusCollection[2], Comments = CommentCollection.Where(x => x.Type == CommentType.Order).ToList()},
            new Order(){Id = 5, Customer = CustomerCollection[5], Status = OrderStatusCollection[3], Comments = CommentCollection.Where(x => x.Type == CommentType.Order).ToList()},
            new Order(){Id = 6, Customer = CustomerCollection[6], Status = OrderStatusCollection[4], Comments = CommentCollection.Where(x => x.Type == CommentType.Order).ToList()},
            new Order(){Id = 7, Customer = CustomerCollection[7], Status = OrderStatusCollection[4], Comments = CommentCollection.Where(x => x.Type == CommentType.Order).ToList()},
            new Order(){Id = 8, Customer = CustomerCollection[8], Status = OrderStatusCollection[0], Comments = CommentCollection.Where(x => x.Type == CommentType.Order).ToList()},
            new Order(){Id = 9, Customer = CustomerCollection[9], Status = OrderStatusCollection[0], Comments = CommentCollection.Where(x => x.Type == CommentType.Order).ToList()},
        };
        #endregion

        #region Permission
        public static List<Permission> PermissionCollection = new List<Permission>() 
        {
            new Permission(){Id=0,EditTime = DateTime.Now, Type = Domain.PermissionType.EditUser},
            new Permission(){Id=1,EditTime = DateTime.Now, Type = Domain.PermissionType.ListUser},
            new Permission(){Id=2,EditTime = DateTime.Now, Type = Domain.PermissionType.NewUser},
            new Permission{Id=3,EditTime = DateTime.Now, Type = Domain.PermissionType.PrintReportUsers},
            new Permission{Id=4,EditTime = DateTime.Now, Type = Domain.PermissionType.SaveListUsers},
            new Permission(){Id=5,EditTime = DateTime.Now},
            new Permission(){Id=6,EditTime = DateTime.Now},
            new Permission(){Id=7,EditTime = DateTime.Now},
            new Permission(){Id=8,EditTime = DateTime.Now},
            new Permission(){Id=9,EditTime = DateTime.Now},

        };
        #endregion

        public Storage()
        {
            CustomerCollection[0].Orders.Add(OrderCollection[0]);
            CustomerCollection[1].Orders.Add(OrderCollection[1]);
            CustomerCollection[2].Orders.Add(OrderCollection[2]);
            CustomerCollection[3].Orders.Add(OrderCollection[3]);
            CustomerCollection[4].Orders.Add(OrderCollection[4]);
            CustomerCollection[5].Orders.Add(OrderCollection[5]);
            CustomerCollection[6].Orders.Add(OrderCollection[6]);
            CustomerCollection[7].Orders.Add(OrderCollection[7]);
            CustomerCollection[8].Orders.Add(OrderCollection[8]);
            CustomerCollection[9].Orders.Add(OrderCollection[9]);

            OrderCollection[0].GoodsList.Add(GoodsRowCollection[0]);
            OrderCollection[1].GoodsList.Add(GoodsRowCollection[1]);
            OrderCollection[2].GoodsList.Add(GoodsRowCollection[2]);
            OrderCollection[3].GoodsList.Add(GoodsRowCollection[3]);
            OrderCollection[4].GoodsList.Add(GoodsRowCollection[4]);
            OrderCollection[5].GoodsList.Add(GoodsRowCollection[5]);
            OrderCollection[6].GoodsList.Add(GoodsRowCollection[6]);
            OrderCollection[7].GoodsList.Add(GoodsRowCollection[7]);
            OrderCollection[8].GoodsList.Add(GoodsRowCollection[8]);
            OrderCollection[9].GoodsList.Add(GoodsRowCollection[9]);

            RoleCollection[0].Permissions = PermissionCollection;
        }
    }
}
