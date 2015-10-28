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
            this.UserEditBindingSource.DataSource = presenter;

            FirstNameTextEdit.DataBindings.Add("EditValue", UserEditBindingSource, "FirstName");
            LastNameTextEdit.DataBindings.Add("EditValue", UserEditBindingSource, "LastName");
            MiddleNameTextEdit.DataBindings.Add("EditValue", UserEditBindingSource, "MiddleName");
            loginTextEdit.DataBindings.Add("EditValue", UserEditBindingSource, "Login");

            SelectRoleComboBox.DataBindings.Add("EditValue", UserEditBindingSource, "Role");
            SelectRoleComboBox.Properties.Items.AddRange(presenter.AllRoles);
        }
    }
}