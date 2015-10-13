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
        public static List<Role> roleCollection = new List<Role>()
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
        public static List<PersonalInfo> personalInfoCollection = new List<PersonalInfo>()
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
        public static List<User> userCollection = new List<User>() 
        {
            new User {Id=0, Login="admin",Password="123",UserInfo = personalInfoCollection[0], UserRole = roleCollection[0]},
            new User {Id=1, Login="manager",Password="123",UserInfo = personalInfoCollection[1], UserRole = roleCollection[1]},
            new User {Id=2, Login="boss",Password="123",UserInfo = personalInfoCollection[2], UserRole = roleCollection[2]}
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
        public static List<OrderStatus> orderStatusCollection = new List<OrderStatus>()
        { 
            new OrderStatus(){Id = 0, Status = "Открыт"},
            new OrderStatus(){Id = 1, Status = "Оплачен"},
            new OrderStatus(){Id = 2, Status = "Готов"},
            new OrderStatus(){Id = 3, Status = "Отгружен"},
            new OrderStatus(){Id = 4, Status = "Закрыт"}
        };
        #endregion

        #region ContactInfo
        public static List<ContactInfo> contactInfoCollection = new List<ContactInfo>() 
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
        public static List<Comment> commentCollection = new List<Comment>()
            {
                new Comment(){Id = 0, Operator = userCollection[2], Message="This order is for Mr.Been", Type=CommentType.Order},
                new Comment(){Id = 1, Operator = userCollection[1], Message= "Утром деньги, вечером стуья",Type=CommentType.Order},
                new Comment(){Id = 2, Operator = userCollection[0], Message= "Стулья ничего так, но себе лучше не брать", Type=CommentType.Goods},
                new Comment(){Id = 3, Operator = userCollection[1], Message="Брать предоплату 100%!!",Type= CommentType.Customer},
                new Comment(){Id = 4, Operator = userCollection[1], Message= "Норм чел. Никаких претензий или проблем",Type= CommentType.Customer},
                new Comment(){Id = 5, Operator = userCollection[1], Message="Ну и заказик... ", Type=CommentType.Order},
                new Comment(){Id = 6, Operator = userCollection[1], Message= "Шкафы классные, но на дверях лучше не кататься", Type=CommentType.Goods},
                new Comment(){Id = 7, Operator = userCollection[1], Message= "Видимо кресло хорошее, т.к. шеф себе заказал",Type= CommentType.Goods},
                new Comment(){Id = 8, Operator = userCollection[1], Message= "ЧП \"Ромашка\" для офиса. Опт", Type=CommentType.Order},
                new Comment(){Id = 9, Operator = userCollection[1], Message = "Необходимо привезти завтра до 10", Type=CommentType.Order }
       };
        #endregion

        #region Customer
        public static List<Customer> customerCollection = new List<Customer>()
        {
            new Customer()
            {
                Id = 0,
                PersonalInfo = personalInfoCollection[0],
                Contacts = contactInfoCollection[0],
            },
            new Customer()
            {
                Id = 1,
                PersonalInfo = personalInfoCollection[1],
                Contacts = contactInfoCollection[1],
            },
            new Customer()
            {
                Id = 2,
                PersonalInfo = personalInfoCollection[2],
                Contacts = contactInfoCollection[2],
            },
            new Customer()
            {
                Id = 3,
                PersonalInfo = personalInfoCollection[2],
                Contacts = contactInfoCollection[2],
            },
            new Customer()
            {
                Id = 9,
                PersonalInfo = personalInfoCollection[2],
                Contacts = contactInfoCollection[2],
            },
            new Customer()
            {
                Id = 4,
                PersonalInfo = personalInfoCollection[5],
                Contacts = contactInfoCollection[5],
            },
            new Customer()
            {
                Id = 5,
                PersonalInfo = personalInfoCollection[6],
                Contacts = contactInfoCollection[6],
            },
            new Customer()
            {
                Id = 6,
                PersonalInfo = personalInfoCollection[7],
                Contacts = contactInfoCollection[7],
            },
            new Customer()
            {
                Id = 7,
                PersonalInfo = personalInfoCollection[8],
                Contacts = contactInfoCollection[8],
            },
            new Customer()
            {
                Id = 8,
                PersonalInfo = personalInfoCollection[9],
                Contacts = contactInfoCollection[9],
            }
        };
        #endregion

        #region Goods
        public static List<Goods> goodsCollection = new List<Goods>()
        {
            new Goods(){Id = 0, Name="g1", Category = categoryCollection[0]},
            new Goods(){Id = 1, Name="g2",Category = categoryCollection[0]},
            new Goods(){Id = 2, Name="g3",Category = categoryCollection[0]},
            new Goods(){Id = 3, Name="g4",Category = categoryCollection[0]}
        };
        #endregion

        #region GoodsRow
        public static List<GoodsRow> goodsRowCollection = new List<GoodsRow>() 
        { 
            new GoodsRow{Id = 0,Goods = goodsCollection[0], Count=1, Price=1},
            new GoodsRow{Id = 1,Goods = goodsCollection[1], Count=1, Price=1},
            new GoodsRow{Id = 2,Goods = goodsCollection[2], Count=1, Price=1},
            new GoodsRow{Id = 3,Goods = goodsCollection[2], Count=1, Price=1}
        };
        #endregion

        #region Order
        public static List<Order> orderCollection = new List<Order>() 
        { 
            new Order{Id = 0, Customer = customerCollection[0]},
            new Order{Id = 1, Customer = customerCollection[2]},
            new Order{Id = 2, Customer = customerCollection[3]},
            new Order{Id = 3, Customer = customerCollection[4]},
            new Order{Id = 4, Customer = customerCollection[5]}
        };
        #endregion

        #region Permission
        public static List<Permission> permissionCollection = new List<Permission>() 
        {
            new Permission{Id=0,EditTime = DateTime.Now},
            new Permission{Id=1,EditTime = DateTime.Now},
            new Permission{Id=2,EditTime = DateTime.Now},
        };
        #endregion
    }
}
