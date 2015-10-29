using Data.DumbData;
using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContosoUI.Authentication
{
    public class AuthenticationPresenter
    {
        IUserRepository model = null;
        AuthenticationForm view = null;
        public User user = null;

        public AuthenticationPresenter(AuthenticationForm view)
        {
            this.model = new UserDao();
            this.view = view;
            this.view.OkButtonClick += new EventHandler(OkButtonClickHendler);
        }

        void OkButtonClickHendler(object sender, System.EventArgs e)
        
        {
            if (model.FindByLoginPassword(out this.user, view.Login, view.Password))
            {
                if (user.IsActive)
                {
                    view.DialogResult = DialogResult.OK;
                    view.Close();
                }
                else
                {
                    MessageBox.Show("Извините, данный аккаунт не активен.", "Ошибка!");
                    view.FieldsReset();
                }
                
            }
            else
            {
                MessageBox.Show("Неверный логин и/или пароль", "Ошибка!");
                view.PasswordReset();
            }
        }

    }
}


