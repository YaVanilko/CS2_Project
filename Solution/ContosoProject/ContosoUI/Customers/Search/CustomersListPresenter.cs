using Data.DumbData;
using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.Customers.Search
{
    public class CustomersListPresenter
    {
        readonly CustomersListView view;
        readonly ICustomerRepository model = new CustomerDao();
        readonly IContactInfoRepository contactModel = new ContactsInfoDao();

        public List<CustomersListViewModel> vm = new List<CustomersListViewModel>();
        
        List<Customer> customers = new List<Customer>();
        public List<Customer> Customers { get { return customers; } set { } }

        List<string> cities = new List<string>();
        public List<string> Cities { get { return cities; } set { } }
        
        public CustomersListPresenter(CustomersListView view)
        {
            this.view = view;
            cities = contactModel.GetAll().Select(x => x.City).Distinct().ToList();
        }

        public void SearchCustomers(string city)
        {
            if (city == "Все города")
            {
                customers = model.GetAll().ToList();

                vm.Clear();
                foreach (var customer in customers)
                {
                    vm.Add(new CustomersListViewModel
                    {
                        lName = customer.PersonalInfo.LastName,
                        city = customer.Contacts.City,
                        qty = customer.Orders.Count,
                        sum = customer.Orders.Sum(x => x.TotalCost)
                    }
                        );
                }
            }
            else
            {
                customers = model.GetCustomersByCity(city).ToList();
            }
        }
    }

    public class CustomersListViewModel
    {
        public string lName { get; set; }
        public string fName { get; set; }
        public string mName { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public int qty { get; set; }
        public double sum { get; set; }
    }
}
