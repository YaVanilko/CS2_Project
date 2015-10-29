using Data.DumbData;
using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.Order.AddEdit
{
    public class AddEditOrderPresenter : INotifyPropertyChanged
    {
        readonly AddEditOrderView view = new AddEditOrderView();
        readonly IOrderRepository orderModel = new OrderDao();
        readonly ICustomerRepository customerModel = new CustomerDao();
        readonly IGoodsRepository goodsModel = new GoodsDao();
        Domain.Entities.Order order;
        readonly List<Customer> customers;

        public event PropertyChangedEventHandler PropertyChanged;

        public AddEditOrderPresenter(AddEditOrderView view) : this(view, -1)
        {
            order = new Domain.Entities.Order();
        }

        public AddEditOrderPresenter(AddEditOrderView view, int orderId)
        {
            this.view = view;

            if (orderId > 0)
            {
                order = orderModel.GetById(orderId);
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

        public List<GoodsRow> goodsList
        {
            get { return order.goodsList; }
            set { }
        }

        public double TotalCost
        {
            get
            {
                return order.TotalCost;
            }
            set { order.TotalCost = value; }
        }

        public OrderStatus Status
        {
            get { return order.Status; }
            set { order.Status = Status; }
        }
        public List<Comment> comments
        {
            get { return order.comments; }
            set { }
        }

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }

    public class AddEditViewModel
    {
        public Customer Customer { get; set; }
        public List<GoodsRow> goodsList { get; set; }
        public double TotalCost { get; set; }
        public OrderStatus Status { get; set; }
        public List<Comment> comments { get; set; }
    }
}
