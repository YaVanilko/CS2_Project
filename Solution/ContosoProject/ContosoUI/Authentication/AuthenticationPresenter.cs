using ContosoUI.Users.Edit;
using Data.EFData;
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
        User user = null;
        public User User { get { return this.user; } }

        public AuthenticationPresenter(AuthenticationForm view)
        {
            this.model = new UserDao();
            this.view = view;
            this.view.OkButtonClick += new EventHandler(OkButtonClickHendler);
        }
        
        void OkButtonClickHendler(object sender, System.EventArgs e)
        
        {
            if (model.TryFindByLoginPassword(out this.user, view.Login, view.Password.ToMD5()))
            {
                if (user.IsActive)
                {
                    view.DialogResult = DialogResult.OK;
                    view.Close();
                }
                else
                {
                    view.UserIsNotActiveDialog();
                    view.FieldsReset();
                }
                
            }
            else
            {
                view.AccessDenyDialog(); 
                view.PasswordReset();
            }
        }

    }
}


