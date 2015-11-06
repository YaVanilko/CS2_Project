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
using DevExpress.XtraEditors.Controls;

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
        bool asPasswordChange = false;
        internal void AsPasswordChange()
        {
            this.personalInfoGroup.HideToCustomization();
            asPasswordChange = true;
            selectRoleComboBox.CausesValidation = false;
        }

        private void saveEditButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            isPersonalInfoModified = false;
            isPasswordModified = false;
            if (newPasswordTextEdit.Text==confimPasswordTextEdit.Text&&
                (firstNameTextEdit.Text!=String.Empty||asPasswordChange))
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
            var textEditControl = sender as DevExpress.XtraEditors.TextEdit;
            var length = textEditControl.Text.Length;
            if ((length<3||length>25)&&isPersonalInfoModified)
            {
                e.Cancel = true;              
            }
        }

        private void loginTextEdit_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = "Необходимо от 3 до 25 символов.";
        }

        private void PasswordTextEdit_Validating(object sender, CancelEventArgs e)
        {
            var textEditControl = sender as DevExpress.XtraEditors.TextEdit;
            var length = textEditControl.Text.Length;
            if ((length < 5 || length > 40)&&isPasswordModified)
            {
                e.Cancel = true;
            }
        }

        private void PasswordTextEdit_InvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = "Необходимо от 5 до 40 символов.";
        }

        private void PersonalInfoTextEdit_Validating(object sender, CancelEventArgs e)
        {
            var textEditControl = sender as DevExpress.XtraEditors.TextEdit;
            var length = textEditControl.Text.Length;
            if ((length < 2 || length > 25)&&isPersonalInfoModified)
            {
                e.Cancel = true;
            }
        }

        private void PersonalInfoTextEdit_InvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = "Необходимо от 2 до 25 символов.";
        }


        private void UserEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isPersonalInfoModified||isPasswordModified)
            {
                DialogResult dialog = MessageBox.Show("Сохраить внесенные изменения?", "Сообщение",MessageBoxButtons.YesNoCancel);
                if (dialog == System.Windows.Forms.DialogResult.Yes)
                {
                    saveEditButtonItem_ItemClick(null, null);
                }
                else if (dialog == System.Windows.Forms.DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
            }
            e.Cancel = false;
        }

        private bool isPersonalInfoModified = false;
        private bool isPasswordModified = false;

        private void AnyTextEdit_Modified(object sender, EventArgs e)
        {
            isPersonalInfoModified = true;
        }

        private void AnyPasswordTextEdit_Modified(object sender, EventArgs e)
        {
            isPasswordModified = true;
        }

        private void selectRoleComboBox_Validating(object sender, CancelEventArgs e)
        {
            var combo = sender as DevExpress.XtraEditors.ComboBoxEdit;
            if (combo.SelectedItem==null||combo.SelectedItem.ToString()==null)
            {
                e.Cancel = true;
            }
        }

    }

}