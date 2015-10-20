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
    class CustomersListPresenter
    {
        readonly CustomersListView view;
        readonly ICustomerRepository model = new CustomerDao();
        readonly IContactInfoRepository contactModel = new ContactsInfoDao();
        public List<CustomersListViewModel> viewModel= new List<CustomersListViewModel>();
        private List<Customer> customers = new List<Customer>();
        private List<string> cities = new List<string>();
        public List<Customer> Customers { get { return customers; } set { } }
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
                viewModel.Clear();
                foreach (var customer in customers)
                {
                    viewModel.Add(new CustomersListViewModel() {
                        LastName = customer.PersonalInfo.LastName,
                        FirstName = customer.PersonalInfo.FirstName,
                        MiddleName = customer.PersonalInfo.MiddleName,
                        Address = customer.Contacts.Adress,
                        City = customer.Contacts.City,
                        Telephone = customer.Contacts.Telephone,
                        Email = customer.Contacts.Email,
                        CounOrders = customer.Orders.Count,
                        SumOrders = customer.Orders.Sum(x => x.TotalCost)
                    });
                }
            }
            else
            {
                customers = model.GetCustomersByCity(city).ToList();
                viewModel.Clear();
                foreach (var customer in customers)
                {
                    viewModel.Add(new CustomersListViewModel()
                    {
                        LastName = customer.PersonalInfo.LastName,
                        FirstName = customer.PersonalInfo.FirstName,
                        MiddleName = customer.PersonalInfo.MiddleName,
                        Address = customer.Contacts.Adress,
                        City = customer.Contacts.City,
                        Telephone = customer.Contacts.Telephone,
                        Email = customer.Contacts.Email,
                        CounOrders = customer.Orders.Count,
                        SumOrders = customer.Orders.Sum(x => x.TotalCost)
                    });
                }
            }
        }
    }
}
