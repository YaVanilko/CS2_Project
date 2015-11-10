using Data.EFData;
using ContosoUI.Presenter;
using Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ContosoUI.Order.AddEdit
{
    public class AddEditOrderPresenter : BasePresenter
    {
        public AddEditOrderPresenter(AddEditOrderView view, int orderId)
        {
            this.view = view;

            goods.AddRange(modelProxy.GoodsModel.GetAll().Where(x => x.IsActive == true));

            if (orderId >= 0)
            {
                order = modelProxy.OrderModel.GetById(orderId);
            }
            else
            {
                order = new Domain.Entities.Order();
            }
        }

        readonly AddEditOrderView view;
        readonly AddOrderProxy modelProxy = new AddOrderProxy();
        IUserNotify notifyManager = Program.MainWiewInstance;
        Domain.Entities.Order order;

        public List<GoodsRow> GoodsListSource
        {
            get { return order.GoodsList.ToList(); }
        }

        public List<Customer> Customers
        {
            get { return modelProxy.CustomerModel.GetAll().Where(x => x.IsActive == true).ToList(); }
        }

        public List<OrderStatus> Statuses
        {
            get { return modelProxy.OrderStatusModel.GetAll().Distinct().ToList(); }
        }

        List<Goods> goods = new List<Goods>();
        public List<Goods> Goods
        {
            get { return goods; }
        }

        public List<Comment> Comments
        {
            get { return order.Comments.ToList(); }
            set
            {
                if (Comments != value)
                {
                    Comments = value;
                    NotifyPropertyChanged("Comments");
                }
            }
        }

        public Customer Customer
        {
            get { return order.Customer; }
            set
            {
                if (order.Customer != value)
                {
                    order.Customer = value;
                    NotifyPropertyChanged("Customer");
                }
            }    
        }

        public OrderStatus Status
        {
            get { return order.Status; }
            set
            {
                if (order.Status != value)
                {
                    order.Status = value;
                    NotifyPropertyChanged("Status");
                }
            }
        }

        private Goods selectedGood { get; set; }
        public Goods SelectedGood
        {
            get { return selectedGood; }
            set
            {
                if (selectedGood != value)
                {
                    selectedGood = value;
                    NotifyPropertyChanged("SelectedGood");
                }
            }
        }

        private int countOfGood;
        public int CountOfGood
        {
            get { return countOfGood; }
            set
            {
                if (countOfGood != value)
                {
                    countOfGood = value;
                    NotifyPropertyChanged("CountOfGood");
                }
            }
        }

        public double TotalCost
        {
            get { return order.TotalCost; }
        }

        private string message;
        public string Message
        {
            get { return message; }
            set
            {
                if (message != value)
                {
                    message = value;
                    NotifyPropertyChanged("Message");
                }
            }
        }

        public Comment Comment
        {
            get { return new Comment() { Message = message, Type = CommentType.Order }; }
        }

        public void AddGoodRow()
        {
            GoodsRow newGoodsRow = new GoodsRow() { Goods = SelectedGood, Count = CountOfGood, Price = SelectedGood.Price };
            order.GoodsList.Add(newGoodsRow);
            NotifyPropertyChanged("AddGoodRow");
        }

        public void AddComment()
        {
            order.Comments.Add(Comment);
            message = string.Empty;
            NotifyPropertyChanged("CommentsAdd");
        }

        public void Save()
        {
            if (order.Id > 0)
            {
                modelProxy.OrderModel.Update(order);
                notifyManager.ShowInfo("Заказ обновлен", "Сообщение");
            }
            else
            {
                modelProxy.OrderModel.Add(order);
                notifyManager.ShowInfo("Заказ добавлен", "Сообщение");
            }
        }

        public void SaveAndNew()
        {
            Save();
            order = new Domain.Entities.Order();
            NotifyPropertyChanged("SaveAndNew");
        }
    }
}
