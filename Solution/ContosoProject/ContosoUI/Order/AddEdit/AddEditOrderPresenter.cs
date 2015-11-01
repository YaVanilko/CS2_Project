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
        readonly AddEditOrderView view;

        readonly IOrderRepository orderModel = new OrderDao();
        readonly ICustomerRepository customerModel = new CustomerDao();
        readonly IGoodsRepository goodsModel = new GoodsDao();

        readonly Domain.Entities.Order order;

        readonly List<Customer> customers;

        public List<Customer> AllCustomers
        {
            get
            {
                return customers;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public AddEditOrderPresenter(AddEditOrderView view) : this(view, -1)
        {
            order = new Domain.Entities.Order();
            
        }

        public AddEditOrderPresenter(AddEditOrderView view, int orderId)
        {
            this.view = view;
            customers = customerModel.GetAll().ToList();

            if (orderId > 0)
            {
                order = orderModel.GetById(orderId);
            }
        }

        public string CustomerToString
        {
            get { return order.Customer.ToString(); }
            set
            {
                if (order.Customer.ToString() != value)
                {
                    //order.Customer.ToString() = value;
                    NotifyPropertyChanged("CustomerToString");
                }
            }    
        }

        public List<GoodsRow> goodsList
        {
            get { return order.goodsList; }
            set
            {
                if (order.goodsList!= value)
                {
                    order.goodsList = value;
                    NotifyPropertyChanged("goodList");
                }
            }
        }

        public double TotalCost
        {
            get { return order.TotalCost; }
            set
            {
                NotifyPropertyChanged("TotalCost");
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
        public List<Comment> comments
        {
            get { return order.comments; }
            set
            {
                if (order.comments != value)
                {
                    order.comments = value;
                    NotifyPropertyChanged("comments");
                }
            }
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
