using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace ContosoUI.Users.Edit
{
    public partial class UserEditForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        UserEditPresenter presenter;
        public event EventHandler SaveBtnClick;

        public string OldPassword { get { return OldPasswordTextEdit.Text; } }
        public string NewPassword { get { return NewPasswordTextEdit.Text; } }


        public UserEditForm()
        {
            InitializeComponent();
            presenter = new UserEditPresenter(this);
            oldPasswordLayoutControlItem.HideToCustomization();
        }
        public UserEditForm(int id)
        {
            InitializeComponent();
            presenter = new UserEditPresenter(this, id);
            loginTextEdit.ReadOnly = true;

            if (Program.AuthUser.Role.Permissions.Any(x=> x.Type == Domain.PermissionType.EditUser))
            {
                oldPasswordLayoutControlItem.HideToCustomization();
            }
        }

        private void UserEditForm_Load(object sender, EventArgs e)
        {
            this.userEditBindingSource.DataSource = presenter;

            FirstNameTextEdit.DataBindings.Add("EditValue", userEditBindingSource, "FirstName");
            LastNameTextEdit.DataBindings.Add("EditValue", userEditBindingSource, "LastName");
            MiddleNameTextEdit.DataBindings.Add("EditValue", userEditBindingSource, "MiddleName");
            loginTextEdit.DataBindings.Add("EditValue", userEditBindingSource, "Login");

            SelectRoleComboBox.DataBindings.Add("EditValue", userEditBindingSource, "Role");
            SelectRoleComboBox.Properties.Items.AddRange(presenter.AllRoles);

            ConfimPasswordTextEdit.DataBindings.Add("EditValue", userEditBindingSource, "Password");
        }

        internal void AsPasswordChange()
        {
            this.contactInfoGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        private void saveEditButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (loginTextEdit.Text!=String.Empty&&NewPasswordTextEdit.Text==ConfimPasswordTextEdit.Text)
            {
                userEditBindingSource.EndEdit();
                SaveBtnClick.Invoke(sender, e);
            }
            else
            {
                MessageBox.Show("Логин не введен или пароли не совпадают.", "Ошибка!");
            }
        }
    }
}