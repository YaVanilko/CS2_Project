using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ContosoUI.Authentication;

namespace ContosoUI.Authentication
{
    public partial class AuthenticationForm : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler OkButtonClick = null;
        public AuthenticationPresenter presenter = null;
        public string Login { get { return LoginTextEdit.Text; } }
        public string Password { get { return PasswordEdit.Text; } }
        public AuthenticationForm()
        {
            InitializeComponent();
            presenter = new AuthenticationPresenter(this);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (LoginTextEdit.Text==""||PasswordEdit.Text=="")
            {
                MessageBox.Show("Введите данные", "Ошибка!");
            }
            else
            {
                OkButtonClick.Invoke(sender, e);
            }
        }

        private void LoginTextEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PasswordEdit.Select();
            }
        }

        private void PasswordEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OkButton_Click(sender, e);
            }
        }

        public void PasswordReset()
        {
            PasswordEdit.Text = String.Empty;
        }

    }
}