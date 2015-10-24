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
            this.commentsListBoxControl = new DevExpress.XtraEditors.ListBoxControl();
            this.ordersGridControl = new DevExpress.XtraGrid.GridControl();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.orderNumberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderSumGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderStatusGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customerGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ordersItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.listCommentsItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.commentItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.commentMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.contactInfoGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.cityItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.cityTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.addressItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.addressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.telephoneItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.telephoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.emailItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.personalInfoGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.firstNameItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.firstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.lastNameItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.lastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.middleNameItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.middleNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.saveOrEditribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.saveEditButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.saveAndNewButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentsListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCommentsItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactInfoGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalInfoGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleNameItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.commentsListBoxControl);
            this.layoutControl1.Controls.Add(this.commentMemoEdit);
            this.layoutControl1.Controls.Add(this.ordersGridControl);
            this.layoutControl1.Controls.Add(this.emailTextEdit);
            this.layoutControl1.Controls.Add(this.telephoneTextEdit);
            this.layoutControl1.Controls.Add(this.addressTextEdit);
            this.layoutControl1.Controls.Add(this.cityTextEdit);
            this.layoutControl1.Controls.Add(this.middleNameTextEdit);
            this.layoutControl1.Controls.Add(this.lastNameTextEdit);
            this.layoutControl1.Controls.Add(this.firstNameTextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(626, 69, 631, 398);
            this.layoutControl1.Root = this.customerGroup;
            this.layoutControl1.Size = new System.Drawing.Size(953, 665);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // commentsListBoxControl
            // 
            this.commentsListBoxControl.Location = new System.Drawing.Point(12, 457);
            this.commentsListBoxControl.Name = "commentsListBoxControl";
            this.commentsListBoxControl.Size = new System.Drawing.Size(929, 86);
            this.commentsListBoxControl.StyleController = this.layoutControl1;
            this.commentsListBoxControl.TabIndex = 15;
            // 
            // ordersGridControl
            // 
            this.ordersGridControl.DataSource = this.orderBindingSource;
            this.ordersGridControl.Location = new System.Drawing.Point(12, 190);
            this.ordersGridControl.MainView = this.gridView1;
            this.ordersGridControl.Name = "ordersGridControl";
            this.ordersGridControl.Size = new System.Drawing.Size(929, 247);
            this.ordersGridControl.TabIndex = 11;
            this.ordersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Domain.Entities.Order);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.orderNumberGridColumn,
            this.orderSumGridColumn,
            this.orderStatusGridColumn});
            this.gridView1.GridControl = this.ordersGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // orderNumberGridColumn
            // 
            this.orderNumberGridColumn.Caption = "Номер заказа";
            this.orderNumberGridColumn.FieldName = "Id";
            this.orderNumberGridColumn.Name = "orderNumberGridColumn";
            this.orderNumberGridColumn.Visible = true;
            this.orderNumberGridColumn.VisibleIndex = 0;
            this.orderNumberGridColumn.Width = 133;
            // 
            // orderSumGridColumn
            // 
            this.orderSumGridColumn.Caption = "Сумма заказа";
            this.orderSumGridColumn.FieldName = "TotalCost";
            this.orderSumGridColumn.Name = "orderSumGridColumn";
            this.orderSumGridColumn.Visible = true;
            this.orderSumGridColumn.VisibleIndex = 1;
            this.orderSumGridColumn.Width = 248;
            // 
            // orderStatusGridColumn
            // 
            this.orderStatusGridColumn.Caption = "Статус заказа";
            this.orderStatusGridColumn.FieldName = "Status.Status";
            this.orderStatusGridColumn.Name = "orderStatusGridColumn";
            this.orderStatusGridColumn.Visible = true;
            this.orderStatusGridColumn.VisibleIndex = 2;
            this.orderStatusGridColumn.Width = 251;
            // 
            // customerGroup
            // 
            this.customerGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.customerGroup.GroupBordersVisible = false;
            this.customerGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.personalInfoGroup,
            this.contactInfoGroup,
            this.ordersItem,
            this.commentItem,
            this.listCommentsItem});
            this.customerGroup.Location = new System.Drawing.Point(0, 0);
            this.customerGroup.Name = "Root";
            this.customerGroup.Size = new System.Drawing.Size(953, 665);
            this.customerGroup.TextVisible = false;
            // 
            // ordersItem
            // 
            this.ordersItem.Control = this.ordersGridControl;
            this.ordersItem.Location = new System.Drawing.Point(0, 162);
            this.ordersItem.Name = "ordersItem";
            this.ordersItem.Size = new System.Drawing.Size(933, 267);
            this.ordersItem.Text = "Список заказов";
            this.ordersItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.ordersItem.TextSize = new System.Drawing.Size(105, 13);
            // 
            // listCommentsItem
            // 
            this.listCommentsItem.Control = this.commentsListBoxControl;
            this.listCommentsItem.Location = new System.Drawing.Point(0, 429);
            this.listCommentsItem.Name = "listCommentsItem";
            this.listCommentsItem.Size = new System.Drawing.Size(933, 106);
            this.listCommentsItem.Text = "Список коментариев";
            this.listCommentsItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.listCommentsItem.TextSize = new System.Drawing.Size(105, 13);
            // 
            // commentItem
            // 
            this.commentItem.Control = this.commentMemoEdit;
            this.commentItem.Location = new System.Drawing.Point(0, 535);
            this.commentItem.Name = "commentItem";
            this.commentItem.Size = new System.Drawing.Size(933, 110);
            this.commentItem.Text = "Ваш коментарий";
            this.commentItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.commentItem.TextSize = new System.Drawing.Size(105, 13);
            // 
            // commentMemoEdit
            // 
            this.commentMemoEdit.Location = new System.Drawing.Point(12, 563);
            this.commentMemoEdit.Name = "commentMemoEdit";
            this.commentMemoEdit.Size = new System.Drawing.Size(929, 90);
            this.commentMemoEdit.StyleController = this.layoutControl1;
            this.commentMemoEdit.TabIndex = 12;
            // 
            // contactInfoGroup
            // 
            this.contactInfoGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.cityItem,
            this.addressItem,
            this.telephoneItem,
            this.emailItem});
            this.contactInfoGroup.Location = new System.Drawing.Point(466, 0);
            this.contactInfoGroup.Name = "contactInfoGroup";
            this.contactInfoGroup.Size = new System.Drawing.Size(467, 162);
            this.contactInfoGroup.Text = "Контактные данные";
            // 
            // cityItem
            // 
            this.cityItem.Control = this.cityTextEdit;
            this.cityItem.Location = new System.Drawing.Point(0, 0);
            this.cityItem.Name = "cityItem";
            this.cityItem.Size = new System.Drawing.Size(443, 40);
            this.cityItem.Text = "Город";
            this.cityItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.cityItem.TextSize = new System.Drawing.Size(105, 13);
            // 
            // cityTextEdit
            // 
            this.cityTextEdit.Location = new System.Drawing.Point(490, 58);
            this.cityTextEdit.Name = "cityTextEdit";
            this.cityTextEdit.Properties.Mask.EditMask = "\\p{L}+";
            this.cityTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.cityTextEdit.Properties.Mask.ShowPlaceHolders = false;
            this.cityTextEdit.Size = new System.Drawing.Size(439, 20);
            this.cityTextEdit.StyleController = this.layoutControl1;
            this.cityTextEdit.TabIndex = 7;
            // 
            // addressItem
            // 
            this.addressItem.Control = this.addressTextEdit;
            this.addressItem.Location = new System.Drawing.Point(0, 40);
            this.addressItem.Name = "addressItem";
            this.addressItem.Size = new System.Drawing.Size(443, 40);
            this.addressItem.Text = "Адрес";
            this.addressItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.addressItem.TextSize = new System.Drawing.Size(105, 13);
            // 
            // addressTextEdit
            // 
            this.addressTextEdit.Location = new System.Drawing.Point(490, 98);
            this.addressTextEdit.Name = "addressTextEdit";
            this.addressTextEdit.Size = new System.Drawing.Size(439, 20);
            this.addressTextEdit.StyleController = this.layoutControl1;
            this.addressTextEdit.TabIndex = 8;
            // 
            // telephoneItem
            // 
            this.telephoneItem.Control = this.telephoneTextEdit;
            this.telephoneItem.Location = new System.Drawing.Point(0, 80);
            this.telephoneItem.Name = "telephoneItem";
            this.telephoneItem.Size = new System.Drawing.Size(220, 40);
            this.telephoneItem.Text = "Телефон";
            this.telephoneItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.telephoneItem.TextSize = new System.Drawing.Size(105, 13);
            // 
            // telephoneTextEdit
            // 
            this.telephoneTextEdit.Location = new System.Drawing.Point(490, 138);
            this.telephoneTextEdit.Name = "telephoneTextEdit";
            this.telephoneTextEdit.Properties.Mask.EditMask = "(999) 000-00-00";
            this.telephoneTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.telephoneTextEdit.Size = new System.Drawing.Size(216, 20);
            this.telephoneTextEdit.StyleController = this.layoutControl1;
            this.telephoneTextEdit.TabIndex = 9;
            // 
            // emailItem
            // 
            this.emailItem.Control = this.emailTextEdit;
            this.emailItem.Location = new System.Drawing.Point(220, 80);
            this.emailItem.Name = "emailItem";
            this.emailItem.Size = new System.Drawing.Size(223, 40);
            this.emailItem.Text = "E-mail";
            this.emailItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.emailItem.TextSize = new System.Drawing.Size(105, 13);
            // 
            // emailTextEdit
            // 
            this.emailTextEdit.Location = new System.Drawing.Point(710, 138);
            this.emailTextEdit.Name = "emailTextEdit";
            this.emailTextEdit.Properties.Mask.EditMask = "(\\w|[\\.\\-])+@(\\w|[\\-]+\\.)*(\\w|[\\-]){2,63}\\.[a-zA-Z]{2,4}";
            this.emailTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.emailTextEdit.Properties.Mask.ShowPlaceHolders = false;
            this.emailTextEdit.Size = new System.Drawing.Size(219, 20);
            this.emailTextEdit.StyleController = this.layoutControl1;
            this.emailTextEdit.TabIndex = 10;
            // 
            // personalInfoGroup
            // 
            this.personalInfoGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.firstNameItem,
            this.lastNameItem,
            this.middleNameItem});
            this.personalInfoGroup.Location = new System.Drawing.Point(0, 0);
            this.personalInfoGroup.Name = "personalInfoGroup";
            this.personalInfoGroup.Size = new System.Drawing.Size(466, 162);
            this.personalInfoGroup.Text = "Персональные данные";
            // 
            // firstNameItem
            // 
            this.firstNameItem.Control = this.firstNameTextEdit;
            this.firstNameItem.Location = new System.Drawing.Point(0, 0);
            this.firstNameItem.Name = "firstNameItem";
            this.firstNameItem.Size = new System.Drawing.Size(442, 40);
            this.firstNameItem.Text = "Имя";
            this.firstNameItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.firstNameItem.TextSize = new System.Drawing.Size(105, 13);
            // 
            // firstNameTextEdit
            // 
            this.firstNameTextEdit.Location = new System.Drawing.Point(24, 58);
            this.firstNameTextEdit.Name = "firstNameTextEdit";
            this.firstNameTextEdit.Properties.Mask.EditMask = "\\p{L}+";
            this.firstNameTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.firstNameTextEdit.Properties.Mask.ShowPlaceHolders = false;
            this.firstNameTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.firstNameTextEdit.Size = new System.Drawing.Size(438, 20);
            this.firstNameTextEdit.StyleController = this.layoutControl1;
            this.firstNameTextEdit.TabIndex = 4;
            // 
            // lastNameItem
            // 
            this.lastNameItem.Control = this.lastNameTextEdit;
            this.lastNameItem.Location = new System.Drawing.Point(0, 40);
            this.lastNameItem.Name = "lastNameItem";
            this.lastNameItem.Size = new System.Drawing.Size(442, 40);
            this.lastNameItem.Text = "Фамилия";
            this.lastNameItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.lastNameItem.TextSize = new System.Drawing.Size(105, 13);
            // 
            // lastNameTextEdit
            // 
            this.lastNameTextEdit.Location = new System.Drawing.Point(24, 98);
            this.lastNameTextEdit.Name = "lastNameTextEdit";
            this.lastNameTextEdit.Properties.Mask.EditMask = "\\p{L}+";
            this.lastNameTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.lastNameTextEdit.Properties.Mask.ShowPlaceHolders = false;
            this.lastNameTextEdit.Size = new System.Drawing.Size(438, 20);
            this.lastNameTextEdit.StyleController = this.layoutControl1;
            this.lastNameTextEdit.TabIndex = 5;
            // 
            // middleNameItem
            // 
            this.middleNameItem.Control = this.middleNameTextEdit;
            this.middleNameItem.Location = new System.Drawing.Point(0, 80);
            this.middleNameItem.Name = "middleNameItem";
            this.middleNameItem.Size = new System.Drawing.Size(442, 40);
            this.middleNameItem.Text = "Отчество";
            this.middleNameItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.middleNameItem.TextSize = new System.Drawing.Size(105, 13);
            // 
            // middleNameTextEdit
            // 
            this.middleNameTextEdit.Location = new System.Drawing.Point(24, 138);
            this.middleNameTextEdit.Name = "middleNameTextEdit";
            this.middleNameTextEdit.Properties.Mask.EditMask = "\\p{L}+";
            this.middleNameTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.middleNameTextEdit.Properties.Mask.ShowPlaceHolders = false;
            this.middleNameTextEdit.Size = new System.Drawing.Size(438, 20);
            this.middleNameTextEdit.StyleController = this.layoutControl1;
            this.middleNameTextEdit.TabIndex = 6;
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
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.ribbonControl1.Size = new System.Drawing.Size(953, 141);
            // 
            // CustomerDetailsViev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 665);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.layoutControl1);
            this.MinimumSize = new System.Drawing.Size(690, 550);
            this.Name = "CustomerDetailsViev";
            this.Text = "Заказчик";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.commentsListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCommentsItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactInfoGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalInfoGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleNameItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup customerGroup;
        private DevExpress.XtraGrid.GridControl ordersGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn orderNumberGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn orderSumGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn orderStatusGridColumn;
        private DevExpress.XtraLayout.LayoutControlItem ordersItem;
        private DevExpress.XtraEditors.ListBoxControl commentsListBoxControl;
        private DevExpress.XtraLayout.LayoutControlItem listCommentsItem;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private DevExpress.XtraEditors.MemoEdit commentMemoEdit;
        private DevExpress.XtraLayout.LayoutControlItem commentItem;
        private DevExpress.XtraEditors.TextEdit emailTextEdit;
        private DevExpress.XtraEditors.TextEdit telephoneTextEdit;
        private DevExpress.XtraEditors.TextEdit addressTextEdit;
        private DevExpress.XtraEditors.TextEdit cityTextEdit;
        private DevExpress.XtraEditors.TextEdit middleNameTextEdit;
        private DevExpress.XtraEditors.TextEdit lastNameTextEdit;
        private DevExpress.XtraEditors.TextEdit firstNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup personalInfoGroup;
        private DevExpress.XtraLayout.LayoutControlItem firstNameItem;
        private DevExpress.XtraLayout.LayoutControlItem lastNameItem;
        private DevExpress.XtraLayout.LayoutControlItem middleNameItem;
        private DevExpress.XtraLayout.LayoutControlGroup contactInfoGroup;
        private DevExpress.XtraLayout.LayoutControlItem cityItem;
        private DevExpress.XtraLayout.LayoutControlItem addressItem;
        private DevExpress.XtraLayout.LayoutControlItem telephoneItem;
        private DevExpress.XtraLayout.LayoutControlItem emailItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup saveOrEditribbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem saveEditButtonItem;
        private DevExpress.XtraBars.BarButtonItem saveAndNewButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        
    }
}