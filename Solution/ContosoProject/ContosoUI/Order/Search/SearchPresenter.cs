using Domain.DAO;
using Data.EFData;
using Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using ContosoUI.Presenter;

namespace ContosoUI.Order.Search
{
    class SearchPresenter : BasePresenter
    {
        readonly SearchView view;
        readonly List<OrderStatus> statuses;
        const string defaultStatus = "Все статусы";
        IUserNotify notifyManager = Program.MainWiewInstance;
        readonly IOrderRepository orderModel = new OrderDao();
        readonly IOrderStatusRepository orderStatusModel = new OrderStatusDao();

        public SearchPresenter(SearchView view)
        {
            this.view = view;
            orders = new List<Domain.Entities.Order>();
            statuses = orderStatusModel.GetAll().Distinct().ToList();
            statuses.Add(new OrderStatus() { Status = defaultStatus });
        }

        private List<Domain.Entities.Order> orders;
        public List<Domain.Entities.Order> OrdersList
        {
            get { return orders; }
        }

        public List<OrderStatus> StatusesList
        {
            get { return statuses; }
        }

        public void SelectOrdersByStatus(OrderStatus status)
        {
            if (status.Status == defaultStatus)
            {
                orders = orderModel.GetAll().ToList();
            }
            else if (statuses.Any(x=>x.Status == status.Status))
            {
                orders = orderModel.GetOrderByStatus(status).ToList();
            }
            else
            {
                orders = new List<Domain.Entities.Order>();
                notifyManager.ShowInfo("Не существует заказов с таким статусом", "Сообщение");
            }

            NotifyPropertyChanged("SelectOrdersByStatus");
        }
    }
}
