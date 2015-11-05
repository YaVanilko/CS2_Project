namespace ContosoUI.Users.Edit
{
    partial class UserEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

              private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.IsActiveUserCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.saveEditButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ChangePasswordBarBtn = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.saveOrEditribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.middleNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.lastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.firstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.OldPasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.loginTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.newPasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.confimPasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.selectRoleComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.userGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.authInfoGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.oldPasswordLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.loginLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.newPasswordLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.confimPasswordLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.personalInfoGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lastNameItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.middleNameItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.rol = new DevExpress.XtraLayout.LayoutControlItem();
            this.IsActiveUserLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.RoleLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.userEditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IsActiveUserCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OldPasswordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPasswordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confimPasswordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectRoleComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authInfoGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oldPasswordLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPasswordLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confimPasswordLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalInfoGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleNameItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsActiveUserLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userEditBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.IsActiveUserCheckEdit);
            this.layoutControl1.Controls.Add(this.middleNameTextEdit);
            this.layoutControl1.Controls.Add(this.lastNameTextEdit);
            this.layoutControl1.Controls.Add(this.firstNameTextEdit);
            this.layoutControl1.Controls.Add(this.OldPasswordTextEdit);
            this.layoutControl1.Controls.Add(this.loginTextEdit);
            this.layoutControl1.Controls.Add(this.newPasswordTextEdit);
            this.layoutControl1.Controls.Add(this.confimPasswordTextEdit);
            this.layoutControl1.Controls.Add(this.selectRoleComboBox);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 143);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(413, 69, 631, 398);
            this.layoutControl1.Root = this.userGroup;
            this.layoutControl1.Size = new System.Drawing.Size(953, 522);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // IsActiveUserCheckEdit
            // 
            this.IsActiveUserCheckEdit.Location = new System.Drawing.Point(306, 202);
            this.IsActiveUserCheckEdit.MenuManager = this.ribbonControl1;
            this.IsActiveUserCheckEdit.Name = "IsActiveUserCheckEdit";
            this.IsActiveUserCheckEdit.Properties.Caption = "Активен";
            this.IsActiveUserCheckEdit.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style16;
            this.IsActiveUserCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IsActiveUserCheckEdit.Size = new System.Drawing.Size(623, 22);
            this.IsActiveUserCheckEdit.StyleController = this.layoutControl1;
            this.IsActiveUserCheckEdit.TabIndex = 4;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CausesValidation = false;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.saveEditButtonItem,
            this.ChangePasswordBarBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.ribbonControl1.Size = new System.Drawing.Size(953, 143);
            // 
            // saveEditButtonItem
            // 
            this.saveEditButtonItem.Caption = "Сохранить";
            this.saveEditButtonItem.CausesValidation = true;
            this.saveEditButtonItem.Id = 1;
            this.saveEditButtonItem.ImageUri.Uri = "Save";
            this.saveEditButtonItem.Name = "saveEditButtonItem";
            this.saveEditButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveEditButtonItem_ItemClick);
            // 
            // ChangePasswordBarBtn
            // 
            this.ChangePasswordBarBtn.Caption = "Изменить пароль";
            this.ChangePasswordBarBtn.Id = 2;
            this.ChangePasswordBarBtn.Name = "ChangePasswordBarBtn";
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.saveOrEditribbonPageGroup});
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Меню";
            // 
            // saveOrEditribbonPageGroup
            // 
            this.saveOrEditribbonPageGroup.ItemLinks.Add(this.saveEditButtonItem);
            this.saveOrEditribbonPageGroup.Name = "saveOrEditribbonPageGroup";
            this.saveOrEditribbonPageGroup.Text = "Сохранение";
            // 
            // middleNameTextEdit
            // 
            this.middleNameTextEdit.Location = new System.Drawing.Point(306, 138);
            this.middleNameTextEdit.Name = "middleNameTextEdit";
            this.middleNameTextEdit.Properties.Mask.EditMask = "\\p{L}+";
            this.middleNameTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.middleNameTextEdit.Properties.Mask.ShowPlaceHolders = false;
            this.middleNameTextEdit.Size = new System.Drawing.Size(623, 20);
            this.middleNameTextEdit.StyleController = this.layoutControl1;
            this.middleNameTextEdit.TabIndex = 6;
            this.middleNameTextEdit.InvalidValue += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.PersonalInfoTextEdit_InvalidValue);
            this.middleNameTextEdit.Modified += new System.EventHandler(this.AnyTextEdit_Modified);
            this.middleNameTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.PersonalInfoTextEdit_Validating);
            // 
            // lastNameTextEdit
            // 
            this.lastNameTextEdit.Location = new System.Drawing.Point(306, 98);
            this.lastNameTextEdit.Name = "lastNameTextEdit";
            this.lastNameTextEdit.Properties.Mask.EditMask = "\\p{L}+";
            this.lastNameTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.lastNameTextEdit.Properties.Mask.ShowPlaceHolders = false;
            this.lastNameTextEdit.Size = new System.Drawing.Size(623, 20);
            this.lastNameTextEdit.StyleController = this.layoutControl1;
            this.lastNameTextEdit.TabIndex = 5;
            this.lastNameTextEdit.InvalidValue += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.PersonalInfoTextEdit_InvalidValue);
            this.lastNameTextEdit.Modified += new System.EventHandler(this.AnyTextEdit_Modified);
            this.lastNameTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.PersonalInfoTextEdit_Validating);
            // 
            // firstNameTextEdit
            // 
            this.firstNameTextEdit.Location = new System.Drawing.Point(306, 58);
            this.firstNameTextEdit.Name = "firstNameTextEdit";
            this.firstNameTextEdit.Properties.Mask.EditMask = "\\p{L}+";
            this.firstNameTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.firstNameTextEdit.Properties.Mask.ShowPlaceHolders = false;
            this.firstNameTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.firstNameTextEdit.Size = new System.Drawing.Size(623, 20);
            this.firstNameTextEdit.StyleController = this.layoutControl1;
            this.firstNameTextEdit.TabIndex = 4;
            this.firstNameTextEdit.InvalidValue += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.PersonalInfoTextEdit_InvalidValue);
            this.firstNameTextEdit.Modified += new System.EventHandler(this.AnyTextEdit_Modified);
            this.firstNameTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.PersonalInfoTextEdit_Validating);
            // 
            // OldPasswordTextEdit
            // 
            this.OldPasswordTextEdit.CausesValidation = false;
            this.OldPasswordTextEdit.Location = new System.Drawing.Point(24, 98);
            this.OldPasswordTextEdit.Name = "OldPasswordTextEdit";
            this.OldPasswordTextEdit.Properties.Mask.EditMask = "\\p{L}+";
            this.OldPasswordTextEdit.Properties.Mask.ShowPlaceHolders = false;
            this.OldPasswordTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.OldPasswordTextEdit.Properties.UseSystemPasswordChar = true;
            this.OldPasswordTextEdit.Size = new System.Drawing.Size(254, 20);
            this.OldPasswordTextEdit.StyleController = this.layoutControl1;
            this.OldPasswordTextEdit.TabIndex = 2;
            // 
            // loginTextEdit
            // 
            this.loginTextEdit.Location = new System.Drawing.Point(24, 58);
            this.loginTextEdit.Name = "loginTextEdit";
            this.loginTextEdit.Properties.Mask.EditMask = "[a-zA-Z]+";
            this.loginTextEdit.Properties.Mask.ShowPlaceHolders = false;
            this.loginTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.loginTextEdit.Size = new System.Drawing.Size(254, 20);
            this.loginTextEdit.StyleController = this.layoutControl1;
            this.loginTextEdit.TabIndex = 1;
            this.loginTextEdit.InvalidValue += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.loginTextEdit_InvalidValue);
            this.loginTextEdit.Modified += new System.EventHandler(this.AnyTextEdit_Modified);
            this.loginTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.loginTextEdit_Validating);
            // 
            // newPasswordTextEdit
            // 
            this.newPasswordTextEdit.Location = new System.Drawing.Point(24, 138);
            this.newPasswordTextEdit.Name = "newPasswordTextEdit";
            this.newPasswordTextEdit.Properties.Mask.EditMask = "\\p{L}+";
            this.newPasswordTextEdit.Properties.Mask.ShowPlaceHolders = false;
            this.newPasswordTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.newPasswordTextEdit.Properties.UseSystemPasswordChar = true;
            this.newPasswordTextEdit.Size = new System.Drawing.Size(254, 20);
            this.newPasswordTextEdit.StyleController = this.layoutControl1;
            this.newPasswordTextEdit.TabIndex = 3;
            this.newPasswordTextEdit.InvalidValue += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.PasswordTextEdit_InvalidValue);
            this.newPasswordTextEdit.Modified += new System.EventHandler(this.AnyPasswordTextEdit_Modified);
            this.newPasswordTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.PasswordTextEdit_Validating);
            // 
            // confimPasswordTextEdit
            // 
            this.confimPasswordTextEdit.Location = new System.Drawing.Point(24, 178);
            this.confimPasswordTextEdit.Name = "confimPasswordTextEdit";
            this.confimPasswordTextEdit.Properties.Mask.EditMask = "\\p{L}+";
            this.confimPasswordTextEdit.Properties.Mask.ShowPlaceHolders = false;
            this.confimPasswordTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.confimPasswordTextEdit.Properties.UseSystemPasswordChar = true;
            this.confimPasswordTextEdit.Size = new System.Drawing.Size(254, 20);
            this.confimPasswordTextEdit.StyleController = this.layoutControl1;
            this.confimPasswordTextEdit.TabIndex = 4;
            this.confimPasswordTextEdit.InvalidValue += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.PasswordTextEdit_InvalidValue);
            this.confimPasswordTextEdit.Modified += new System.EventHandler(this.AnyPasswordTextEdit_Modified);
            this.confimPasswordTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.PasswordTextEdit_Validating);
            // 
            // selectRoleComboBox
            // 
            this.selectRoleComboBox.Location = new System.Drawing.Point(306, 178);
            this.selectRoleComboBox.Name = "selectRoleComboBox";
            this.selectRoleComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.selectRoleComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.selectRoleComboBox.Size = new System.Drawing.Size(623, 20);
            this.selectRoleComboBox.StyleController = this.layoutControl1;
            this.selectRoleComboBox.TabIndex = 7;
            this.selectRoleComboBox.Modified += new System.EventHandler(this.AnyTextEdit_Modified);
            // 
            // userGroup
            // 
            this.userGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.userGroup.GroupBordersVisible = false;
            this.userGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.authInfoGroup,
            this.personalInfoGroup});
            this.userGroup.Location = new System.Drawing.Point(0, 0);
            this.userGroup.Name = "userGroup";
            this.userGroup.Size = new System.Drawing.Size(953, 522);
            this.userGroup.TextVisible = false;
            // 
            // authInfoGroup
            // 
            this.authInfoGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.oldPasswordLayoutControlItem,
            this.loginLayoutControlItem,
            this.newPasswordLayoutControlItem,
            this.confimPasswordLayoutControlItem});
            this.authInfoGroup.Location = new System.Drawing.Point(0, 0);
            this.authInfoGroup.Name = "authInfoGroup";
            this.authInfoGroup.Size = new System.Drawing.Size(282, 502);
            this.authInfoGroup.Text = "Данные авторизации";
            // 
            // oldPasswordLayoutControlItem
            // 
            this.oldPasswordLayoutControlItem.Control = this.OldPasswordTextEdit;
            this.oldPasswordLayoutControlItem.CustomizationFormText = "Имя";
            this.oldPasswordLayoutControlItem.Location = new System.Drawing.Point(0, 40);
            this.oldPasswordLayoutControlItem.Name = "oldPasswordLayoutControlItem";
            this.oldPasswordLayoutControlItem.Size = new System.Drawing.Size(258, 40);
            this.oldPasswordLayoutControlItem.Text = "Старый пароль";
            this.oldPasswordLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.oldPasswordLayoutControlItem.TextSize = new System.Drawing.Size(109, 13);
            // 
            // loginLayoutControlItem
            // 
            this.loginLayoutControlItem.Control = this.loginTextEdit;
            this.loginLayoutControlItem.CustomizationFormText = "Имя";
            this.loginLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.loginLayoutControlItem.Name = "loginLayoutControlItem";
            this.loginLayoutControlItem.Size = new System.Drawing.Size(258, 40);
            this.loginLayoutControlItem.Text = "Логин";
            this.loginLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.loginLayoutControlItem.TextSize = new System.Drawing.Size(109, 13);
            // 
            // newPasswordLayoutControlItem
            // 
            this.newPasswordLayoutControlItem.Control = this.newPasswordTextEdit;
            this.newPasswordLayoutControlItem.CustomizationFormText = "Имя";
            this.newPasswordLayoutControlItem.Location = new System.Drawing.Point(0, 80);
            this.newPasswordLayoutControlItem.Name = "newPasswordLayoutControlItem";
            this.newPasswordLayoutControlItem.Size = new System.Drawing.Size(258, 40);
            this.newPasswordLayoutControlItem.Text = "Новый пароль";
            this.newPasswordLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.newPasswordLayoutControlItem.TextSize = new System.Drawing.Size(109, 13);
            // 
            // confimPasswordLayoutControlItem
            // 
            this.confimPasswordLayoutControlItem.Control = this.confimPasswordTextEdit;
            this.confimPasswordLayoutControlItem.CustomizationFormText = "Имя";
            this.confimPasswordLayoutControlItem.Location = new System.Drawing.Point(0, 120);
            this.confimPasswordLayoutControlItem.Name = "confimPasswordLayoutControlItem";
            this.confimPasswordLayoutControlItem.Size = new System.Drawing.Size(258, 340);
            this.confimPasswordLayoutControlItem.Text = "Подтвердите Пароль";
            this.confimPasswordLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.confimPasswordLayoutControlItem.TextSize = new System.Drawing.Size(109, 13);
            // 
            // personalInfoGroup
            // 
            this.personalInfoGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lastNameItem,
            this.layoutControlItem2,
            this.middleNameItem,
            this.rol,
            this.IsActiveUserLayoutControl});
            this.personalInfoGroup.Location = new System.Drawing.Point(282, 0);
            this.personalInfoGroup.Name = "personalInfoGroup";
            this.personalInfoGroup.Size = new System.Drawing.Size(651, 502);
            this.personalInfoGroup.Text = "Личная информация";
            // 
            // lastNameItem
            // 
            this.lastNameItem.Control = this.lastNameTextEdit;
            this.lastNameItem.Location = new System.Drawing.Point(0, 40);
            this.lastNameItem.Name = "lastNameItem";
            this.lastNameItem.Size = new System.Drawing.Size(627, 40);
            this.lastNameItem.Text = "Фамилия";
            this.lastNameItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.lastNameItem.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.firstNameTextEdit;
            this.layoutControlItem2.CustomizationFormText = "Имя";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(627, 40);
            this.layoutControlItem2.Text = "Имя";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(109, 13);
            // 
            // middleNameItem
            // 
            this.middleNameItem.Control = this.middleNameTextEdit;
            this.middleNameItem.Location = new System.Drawing.Point(0, 80);
            this.middleNameItem.Name = "middleNameItem";
            this.middleNameItem.Size = new System.Drawing.Size(627, 40);
            this.middleNameItem.Text = "Отчество";
            this.middleNameItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.middleNameItem.TextSize = new System.Drawing.Size(109, 13);
            // 
            // rol
            // 
            this.rol.Control = this.selectRoleComboBox;
            this.rol.Location = new System.Drawing.Point(0, 120);
            this.rol.Name = "layoutControlItem1";
            this.rol.Size = new System.Drawing.Size(627, 40);
            this.rol.Text = "Роль";
            this.rol.TextLocation = DevExpress.Utils.Locations.Top;
            this.rol.TextSize = new System.Drawing.Size(109, 13);
            // 
            // IsActiveUserLayoutControl
            // 
            this.IsActiveUserLayoutControl.Control = this.IsActiveUserCheckEdit;
            this.IsActiveUserLayoutControl.Location = new System.Drawing.Point(0, 160);
            this.IsActiveUserLayoutControl.Name = "IsActiveUserLayoutControl";
            this.IsActiveUserLayoutControl.Size = new System.Drawing.Size(627, 300);
            this.IsActiveUserLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.IsActiveUserLayoutControl.TextVisible = false;
            // 
            // RoleLayoutControlItem
            // 
            this.RoleLayoutControlItem.Control = this.selectRoleComboBox;
            this.RoleLayoutControlItem.Location = new System.Drawing.Point(0, 120);
            this.RoleLayoutControlItem.Name = "RoleLayoutControlItem";
            this.RoleLayoutControlItem.Size = new System.Drawing.Size(627, 40);
            this.RoleLayoutControlItem.Text = "Роль";
            this.RoleLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.RoleLayoutControlItem.TextSize = new System.Drawing.Size(109, 13);
            // 
            // userEditBindingSource
            // 
            this.userEditBindingSource.DataSource = typeof(ContosoUI.Users.Edit.UserEditPresenter);
            // 
            // UserEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(953, 665);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.MinimumSize = new System.Drawing.Size(690, 550);
            this.Name = "UserEditForm";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Пользователь";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserEditForm_FormClosing);
            this.Load += new System.EventHandler(this.UserEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IsActiveUserCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OldPasswordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPasswordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confimPasswordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectRoleComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authInfoGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oldPasswordLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPasswordLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confimPasswordLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalInfoGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleNameItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsActiveUserLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userEditBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup userGroup;
        private DevExpress.XtraEditors.TextEdit middleNameTextEdit;
        private DevExpress.XtraEditors.TextEdit lastNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup authInfoGroup;
        private DevExpress.XtraLayout.LayoutControlItem lastNameItem;
        private DevExpress.XtraLayout.LayoutControlItem middleNameItem;
        private DevExpress.XtraLayout.LayoutControlGroup personalInfoGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup saveOrEditribbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem saveEditButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraLayout.LayoutControlItem RoleLayoutControlItem;
        private DevExpress.XtraEditors.TextEdit firstNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit OldPasswordTextEdit;
        private DevExpress.XtraEditors.TextEdit loginTextEdit;
        private DevExpress.XtraEditors.TextEdit newPasswordTextEdit;
        private DevExpress.XtraEditors.TextEdit confimPasswordTextEdit;
        private DevExpress.XtraEditors.ComboBoxEdit selectRoleComboBox;
        private DevExpress.XtraLayout.LayoutControlItem oldPasswordLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem loginLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem newPasswordLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem confimPasswordLayoutControlItem;
        private System.Windows.Forms.BindingSource userEditBindingSource;
        private DevExpress.XtraBars.BarButtonItem ChangePasswordBarBtn;
        private DevExpress.XtraEditors.CheckEdit IsActiveUserCheckEdit;
        private DevExpress.XtraLayout.LayoutControlItem IsActiveUserLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem rol;
        
    }
}