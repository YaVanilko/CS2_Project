using Data.EFData;
using ContosoUI.Presenter;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ContosoUI.Order.AddEdit
{
    public class AddEditOrderPresenter : BasePresenter, INotifyPropertyChanged
    {
        readonly AddEditOrderView view;
        readonly AddOrderProxy modelProxy = new AddOrderProxy();
        public List<GoodsRow> vm { get; set; }

        private int orderId;
        Domain.Entities.Order order;

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

        public AddEditOrderPresenter(AddEditOrderView view, int orderId)
        {
            this.view = view;
            this.orderId = orderId;
            vm = new List<GoodsRow>();

            goods.AddRange(modelProxy.GoodsModel.GetAll().Where(x => x.IsActive == true));

            if (orderId >= 0)
            {
                order = modelProxy.OrderModel.GetById(orderId);

                foreach (GoodsRow row in order.GoodsList)
                {
                    vm.Add(new GoodsRow()
                    { Id = row.Id, Goods = row.Goods, Count = row.Count, Price = row.Goods.Price });
                }
            }
            else
            {
                order = new Domain.Entities.Order();
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

        private int countOfGood { get; set; }
        public int CountOfGood
        {
            get { return countOfGood; }
            set
            {
                if (countOfGood != value && value > 0)
                {
                    countOfGood = value;
                    NotifyPropertyChanged("CountOfGood");
                }
            }
        }

        public double TotalCost
        {
            get { return CalculateOrderCost(); }
        }

        private string message { get; set; }
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
            GoodsRow item = new GoodsRow() {Goods = SelectedGood, Count = CountOfGood };
            vm.Add(new GoodsRow() { Goods = item.Goods, Count = item.Count, Price = item.Goods.Price });
            order.GoodsList.Add(item);
        }

        public void AddComment (Comment value)
        {
            order.Comments.Add(value);
        }

        private double CalculateOrderCost()
        {
            double result = 0;

            foreach (GoodsRow row in order.GoodsList)
            {
                if (row.IsActive)
                {
                    result += row.TotalPrice;
                }
            }
            return result;
        }

        public void SetIsActive(int id)
        {
            order.GoodsList.ToList()[id].IsActive = !order.GoodsList.ToList()[id].IsActive;
        }

        public void Save()
        {
            if (order.Id > 0)
            {
                modelProxy.OrderModel.Update(order);
                MessageBox.Show("Заказ обновлен", buttons: MessageBoxButtons.OK, caption: "Уведомление");
            }
            else
            {
                modelProxy.OrderModel.Add(order);
                MessageBox.Show("Заказ добавлен", buttons: MessageBoxButtons.OK, caption: "Уведомление");
            }
        }

        public void SaveAndNew()
        {
            Save();

            order = new Domain.Entities.Order();

            view.Close();
            var form = new AddEditOrderView();
            form.MdiParent = ContosoUI.MainView.ActiveForm;
            form.Show();
        }
    }
}
