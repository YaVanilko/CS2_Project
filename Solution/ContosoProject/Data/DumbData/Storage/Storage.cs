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
        public static List<Role> roleCollection = AddTenRoles();

        private static List<Role> AddTenRoles()
        {
            List<Role> roleCollection = new List<Role>();
            for (int i = 0; i < 9; i++)
            {
                Role role = new Role();
                roleCollection.Add(role);
            }
            return roleCollection;
        }

        #endregion

        #region User
        public static List<User> userCollection = AddTenUsers();

        private static List<User> AddTenUsers()
        {
            List<User> userCollection = new List<User>();

            for (int i = 0; i < 9; i++)
            {
                User user = new User();
                user.Login = "user" + i;
                user.Password = "user" + i;
                user.UserInfo = personalInfoCollection[i];
                user.UserRole = roleCollection[i];
                user.Operator = user;

                userCollection.Add(user);
            }
            return userCollection;
        }
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

        #region PersonalInfo
        public static List<PersonalInfo> personalInfoCollection = new List<PersonalInfo>()
        {
            new PersonalInfo()
            {
                FirstName = "Татьяна",
                MiddleName = "Витальевна",
                LastName = "Петрова"
            },
            new PersonalInfo()
            {
                FirstName = "Олег",
                MiddleName = "Евгеньевич",
                LastName = "Таромский"
            },
            new PersonalInfo()
            {
                FirstName = "Григорий",
                MiddleName = "Вениаминович",
                LastName = "Крашенберг"
            },
            new PersonalInfo()
            {
                FirstName = "Зиновия",
                MiddleName = "Сидоровна",
                LastName = "Белугина"
            },
            new PersonalInfo()
            {
                FirstName = "Раиса",
                MiddleName = "Васильевна",
                LastName = "Райская"
            },
            new PersonalInfo()
            {
                FirstName = "Матвей",
                MiddleName = "Иванович",
                LastName = "Костромской"
            },
            new PersonalInfo()
            {
                FirstName = "Антон",
                MiddleName = "Денисович",
                LastName = "Бесстужев"
            },
            new PersonalInfo()
            {
                FirstName = "Иполит",
                MiddleName = "Петрович",
                LastName = "Легкопаров"
            },
            new PersonalInfo()
            {
                FirstName = "Маргарита",
                MiddleName = "Альбертовна",
                LastName = "Королева"
            },
            new PersonalInfo()
            {
                FirstName = "Наталья",
                MiddleName = "Александровна",
                LastName = "Ростова"
            }
        };
        #endregion

        #region OrderStatus
        public static List<OrderStatus> orderStatusCollection = new List<OrderStatus>()
        { 
            new OrderStatus(){ Status = "Открыт"},
            new OrderStatus(){ Status = "Оплачен"},
            new OrderStatus(){ Status = "Готов"},
            new OrderStatus(){ Status = "Отгружен"},
            new OrderStatus(){ Status = "Закрыт"}
        };
        #endregion

        #region ContactInfo
        public static List<ContactInfo> contactInfoCollection = new List<ContactInfo>() 
        {
            new ContactInfo()
            {
                City = "Днепропетровск",
                Adress = "ул. Каруна, д.8, кв.14",
                Telephone = "066-309-55-89",
                Email = "ContactKar@gmail.com"
            },
            new ContactInfo()
            {
                City = "Киев",
                Adress = "ул. Институтская, д.15, кв.12",
                Telephone = "097-543-17-25",
                Email = "ContactIns@gmail.com"
            },
            new ContactInfo()
            {
                City = "Львов",
                Adress = "ул. Малиновского, д.23, кв.9",
                Telephone = "067-495-33-22",
                Email = "ContactMal@gmail.com"
            },
            new ContactInfo()
            {
                City = "Миргород",
                Adress = "ул. Баторжинского, д.55, кв.44",
                Telephone = "050-222-09-99",
                Email = "ContactBat@gmail.com"
            },
            new ContactInfo()
            {
                City = "Черновцы",
                Adress = "ул. Калугина, д.11, кв.22",
                Telephone = "097-543-17-25",
                Email = "ContactCalug@gmail.com"
            },
            new ContactInfo()
            {
                City = "Днепропетровск",
                Adress = "ул. Б.Хмельницкого, д.10, кв.2",
                Telephone = "067-111-77-17",
                Email = "ContactHmel@gmail.com"
            },
            new ContactInfo()
            {
                City = "Ужгород",
                Adress = "ул. Варшавская, д.233, кв.55",
                Telephone = "050-667-12-21",
                Email = "ContactVar@gmail.com"
            },
            new ContactInfo()
            {
                City = "Одесса",
                Adress = "ул. Курортная, д.44, кв.85",
                Telephone = "098-485-54-85",
                Email = "ContactKurort@gmail.com"
            },
            new ContactInfo()
            {
                City = "Днепропетровск",
                Adress = "ул. Кирова, д.2, кв.507",
                Telephone = "050-333-22-44",
                Email = "ContactKirova@gmail.com"
            },
            new ContactInfo()
            {
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
                new Comment(){Operator = userCollection[2], Message="This order is for Mr.Been", Type=CommentType.Order},
                new Comment(){Operator = userCollection[1], Message= "Утром деньги, вечером стуья",Type=CommentType.Order},
                new Comment(){Operator = userCollection[0], Message= "Стулья ничего так, но себе лучше не брать", Type=CommentType.Goods},
                new Comment(){Operator = userCollection[5], Message="Брать предоплату 100%!!",Type= CommentType.Customer},
                new Comment(){Operator = userCollection[5], Message= "Норм чел. Никаких претензий или проблем",Type= CommentType.Customer},
                new Comment(){Operator = userCollection[5], Message="Ну и заказик... ", Type=CommentType.Order},
                new Comment(){Operator = userCollection[6], Message= "Шкафы классные, но на дверях лучше не кататься", Type=CommentType.Goods},
                new Comment(){Operator = userCollection[9], Message= "Видимо кресло хорошее, т.к. шеф себе заказал",Type= CommentType.Goods},
                new Comment(){Operator = userCollection[9], Message= "ЧП \"Ромашка\" для офиса. Опт", Type=CommentType.Order},
                new Comment(){Operator = userCollection[7], Message = "Необходимо привезти завтра до 10", Type=CommentType.Order }
       };
        #endregion

        #region Customer
        public static List<Customer> customerCollection = new List<Customer>()
        {
            new Customer()
            {
                PersonalInfo = personalInfoCollection[0],
                Contacts = contactInfoCollection[0],
                Orders = new List<Order>(){orderCollection[0]},
                Comments = new List<Comment>(){commentCollection[0]}
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[1],
                Contacts = contactInfoCollection[1],
                Orders = new List<Order>(){orderCollection[1]},
                Comments = new List<Comment>(){commentCollection[1]}
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[2],
                Contacts = contactInfoCollection[2],
                Orders = new List<Order>(){orderCollection[2]},
                Comments = new List<Comment>(){commentCollection[2]}
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[3],
                Contacts = contactInfoCollection[3],
                Orders = new List<Order>(){orderCollection[3]},
                Comments = new List<Comment>(){commentCollection[3]}
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[4],
                Contacts = contactInfoCollection[4],
                Orders = new List<Order>(){orderCollection[4]},
                Comments = new List<Comment>(){commentCollection[4]}
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[5],
                Contacts = contactInfoCollection[5],
                Orders = new List<Order>(){orderCollection[5]},
                Comments = new List<Comment>(){commentCollection[5]}
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[6],
                Contacts = contactInfoCollection[6],
                Orders = new List<Order>(){orderCollection[6]},
                Comments = new List<Comment>(){commentCollection[6]}
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[7],
                Contacts = contactInfoCollection[7],
                Orders = new List<Order>(){orderCollection[7]},
                Comments = new List<Comment>(){commentCollection[7]}
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[8],
                Contacts = contactInfoCollection[8],
                Orders = new List<Order>(){orderCollection[8]},
                Comments = new List<Comment>(){commentCollection[8]}
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[9],
                Contacts = contactInfoCollection[9],
                Orders = new List<Order>(){orderCollection[9]},
                Comments = new List<Comment>(){commentCollection[9]}
            }
        };
        #endregion

        #region GoodsRow
        public static List<GoodsRow> goodsRowCollection = AddTenRows();

        private static List<GoodsRow> AddTenRows()
        {
            List<GoodsRow> goodsRowCollection = new List<GoodsRow>();
            for (int i = 0; i < 9; i++)
            {
                GoodsRow row = new GoodsRow();
                row.Count = i;
                row.Goods = goodsCollection[i];
                row.Operator = userCollection[i];
                row.Price = i * 1.1;
            }
            return goodsRowCollection;
        }
        #endregion

        #region Goods
        public static List<Goods> goodsCollection = AddTenGoods();

        private static List<Goods> AddTenGoods()
        {
            List<Goods> goodsCollection = new List<Goods>();
            for (int i = 0; i < 9; i++)
            {
                Goods goods = new Goods();
                goods.Category = categoryCollection[i];
                goods.Count = i;
                goods.Coments.Add(new Comment() { Message = "GoodsComment" + i });
                goods.Name = "goodsName " + i;
                goods.Operator = userCollection[i];
                goods.Price = i * 1.11;
                goods.SKU = new String((char)i, 10);
            }
            return goodsCollection;
        }
        #endregion

        #region Order
        public static List<Order> orderCollection = AddTenOrders();

        private static List<Order> AddTenOrders()
        {
            List<Order> orderCollection = new List<Order>();

            for (int i = 0; i < 9; i++)
            {
                Order order = new Order();
                order.Customer = customerCollection[i];
                order.comments.Add(new Comment() { Message = "commentfromOrder" + i, Type = CommentType.Order });
                order.Operator = userCollection[i];
                order.goodsList.Add(goodsRowCollection[i]);

                orderCollection.Add(order);
            }
            return orderCollection;
        }
        #endregion

        #region Permission
        public static List<Permission> permissionCollection = AddTenPermission();

        private static List<Permission> AddTenPermission()
        {
            List<Permission> permissionCollection = new List<Permission>();
            for (int i = 0; i < 9; i++)
            {
                Permission permission = new Permission();
                permissionCollection.Add(permission);
            }
            return permissionCollection;
        }
        #endregion
    }
}
