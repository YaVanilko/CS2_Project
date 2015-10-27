using Data.DumbData;
using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.Users.Edit
{
    class UserEditPresenter : INotifyPropertyChanged
    {
        User user = null;
        UserEditForm view = null;
        IUserRepository model = new UserDao();


        public UserEditPresenter(UserEditForm view)
        {
            this.user = new User();
            this.view = view;   
        }
        public UserEditPresenter(UserEditForm view, int id)
        {
            this.user = model.GetById(id);
            this.view = view;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public string FirstName
        {
            get { return user.PersonalInfo.FirstName; }
            set
            {
                if (user.PersonalInfo.FirstName != value)
                {
                    user.PersonalInfo.FirstName = value;
                    NotifyPropertyChanged("FirstName");
                }
            }
        }
        public string LastName
        {
            get { return user.PersonalInfo.LastName; }
            set
            {
                if (user.PersonalInfo.LastName != value)
                {
                    user.PersonalInfo.LastName = value;
                    NotifyPropertyChanged("LastName");
                }
            }
        }
        public string MiddleName
        {
            get { return user.PersonalInfo.MiddleName; }
            set
            {
                if (user.PersonalInfo.MiddleName != value)
                {
                    user.PersonalInfo.MiddleName = value;
                    NotifyPropertyChanged("MiddleName");
                }
            }
        }

        public string Login
        {
            get { return user.Login; }
            set
            {
                if (user.Login == string.Empty)
                {
                    user.Login = value;
                    NotifyPropertyChanged("Login");
                }
            }
        }
        public string Role
        {
            get { return user.Role.Name; }
        }
    }
}
