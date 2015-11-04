using ContosoUI.Authentication;
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
using System.Windows.Forms;

namespace ContosoUI.Users.Edit
{
    class UserEditPresenter : BasePresenter
    {
        User user = null;
        UserEditForm view = null;
        List<Role> roles = null;

        UserRoleService model = new UserRoleService();
        bool userIsFromBase = false;
        
        

        public UserEditPresenter(UserEditForm view)
        {
            this.user = new User();
            this.view = view;
            this.roles = this.model.RoleDao.GetAll().ToList();
            this.view.SaveBtnClick += new EventHandler(SaveBtnClickHandler);
            this.view.PasswordChange += new EventHandler(PasswordChangedHandler);
        }

       
        public UserEditPresenter(UserEditForm view, int id)
            : this(view)
        {
            this.user = model.UserDao.GetById(id);
            this.userIsFromBase = true;
        }
        
        private void SaveBtnClickHandler(object sender, EventArgs e)
        {
            if (userIsFromBase)
            {
                model.UserDao.Update(user);
            }
            else if (!model.UserDao.GetAll().ToList().Any(x => x.Login == this.user.Login))
            {
                model.UserDao.Add(user);
            }
            else
            {
                MessageBox.Show("Пользователь с данным логином уже существует.", "Ошибка!");
            }
        }

        private void PasswordChangedHandler(object sender, EventArgs e)
        {
            if (Program.AuthUser.Role.Permissions.Any(x => x.Type == Domain.PermissionType.EditUser) ||
                    view.OldPassword.ToMD5() == user.Password)
            {
                user.Password = view.NewPassword.ToMD5();
                if (userIsFromBase)
	            {
                    MessageBox.Show("Пароль успешно изменен.", "Сообщеие");
                }
	            }
            else
            {
                MessageBox.Show("Введен неверный пароль.", "Ошибка!");
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
                if (user.Login != string.Empty)
                {
                    user.Login = value;
                    NotifyPropertyChanged("Login");
                }
            }
        }

        public bool IsActive
        {
            get { return user.IsActive; }
            set { user.IsActive = value; }
        }

        public  Role Role
        { 
            get { return user.Role; }
            set
            {
                if (user.Role != value)
                {
                    user.Role = value;
                    NotifyPropertyChanged("Role");
                }
            }
        }

        public List<Role> AllRoles
        {
            get
            { return roles; }
        }
    }
}
