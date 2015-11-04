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
        public event EventHandler PasswordChange;

        public string OldPassword { get { return OldPasswordTextEdit.Text; } }
        public string NewPassword { get { return newPasswordTextEdit.Text; } }

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

            firstNameTextEdit.DataBindings.Add("EditValue", userEditBindingSource, "FirstName");
            lastNameTextEdit.DataBindings.Add("EditValue", userEditBindingSource, "LastName");
            middleNameTextEdit.DataBindings.Add("EditValue", userEditBindingSource, "MiddleName");
            
            loginTextEdit.DataBindings.Add("EditValue", userEditBindingSource, "Login");

            selectRoleComboBox.DataBindings.Add("EditValue", userEditBindingSource, "Role");
            selectRoleComboBox.Properties.Items.AddRange(presenter.AllRoles);

            IsActiveUserCheckEdit.DataBindings.Add("EditValue", userEditBindingSource, "IsActive");
        }

        internal void AsPasswordChange()
        {
            this.contactInfoGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        private void saveEditButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (loginTextEdit.Text!=String.Empty&&
                newPasswordTextEdit.Text==ConfimPasswordTextEdit.Text&&
                firstNameTextEdit.Text != String.Empty&&
                lastNameTextEdit.Text != String.Empty&&
                middleNameTextEdit.Text != String.Empty&&
                selectRoleComboBox.SelectedItem.ToString() != null)
            {
                userEditBindingSource.EndEdit();
                if (newPasswordTextEdit.Text!=String.Empty)
                {
                    PasswordChange.Invoke(sender, e);
                }
                SaveBtnClick.Invoke(sender, e);
            }
            else
            {
                MessageBox.Show("Заполнены не все поля или пароли не совпадают.", "Ошибка!");
            }
        }

        private void loginTextEdit_Validating(object sender, CancelEventArgs e)
        {
            var length = (sender as String).Length;
            //if (length<3||length>25)
            //{
            //    e.Cancel = true;
            //    e.
            //}
        }

        private void loginTextEdit_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            MessageBox.Show("Enter a date within the current month.", "Error");
        }
    }
}