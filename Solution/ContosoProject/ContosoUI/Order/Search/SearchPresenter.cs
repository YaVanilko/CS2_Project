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
        public List<SearchViewModel> viewModel = new List<SearchViewModel>();
        readonly IOrderRepository orderModel = new OrderDao();
        readonly IOrderStatusRepository orderStatusModel = new OrderStatusDao();
        List<Domain.Entities.Order> ordersList = new List<Domain.Entities.Order>();
        List<SearchViewModel> vm = new List<SearchViewModel>();
        public List<string> Statuses = new List<string>();
 
        public SearchPresenter(SearchView view)
        {
            this.view = view;
            Statuses = orderStatusModel.GetAll().Select(x => x.Status).Distinct().ToList();
            Statuses.Add("Все статусы");
        }

        public void SelectOrdersByStatus(string status)
        {
            int index = 0;
            if (status == "Все статусы")
            {
                ordersList = orderModel.GetAll().ToList();
                viewModel.Clear();
                foreach (var order in ordersList)
                {
                    if (index < order.goodsList.Count)
                    {
                        viewModel.Add(new SearchViewModel()
                        {
                            Status = order.Status.Status,
                            Customer = order.Customer,
                            countOfGoods = order.goodsList[index].Count,
                            TotalCost = order.TotalCost,
                            countOfComments = order.comments.Count
                        });
                    }
                }
            }
            else if (Statuses.Contains(status))
            {
                ordersList = orderModel.GetOrderByStatus(status).ToList();
                viewModel.Clear();
                foreach (var order in ordersList)
                {
                    if (index < order.goodsList.Count)
                    {
                        viewModel.Add(new SearchViewModel()
                        {
                            Status = order.Status.Status,
                            Customer = order.Customer,
                            countOfGoods = order.goodsList[0].Count,
                            TotalCost = order.TotalCost,
                            countOfComments = order.comments.Count
                        });
                    }
                }
            }
        }
}

    public class SearchViewModel
    {
        public string Status { get; set; }
        public Customer Customer { get; set; }
        public int countOfGoods { get; set; }
        public double TotalCost { get; set; }
        public int countOfComments { get; set; }
    }
}
