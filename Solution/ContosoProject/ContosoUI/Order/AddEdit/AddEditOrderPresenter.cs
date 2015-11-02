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
        readonly IGoodsRepository goodsModel = new GoodDao();
        readonly IGoodsRowRepository goodsRowModel = new GoodsRowDao();
        readonly IOrderStatusRepository orderStatusModel = new OrderStatusDao();
        readonly ICommentRepository commentModel = new CommentDao();

        private int orderId;

        public List<string> statusesView = new List<string>();
        public List<string> customersView = new List<string>();
        public List<string> goodsView = new List<string>();
        public List<string> commentsView = new List<string>();

        readonly Domain.Entities.Order order;
        readonly List<Customer> allCustomers;
        readonly List<Goods> allGoods;
        readonly List<GoodsRow> goodsList;

        public event PropertyChangedEventHandler PropertyChanged;

        public AddEditOrderPresenter(AddEditOrderView view) : this(view, -1)
        {
            order = new Domain.Entities.Order();
        }

        public AddEditOrderPresenter(AddEditOrderView view, int orderId)
        {
            this.view = view;
            this.orderId = orderId;

            if (orderId > 0)
            {
                order = orderModel.GetById(orderId);
            }

            allCustomers = customerModel.GetAll().ToList();
            customersView = customerModel.GetAll().Select(x => x.PersonalInfo.LastName + " " + x.PersonalInfo.FirstName + " " + x.PersonalInfo.MiddleName).ToList();
            statusesView = orderStatusModel.GetAll().Select(x => x.Status).Distinct().ToList();
            allGoods = goodsModel.GetAll().ToList();
            goodsView = goodsModel.GetAll().Select(x => x.Name).ToList();
            goodsList = goodsRowModel.GetAll().Where(x => x.Id == orderId).ToList();

            foreach (Comment comment in order.comments)
            {
                commentsView.Add(comment.Message);
            }
        }

        public string SelectedCustomer
        {
            get { return order.Customer.ToString(); }
            set
            {
                if (order.Customer.ToString() != value)
                {
                    NotifyPropertyChanged("SelectedCustomer");
                }
            }    
        }

        public List<GoodsRow> listOFGoods
        {
            get; set;
        }

        public double TotalCost
        {
            get { return CalculateOrderCost(); }
        }

        public string SelectedStatus
        {
            get { return order.Status.Status; }
            set
            {
                if (order.Status.Status != value)
                {
                    order.Status.Status = value;
                    NotifyPropertyChanged("SelectedStatus");
                }
            }
        }

        public int CommentIndex
        {
            get; set;
        }
        public string Message
        {
            get { return order.comments[CommentIndex].Message; }
            set
            {
                if (Message != value)
                {
                    order.comments[CommentIndex].Message = value;
                    NotifyPropertyChanged("Message");
                }
            }
        }

        public Comment Comment
        {
            get { return order.comments[orderId]; }
            set
            {
                Comment.Message = Message;
                Comment.Type = CommentType.Order;
            }
        }

        public void AddNewComment(Comment value)
        {
            commentModel.Add(value);
        }

        public void UpdateCommentStorage (Comment value)
        {
            commentModel.Update(value);
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

        private double CalculateOrderCost ()
        {
            double result = 0;
            foreach (GoodsRow row in order.goodsList)
            {
                result += row.TotalPrice;
            }
            return result;
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
