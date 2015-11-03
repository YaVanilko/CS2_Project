using ContosoUI.Order.Search;
using Domain.DAO;
using Data.DumbData;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.Order.Search
{
    class SearchPresenter
    {
        readonly SearchView view;
        public List<SearchViewModel> viewModel { get; set; } 

        readonly IOrderRepository orderModel = new OrderDao();
        readonly IOrderStatusRepository orderStatusModel = new OrderStatusDao();

        private List<Domain.Entities.Order> ordersList = new List<Domain.Entities.Order>();
        readonly List<OrderStatus> statuses = new List<OrderStatus>();

        public List<OrderStatus> StatusesList
        {
            get { return statuses; }
        }

        public SearchPresenter(SearchView view)
        {
            this.view = view;
            viewModel = new List<SearchViewModel>();
            statuses = orderStatusModel.GetAll().Distinct().ToList();
            statuses.Add(new OrderStatus("Все статусы"));
        }

        public void SelectOrdersByStatus(OrderStatus status)
        {
            if (status.Status == "Все статусы")
            {
                ordersList = orderModel.GetAll().ToList();
                viewModel.Clear();

                foreach (var order in ordersList)
                {
                        viewModel.Add(new SearchViewModel()
                        {
                            Id = order.Id,
                            Status = order.Status.Status,
                            Customer = order.Customer,
                            countOfGoods = order.GoodsList.Count,
                            TotalCost = order.TotalCost,
                            countOfComments = order.Comments.Count
                        });
                }
            }
            else
            {
                ordersList = orderModel.GetOrderByStatus(status).ToList();
                viewModel.Clear();

                foreach (var order in ordersList)
                {
                        viewModel.Add(new SearchViewModel()
                        {
                            Id = order.Id,
                            Status = order.Status.Status,
                            Customer = order.Customer,
                            countOfGoods = order.GoodsList.Count,
                            TotalCost = order.TotalCost,
                            countOfComments = order.Comments.Count
                        });
                }
            }
        }
}

    public class SearchViewModel
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public Customer Customer { get; set; }
        public int countOfGoods { get; set; }
        public double TotalCost { get; set; }
        public int countOfComments { get; set; }
    }
}
