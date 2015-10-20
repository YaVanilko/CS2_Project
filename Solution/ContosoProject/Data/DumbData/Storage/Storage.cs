using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DumbData
{
    public class Storage
    {
        #region Role
        public static List<Role> RoleCollection = new List<Role>()
        {
            new Role{Id=0},
            new Role{Id=1},
            new Role{Id=2},
            new Role{Id=3},
            new Role{Id=4},
            new Role{Id=5},
            new Role{Id=6},
            new Role{Id=7},
            new Role{Id=8},
            new Role{Id=9}
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

        #region User
        public static List<User> UserCollection = new List<User>() 
        {
            new User {Id=0, Login="admin",Password="123",UserInfo = PersonalInfoCollection[0], UserRole = RoleCollection[0]},
            new User {Id=1, Login="manager",Password="123",UserInfo = PersonalInfoCollection[1], UserRole = RoleCollection[1]},
            new User {Id=2, Login="boss",Password="123",UserInfo = PersonalInfoCollection[2], UserRole = RoleCollection[2]},
            new User {Id=3, Login="user3",Password="123",UserInfo = PersonalInfoCollection[3], UserRole = RoleCollection[3]},
            new User {Id=3, Login="user4",Password="123",UserInfo = PersonalInfoCollection[4], UserRole = RoleCollection[4]},
            new User {Id=3, Login="user5",Password="123",UserInfo = PersonalInfoCollection[5], UserRole = RoleCollection[5]},
            new User {Id=3, Login="user6",Password="123",UserInfo = PersonalInfoCollection[6], UserRole = RoleCollection[6]},
            new User {Id=3, Login="user7",Password="123",UserInfo = PersonalInfoCollection[7], UserRole = RoleCollection[7]},
            new User {Id=3, Login="user8",Password="123",UserInfo = PersonalInfoCollection[8], UserRole = RoleCollection[8]},
            new User {Id=3, Login="user9",Password="123",UserInfo = PersonalInfoCollection[9], UserRole = RoleCollection[9]},

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
                new Comment(){Id = 0, Operator = UserCollection[2], Message="This order is for Mr.Been", Type=CommentType.Order},
                new Comment(){Id = 1, Operator = UserCollection[1], Message= "Утром деньги, вечером стуья",Type=CommentType.Order},
                new Comment(){Id = 2, Operator = UserCollection[0], Message= "Стулья ничего так, но себе лучше не брать", Type=CommentType.Goods},
                new Comment(){Id = 3, Operator = UserCollection[1], Message="Брать предоплату 100%!!",Type= CommentType.Customer},
                new Comment(){Id = 4, Operator = UserCollection[1], Message= "Норм чел. Никаких претензий или проблем",Type= CommentType.Customer},
                new Comment(){Id = 5, Operator = UserCollection[1], Message="Ну и заказик... ", Type=CommentType.Order},
                new Comment(){Id = 6, Operator = UserCollection[1], Message= "Шкафы классные, но на дверях лучше не кататься", Type=CommentType.Goods},
                new Comment(){Id = 7, Operator = UserCollection[1], Message= "Видимо кресло хорошее, т.к. шеф себе заказал",Type= CommentType.Goods},
                new Comment(){Id = 8, Operator = UserCollection[1], Message= "ЧП \"Ромашка\" для офиса. Опт", Type=CommentType.Order},
                new Comment(){Id = 9, Operator = UserCollection[1], Message = "Необходимо привезти завтра до 10", Type=CommentType.Order }
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
            new GoodsRow{Id = 0,Goods = goodsCollection[0], Count=2, Price=400, TotalPrice=800},
            new GoodsRow{Id = 1,Goods = goodsCollection[1], Count=1, Price=2000, TotalPrice=2000},
            new GoodsRow{Id = 2,Goods = goodsCollection[2], Count=1, Price=1400, TotalPrice=1400},
            new GoodsRow{Id = 3,Goods = goodsCollection[3], Count=1, Price=12400, TotalPrice=12400},
            new GoodsRow{Id = 4,Goods = goodsCollection[4], Count=1, Price=6059.16, TotalPrice=6059.16},
            new GoodsRow{Id = 5,Goods = goodsCollection[5], Count=2, Price=605, TotalPrice=1210},
            new GoodsRow{Id = 6,Goods = goodsCollection[6], Count=1, Price=7000.80},
            new GoodsRow{Id = 7,Goods = goodsCollection[7], Count=4, Price=200, TotalPrice=800},
            new GoodsRow{Id = 8,Goods = goodsCollection[8], Count=1, Price=1200, TotalPrice=1200},
            new GoodsRow{Id = 9,Goods = goodsCollection[9], Count=2, Price=500, TotalPrice=1000},
        };
        #endregion

        #region Order
        public static List<Order> OrderCollection = new List<Order>() 
        { 
            new Order{Id = 0, Customer = CustomerCollection[0]},
            new Order{Id = 1, Customer = CustomerCollection[1]},
            new Order{Id = 2, Customer = CustomerCollection[2]},
            new Order{Id = 3, Customer = CustomerCollection[3]},
            new Order{Id = 4, Customer = CustomerCollection[4]},
            new Order{Id = 5, Customer = CustomerCollection[5]},
            new Order{Id = 6, Customer = CustomerCollection[6]},
            new Order{Id = 7, Customer = CustomerCollection[7]},
            new Order{Id = 8, Customer = CustomerCollection[8]},
            new Order{Id = 9, Customer = CustomerCollection[9]},
        };
        #endregion

        #region Permission
        public static List<Permission> PermissionCollection = new List<Permission>() 
        {
            new Permission{Id=0,EditTime = DateTime.Now},
            new Permission{Id=1,EditTime = DateTime.Now},
            new Permission{Id=2,EditTime = DateTime.Now},
            new Permission{Id=3,EditTime = DateTime.Now},
            new Permission{Id=4,EditTime = DateTime.Now},
            new Permission{Id=5,EditTime = DateTime.Now},
            new Permission{Id=6,EditTime = DateTime.Now},
            new Permission{Id=7,EditTime = DateTime.Now},
            new Permission{Id=8,EditTime = DateTime.Now},
            new Permission{Id=9,EditTime = DateTime.Now},

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

            OrderCollection[0].goodsList.Add(GoodsRowCollection[0]);
            OrderCollection[1].goodsList.Add(GoodsRowCollection[1]);
            OrderCollection[2].goodsList.Add(GoodsRowCollection[2]);
            OrderCollection[3].goodsList.Add(GoodsRowCollection[3]);
            OrderCollection[4].goodsList.Add(GoodsRowCollection[4]);
            OrderCollection[5].goodsList.Add(GoodsRowCollection[5]);
            OrderCollection[6].goodsList.Add(GoodsRowCollection[6]);
            OrderCollection[7].goodsList.Add(GoodsRowCollection[7]);
            OrderCollection[8].goodsList.Add(GoodsRowCollection[8]);
            OrderCollection[9].goodsList.Add(GoodsRowCollection[9]);
        }
    }
}
