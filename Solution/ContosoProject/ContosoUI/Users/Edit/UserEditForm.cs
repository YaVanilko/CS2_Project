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
        IUserNotify notifyManager = Program.MainWiewInstance;

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

        # region Validation

        private enum ValidLength
        {
            minLogin = 3,
            maxLogin = 25,
            minPassword = 5,
            maxPassword = 40,
            minPersonalInfo = 2,
            maxPersonalInfo = 25
        }

        private void loginTextEdit_Validating(object sender, CancelEventArgs e)
        {
            var textEditControl = sender as DevExpress.XtraEditors.TextEdit;
            var length = textEditControl.Text.Length;
            if ((length < (int)ValidLength.minLogin || length > (int)ValidLength.maxLogin) && isPersonalInfoModified)
            {
                e.Cancel = true;
            }
        }
        private void loginTextEdit_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = String.Format("Необходимо от {0} до {1} символов.", (int)ValidLength.minLogin, (int)ValidLength.maxLogin);
        }

        private void PasswordTextEdit_Validating(object sender, CancelEventArgs e)
        {
            var textEditControl = sender as DevExpress.XtraEditors.TextEdit;
            var length = textEditControl.Text.Length;
            if ((length < (int)ValidLength.minPassword || length > (int)ValidLength.maxPassword) && isPasswordModified)
            {
                e.Cancel = true;
            }
        }
        private void PasswordTextEdit_InvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = String.Format("Необходимо от {0} до {1} символов.", (int)ValidLength.minPassword, (int)ValidLength.maxPassword);
        }

        private void PersonalInfoTextEdit_Validating(object sender, CancelEventArgs e)
        {
            var textEditControl = sender as DevExpress.XtraEditors.TextEdit;
            var length = textEditControl.Text.Length;
            if ((length < (int)ValidLength.minPersonalInfo || length > (int)ValidLength.maxPersonalInfo) && isPersonalInfoModified)
            {
                e.Cancel = true;
            }
        }
        private void PersonalInfoTextEdit_InvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = String.Format("Необходимо от {0} до {1} символов.", (int)ValidLength.minPersonalInfo, (int)ValidLength.maxPersonalInfo);
        }

        private void selectRoleComboBox_Validating(object sender, CancelEventArgs e)
        {
            var combo = sender as DevExpress.XtraEditors.ComboBoxEdit;
            if (combo.SelectedItem == null || combo.SelectedItem.ToString() == null)
            {
                e.Cancel = true;
            }
        }
        private void selectRoleComboBox_InvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = "Выберите роль";
        }
        # endregion 

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

        private void saveEditButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (newPasswordTextEdit.Text==confimPasswordTextEdit.Text&&
                (firstNameTextEdit.Text!=String.Empty||asPasswordChange)&&
                loginTextEdit.Text!= String.Empty)
            {
                isPersonalInfoModified = false;
                isPasswordModified = false;
                userEditBindingSource.EndEdit();
                if (newPasswordTextEdit.Text!=String.Empty)
                {
                    PasswordChange.Invoke(sender, e);
                }
                SaveBtnClick.Invoke(sender, e);
            }
            else
            {
                notifyManager.ShowError("Заполнены не все поля или пароли не совпадают.", "Ошибка!");
            }
        }

        private void UserEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isPersonalInfoModified || isPasswordModified)
            {
                if (notifyManager.ShowYesNo("Внимание, данные не сохранены!\n Вы уверены что хотите закрыть?", "Сообщение"))
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = false;
            }
        }
            
        internal void UserUpdateDialog()
        {
            notifyManager.ShowInfo("Данные обновлены.", "Сообщеие");
        }

        internal void UserAddDialog()
        {
            notifyManager.ShowInfo("Новый пользователь добавлен.", "Сообщение");
        }

        internal void WrongLoginDialog()
        {
            notifyManager.ShowError("Пользовател с таким логином уже существует.", "Ошибка!");
            isPersonalInfoModified = true;
        }

        internal void WrongPasswordDialog()
        {
            notifyManager.ShowError("Введен неверный пароль.", "Ошибка!");
            OldPasswordTextEdit.Text = String.Empty;
        }
    }

}