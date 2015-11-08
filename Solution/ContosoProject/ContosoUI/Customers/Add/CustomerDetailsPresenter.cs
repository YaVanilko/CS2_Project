using ContosoUI.Presenter;
using Data.EFData;
using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.Customers.Add
{
    public class CustomerDetailsPresenter : BasePresenter
    {
        readonly CustomerDetailsViev view;
        readonly ICustomerRepository model = new CustomerDao();
        Customer customer;
        public List<Domain.Entities.Order> Orders { get { return customer.Orders.ToList(); } set { } }
        public List<Comment> Comments { get { return customer.Comments.ToList(); } set { } }
        public CustomerDetailsPresenter(CustomerDetailsViev view, int id)
        {
            this.view = view;
            if (id < 0)
            {
                customer = new Customer();
            }
            else
            {
                customer = model.GetById(id);
            }
        }
        public string FirstName
        {
            get { return customer.PersonalInfo.FirstName; }
            set
            {
                if (customer.PersonalInfo.FirstName != value)
                {
                    customer.PersonalInfo.FirstName = value;
                    NotifyPropertyChanged("FirstName");
                }
            }
        }
        public string LastName
        {
            get { return customer.PersonalInfo.LastName; }
            set
            {
                if (customer.PersonalInfo.LastName != value)
                {
                    customer.PersonalInfo.LastName = value;
                    NotifyPropertyChanged("LastName");
                }
            }
        }
        public string MiddleName
        {
            get { return customer.PersonalInfo.MiddleName; }
            set
            {
                if (customer.PersonalInfo.MiddleName != value)
                {
                    customer.PersonalInfo.MiddleName = value;
                    NotifyPropertyChanged("MiddleName");
                }
            }
        }
        public string City
        {
            get { return customer.Contacts.City; }
            set
            {
                if (customer.Contacts.City != value)
                {
                    customer.Contacts.City = value;
                    NotifyPropertyChanged("City");
                }
            }
        }
        public string Address
        {
            get { return customer.Contacts.Adress; }
            set
            {
                if (customer.Contacts.Adress != value)
                {
                    customer.Contacts.Adress = value;
                    NotifyPropertyChanged("Address");
                }
            }
        }
        public string Telephone
        {
            get { return customer.Contacts.Telephone; }
            set
            {
                if (customer.Contacts.Telephone != value)
                {
                    customer.Contacts.Telephone = value;
                    NotifyPropertyChanged("Telephone");
                }
            }
        }
        public string Email
        {
            get { return customer.Contacts.Email; }
            set
            {
                if (customer.Contacts.Email != value)
                {
                    customer.Contacts.Email = value;
                    NotifyPropertyChanged("Email");
                }
            }
        }
        public bool IsActive
        {
            get { return customer.IsActive; }
            set { customer.IsActive = value;
            NotifyPropertyChanged("IsActive");
            }
        }
        private string currentComment = string.Empty;
        public string CurentComment
        {
            get { return currentComment; }
            set
            {
                if (currentComment != value)
                {
                    currentComment = value;
                    
                }NotifyPropertyChanged("CurentComment");
            }
        }

        public void Save()
        {
            if (Validate())
            {
                if (!string.IsNullOrWhiteSpace(currentComment))
                {
                    customer.Comments.Add(new Comment() { Message = currentComment, Type = CommentType.Customer });
                    currentComment = string.Empty;
                }
                if (customer.Id > 0)
                {
                    model.Update(this.customer);
                }
                else
                {
                    model.Add(customer);
                }
                NotifyPropertyChanged("Save");
            }
        }
        public void SaveAndNew()
        {
            this.Save();
            customer = new Customer();
            NotifyPropertyChanged("New Customer");
        }
        bool Validate()
        {
            bool isValid = true;
            if (customer.PersonalInfo.FirstName == null 
                || customer.PersonalInfo.LastName == null
                || customer.Contacts.Adress == null
                || customer.Contacts.City == null
                || customer.Contacts.Telephone == null)
            {
                view.ShowValidationDialog("Не заполнены обязательные поля в форме!", "Предупреждение");
                isValid = false;
            }
            if (!customer.IsActive)
	        {
                bool result = view.ShowValidationDialog("Вы уверенны, что хотите деактивировать роль пользователя? После деактивации роль будет удалена из списка!", "Предупреждение");
                if (!result)
                {
                    isValid = false;
                }
	        }
            return isValid; 
        }
    }
}
