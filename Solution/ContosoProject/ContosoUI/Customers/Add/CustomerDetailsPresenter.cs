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
        IUserNotify notifyManager = Program.MainWiewInstance;
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
            set
            {
                customer.IsActive = value;
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
                } NotifyPropertyChanged("CurentComment");
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
                    notifyManager.ShowInfo("Изменения были сохранены", "Информация");
                }
                else
                {
                    model.Add(customer);
                    notifyManager.ShowInfo("Клиент был добавлен", "Информация");
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
        #region Validation
        bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(customer.PersonalInfo.FirstName) || customer.PersonalInfo.FirstName.Count() < 2 || customer.PersonalInfo.FirstName.Count() > 25)
            {
                notifyManager.ShowWarning("Не указано имя клиента или его длина менее 2 или более 25 знаков! Проверьте правильность заполнения поля", "Предупреждение");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(customer.PersonalInfo.LastName) || customer.PersonalInfo.LastName.Count() < 2 || customer.PersonalInfo.LastName.Count() > 25)
            {
                notifyManager.ShowWarning("Не указана фамилия клиента или ее длина менее 2 или более 25 знаков! Проверьте правильность заполнения поля", "Предупреждение");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(customer.PersonalInfo.MiddleName) || customer.PersonalInfo.MiddleName.Count() < 2 || customer.PersonalInfo.LastName.Count() > 25)
            {
                notifyManager.ShowWarning("Отчество клиента состоит менее чем из 2 или более 25 знаков! Проверьте правильность заполнения поля", "Предупреждение");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(customer.Contacts.Adress) || customer.Contacts.Adress.Count() < 3 || customer.Contacts.Adress.Count() > 100)
            {
                notifyManager.ShowWarning("Не указан адрес клиента или его длина менее 3 или более 100 знаков! Поле обязательно для заполнения", "Предупреждение");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(customer.Contacts.City) || customer.Contacts.City.Count() < 3 || customer.Contacts.City.Count() > 25)
            {
                notifyManager.ShowWarning("Не указан город клиента или его длина менее 3 или более 25 знаков! Поле обязательно для заполнения", "Предупреждение");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(customer.Contacts.Telephone) || customer.Contacts.Telephone.Count() < 3 || customer.Contacts.Telephone.Count() > 15)
            {
                notifyManager.ShowWarning("Не указан номер телефона клиента или его длина менее 3 или более 15 знаков! Поле обязательно для заполнения", "Предупреждение");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(customer.Contacts.Email) || customer.Contacts.Email.Count() < 3 || customer.Contacts.Email.Count() > 40)
            {
                notifyManager.ShowWarning("E-mail клиента состоит менее чем из 3 или более 40 знаков! Проверьте правильность заполнения поля", "Предупреждение");
                isValid = false;
            }
            if (!customer.IsActive)
            {
                bool result = notifyManager.ShowYesNo("Вы уверенны, что хотите деактивировать клиента? После деактивации клиент будет удален из списка!", "Предупреждение");
                if (!result)
                {
                    customer.IsActive = true;
                    isValid = false;
                }
            }
            return isValid;
        }
        #endregion
    }
}
