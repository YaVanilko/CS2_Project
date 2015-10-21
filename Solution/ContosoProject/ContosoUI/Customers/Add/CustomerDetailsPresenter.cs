using Data.DumbData;
using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.Customers.Add
{
    public class CustomerDetailsPresenter
    {
        readonly CustomerDetailsViev view;
        readonly ICustomerRepository model = new CustomerDao();
        Customer customer;
        public List<Domain.Entities.Order> Orders { get { return customer.Orders; } set { } }
        public List<Comment> Comments { get { return customer.Comments; } set { } }

        public CustomerDetailsPresenter(CustomerDetailsViev view)
        {
            this.view = view;
            customer = model.GetById(0);
        }
        public string FirstName 
        { 
            get { return customer.PersonalInfo.FirstName; }
            set { customer.PersonalInfo.FirstName = value; } 
        }
        public string LastName
        {
            get { return customer.PersonalInfo.LastName; }
            set { customer.PersonalInfo.LastName = value; }
        }
        public string MiddleName
        {
            get { return customer.PersonalInfo.MiddleName; }
            set { customer.PersonalInfo.MiddleName = value; }
        }
        public string City
        {
            get { return customer.Contacts.City; }
            set { customer.Contacts.City = value; }
        }
        public string Address
        {
            get { return customer.Contacts.Adress; }
            set { customer.Contacts.Adress = value; }
        }
        public string Telephone
        {
            get { return customer.Contacts.Telephone; }
            set { customer.Contacts.Telephone= value; }
        }
        public string Email
        {
            get { return customer.Contacts.Email; }
            set { customer.Contacts.Email = value; }
        }

    }
}
