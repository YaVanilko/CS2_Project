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
            this.MiddleNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.LastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.FirstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.OldPasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.loginTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NewPasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ConfimPasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SelectRoleComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.customerGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.personalInfoGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.contactInfoGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lastNameItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.middleNameItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.saveOrEditribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.saveEditButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.saveAndNewButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.UserEditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MiddleNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OldPasswordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewPasswordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfimPasswordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectRoleComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalInfoGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactInfoGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleNameItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserEditBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.MiddleNameTextEdit);
            this.layoutControl1.Controls.Add(this.LastNameTextEdit);
            this.layoutControl1.Controls.Add(this.FirstNameTextEdit);
            this.layoutControl1.Controls.Add(this.OldPasswordTextEdit);
            this.layoutControl1.Controls.Add(this.loginTextEdit);
            this.layoutControl1.Controls.Add(this.NewPasswordTextEdit);
            this.layoutControl1.Controls.Add(this.ConfimPasswordTextEdit);
            this.layoutControl1.Controls.Add(this.SelectRoleComboBox);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 143);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(626, 69, 631, 398);
            this.layoutControl1.Root = this.customerGroup;
            this.layoutControl1.Size = new System.Drawing.Size(953, 522);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // MiddleNameTextEdit
            // 
            this.MiddleNameTextEdit.Location = new System.Drawing.Point(438, 138);
            this.MiddleNameTextEdit.Name = "MiddleNameTextEdit";
            this.MiddleNameTextEdit.Properties.Mask.EditMask = "\\p{L}+";
            this.MiddleNameTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.MiddleNameTextEdit.Properties.Mask.ShowPlaceHolders = false;
            this.MiddleNameTextEdit.Size = new System.Drawing.Size(491, 20);
            this.MiddleNameTextEdit.StyleController = this.layoutControl1;
            this.MiddleNameTextEdit.TabIndex = 6;
            // 
            // LastNameTextEdit
            // 
            this.LastNameTextEdit.Location = new System.Drawing.Point(438, 98);
            this.LastNameTextEdit.Name = "LastNameTextEdit";
            this.LastNameTextEdit.Properties.Mask.EditMask = "\\p{L}+";
            this.LastNameTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.LastNameTextEdit.Properties.Mask.ShowPlaceHolders = false;
            this.LastNameTextEdit.Size = new System.Drawing.Size(491, 20);
            this.LastNameTextEdit.StyleController = this.layoutControl1;
            this.LastNameTextEdit.TabIndex = 5;
            // 
            // FirstNameTextEdit
            // 
            this.FirstNameTextEdit.Location = new System.Drawing.Point(438, 58);
            this.FirstNameTextEdit.Name = "FirstNameTextEdit";
            this.FirstNameTextEdit.Properties.Mask.EditMask = "\\p{L}+";
            this.FirstNameTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.FirstNameTextEdit.Properties.Mask.ShowPlaceHolders = false;
            this.FirstNameTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.FirstNameTextEdit.Size = new System.Drawing.Size(491, 20);
            this.FirstNameTextEdit.StyleController = this.layoutControl1;
            this.FirstNameTextEdit.TabIndex = 4;
            // 
            // OldPasswordTextEdit
            // 
            this.OldPasswordTextEdit.Location = new System.Drawing.Point(24, 98);
            this.OldPasswordTextEdit.Name = "OldPasswordTextEdit";
            this.OldPasswordTextEdit.Properties.Mask.EditMask = "\\p{L}+";
            this.OldPasswordTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.OldPasswordTextEdit.Properties.Mask.ShowPlaceHolders = false;
            this.OldPasswordTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.OldPasswordTextEdit.Size = new System.Drawing.Size(386, 20);
            this.OldPasswordTextEdit.StyleController = this.layoutControl1;
            this.OldPasswordTextEdit.TabIndex = 4;
            // 
            // loginTextEdit
            // 
            this.loginTextEdit.Location = new System.Drawing.Point(24, 58);
            this.loginTextEdit.Name = "loginTextEdit";
            this.loginTextEdit.Properties.AllowFocused = false;
            this.loginTextEdit.Properties.Mask.EditMask = "\\p{L}+";
            this.loginTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.loginTextEdit.Properties.Mask.ShowPlaceHolders = false;
            this.loginTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.loginTextEdit.Size = new System.Drawing.Size(386, 20);
            this.loginTextEdit.StyleController = this.layoutControl1;
            this.loginTextEdit.TabIndex = 4;
            // 
            // NewPasswordTextEdit
            // 
            this.NewPasswordTextEdit.Location = new System.Drawing.Point(24, 138);
            this.NewPasswordTextEdit.Name = "NewPasswordTextEdit";
            this.NewPasswordTextEdit.Properties.Mask.EditMask = "\\p{L}+";
            this.NewPasswordTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.NewPasswordTextEdit.Properties.Mask.ShowPlaceHolders = false;
            this.NewPasswordTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.NewPasswordTextEdit.Size = new System.Drawing.Size(386, 20);
            this.NewPasswordTextEdit.StyleController = this.layoutControl1;
            this.NewPasswordTextEdit.TabIndex = 4;
            // 
            // ConfimPasswordTextEdit
            // 
            this.ConfimPasswordTextEdit.Location = new System.Drawing.Point(24, 178);
            this.ConfimPasswordTextEdit.Name = "ConfimPasswordTextEdit";
            this.ConfimPasswordTextEdit.Properties.Mask.EditMask = "\\p{L}+";
            this.ConfimPasswordTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.ConfimPasswordTextEdit.Properties.Mask.ShowPlaceHolders = false;
            this.ConfimPasswordTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ConfimPasswordTextEdit.Size = new System.Drawing.Size(386, 20);
            this.ConfimPasswordTextEdit.StyleController = this.layoutControl1;
            this.ConfimPasswordTextEdit.TabIndex = 4;
            // 
            // SelectRoleComboBox
            // 
            this.SelectRoleComboBox.Location = new System.Drawing.Point(438, 178);
            this.SelectRoleComboBox.Name = "SelectRoleComboBox";
            this.SelectRoleComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SelectRoleComboBox.Size = new System.Drawing.Size(491, 20);
            this.SelectRoleComboBox.StyleController = this.layoutControl1;
            this.SelectRoleComboBox.TabIndex = 4;
            // 
            // customerGroup
            // 
            this.customerGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.customerGroup.GroupBordersVisible = false;
            this.customerGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.personalInfoGroup,
            this.contactInfoGroup});
            this.customerGroup.Location = new System.Drawing.Point(0, 0);
            this.customerGroup.Name = "Root";
            this.customerGroup.Size = new System.Drawing.Size(953, 522);
            this.customerGroup.TextVisible = false;
            // 
            // personalInfoGroup
            // 
            this.personalInfoGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.personalInfoGroup.Location = new System.Drawing.Point(0, 0);
            this.personalInfoGroup.Name = "personalInfoGroup";
            this.personalInfoGroup.Size = new System.Drawing.Size(414, 502);
            this.personalInfoGroup.Text = "Персональные данные";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.OldPasswordTextEdit;
            this.layoutControlItem3.CustomizationFormText = "Имя";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(390, 40);
            this.layoutControlItem3.Text = "Старый пароль";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.loginTextEdit;
            this.layoutControlItem4.CustomizationFormText = "Имя";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(390, 40);
            this.layoutControlItem4.Text = "Логин";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.NewPasswordTextEdit;
            this.layoutControlItem5.CustomizationFormText = "Имя";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(390, 40);
            this.layoutControlItem5.Text = "Новый пароль";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.ConfimPasswordTextEdit;
            this.layoutControlItem6.CustomizationFormText = "Имя";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(390, 340);
            this.layoutControlItem6.Text = "Подтвердите Пароль";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(109, 13);
            // 
            // contactInfoGroup
            // 
            this.contactInfoGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lastNameItem,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.middleNameItem});
            this.contactInfoGroup.Location = new System.Drawing.Point(414, 0);
            this.contactInfoGroup.Name = "contactInfoGroup";
            this.contactInfoGroup.Size = new System.Drawing.Size(519, 502);
            this.contactInfoGroup.Text = "Контактные данные";
            // 
            // lastNameItem
            // 
            this.lastNameItem.Control = this.LastNameTextEdit;
            this.lastNameItem.Location = new System.Drawing.Point(0, 40);
            this.lastNameItem.Name = "lastNameItem";
            this.lastNameItem.Size = new System.Drawing.Size(495, 40);
            this.lastNameItem.Text = "Фамилия";
            this.lastNameItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.lastNameItem.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.FirstNameTextEdit;
            this.layoutControlItem2.CustomizationFormText = "Имя";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(495, 40);
            this.layoutControlItem2.Text = "Имя";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.SelectRoleComboBox;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(495, 340);
            this.layoutControlItem1.Text = "Роль";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(109, 13);
            // 
            // middleNameItem
            // 
            this.middleNameItem.Control = this.MiddleNameTextEdit;
            this.middleNameItem.Location = new System.Drawing.Point(0, 80);
            this.middleNameItem.Name = "middleNameItem";
            this.middleNameItem.Size = new System.Drawing.Size(495, 40);
            this.middleNameItem.Text = "Отчество";
            this.middleNameItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.middleNameItem.TextSize = new System.Drawing.Size(109, 13);
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
            this.saveOrEditribbonPageGroup.ItemLinks.Add(this.saveAndNewButtonItem);
            this.saveOrEditribbonPageGroup.Name = "saveOrEditribbonPageGroup";
            this.saveOrEditribbonPageGroup.Text = "Сохранение";
            // 
            // saveEditButtonItem
            // 
            this.saveEditButtonItem.Caption = "Сохранить";
            this.saveEditButtonItem.Id = 1;
            this.saveEditButtonItem.ImageUri.Uri = "Save";
            this.saveEditButtonItem.Name = "saveEditButtonItem";
            // 
            // saveAndNewButtonItem
            // 
            this.saveAndNewButtonItem.Caption = "Сохранить/Создать";
            this.saveAndNewButtonItem.Id = 2;
            this.saveAndNewButtonItem.ImageUri.Uri = "SaveAndNew";
            this.saveAndNewButtonItem.Name = "saveAndNewButtonItem";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.saveEditButtonItem,
            this.saveAndNewButtonItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.ribbonControl1.Size = new System.Drawing.Size(953, 143);
            // 
            // UserEditBindingSource
            // 
            this.UserEditBindingSource.DataSource = typeof(ContosoUI.Users.Edit.UserEditPresenter);
            // 
            // UserEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 665);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.MinimumSize = new System.Drawing.Size(690, 550);
            this.Name = "UserEditForm";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Заказчик";
            this.Load += new System.EventHandler(this.UserEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MiddleNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OldPasswordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewPasswordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfimPasswordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectRoleComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalInfoGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactInfoGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleNameItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserEditBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup customerGroup;
        private DevExpress.XtraEditors.TextEdit MiddleNameTextEdit;
        private DevExpress.XtraEditors.TextEdit LastNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup personalInfoGroup;
        private DevExpress.XtraLayout.LayoutControlItem lastNameItem;
        private DevExpress.XtraLayout.LayoutControlItem middleNameItem;
        private DevExpress.XtraLayout.LayoutControlGroup contactInfoGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup saveOrEditribbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem saveEditButtonItem;
        private DevExpress.XtraBars.BarButtonItem saveAndNewButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit FirstNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit OldPasswordTextEdit;
        private DevExpress.XtraEditors.TextEdit loginTextEdit;
        private DevExpress.XtraEditors.TextEdit NewPasswordTextEdit;
        private DevExpress.XtraEditors.TextEdit ConfimPasswordTextEdit;
        private DevExpress.XtraEditors.ComboBoxEdit SelectRoleComboBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.BindingSource UserEditBindingSource;
        
    }
}