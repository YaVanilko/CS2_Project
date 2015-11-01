using ContosoUI.Order.Search;
using Domain.DAO;
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
        readonly IOrderRepository model = new Data.DumbData.OrderDao();
        List<Domain.Entities.Order> ordersList = new List<Domain.Entities.Order>();
        List<SearchViewModel> vm = new List<SearchViewModel>();
        public List<string> Statuses = new List<string>();
 
        public SearchPresenter(SearchView view)
        {
            this.view = view;
            Statuses = model.GetAll().Select(x => x.Status.Status).Distinct().ToList();
        }
}

    public class SearchViewModel
    {
        public OrderStatus Status { get; set; }
        public Customer Customer { get; set; }
        public int countOfGoods { get; set; }
        public double TotalCost { get; set; }
        public int countOfComments { get; set; }
    }
}
