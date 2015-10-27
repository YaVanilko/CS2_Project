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
        readonly IOrderRepository model = new OrderDao();
        Domain.Entities.Order order;

        public event PropertyChangedEventHandler PropertyChanged;

        public AddEditOrderPresenter(AddEditOrderView view)
        {
            this.view = view;
        }

        public Customer Customer
        {
            get
            {
                return order.Customer;
            }

            set { order.Customer = value; }
        }

        public List<GoodsRow> goodsList
        {
            get
            {
                return order.goodsList;
            }

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
            get
            {
                return order.Status;
            }

            set { order.Status = Status; }
        }
        public List<Comment> comments
        {
            get
            {
                return order.comments;
            }

            set { }
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
