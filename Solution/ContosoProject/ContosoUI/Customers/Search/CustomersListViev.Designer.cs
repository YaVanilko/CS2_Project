namespace ContosoUI.Customers.Search
{
    partial class CustomersListView
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.customersGridControl = new DevExpress.XtraGrid.GridControl();
            this.customersListViewModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.firstNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lastNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.middleNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.addressGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ordersCountGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ordersSumGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.telephoneGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.eMailGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.filterCityComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.customersListItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.filterCityItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.customersListViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.searchButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.saveButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.printButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.searchRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.saveRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersListViewModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterCityComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersListItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterCityItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersListViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuRibbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.customersGridControl);
            this.layoutControl1.Controls.Add(this.filterCityComboBoxEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.layoutControl1.Location = new System.Drawing.Point(0, 171);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(401, 347, 498, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(804, 390);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // customersGridControl
            // 
            this.customersGridControl.DataSource = this.customersListViewModelBindingSource1;
            this.customersGridControl.Location = new System.Drawing.Point(12, 52);
            this.customersGridControl.MainView = this.customersGridView;
            this.customersGridControl.Name = "customersGridControl";
            this.customersGridControl.Size = new System.Drawing.Size(780, 326);
            this.customersGridControl.TabIndex = 5;
            this.customersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.customersGridView});
            // 
            // customersGridView
            // 
            this.customersGridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.customersGridView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.customersGridView.Appearance.Row.Options.UseTextOptions = true;
            this.customersGridView.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.customersGridView.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.customersGridView.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.customersGridView.ColumnPanelRowHeight = 50;
            this.customersGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.firstNameGridColumn,
            this.lastNameGridColumn,
            this.middleNameGridColumn,
            this.cityGridColumn,
            this.addressGridColumn,
            this.ordersCountGridColumn,
            this.ordersSumGridColumn,
            this.telephoneGridColumn,
            this.eMailGridColumn,
            this.idGridColumn,
            this.statusGridColumn});
            this.customersGridView.GridControl = this.customersGridControl;
            this.customersGridView.Name = "customersGridView";
            this.customersGridView.OptionsBehavior.Editable = false;
            this.customersGridView.OptionsView.RowAutoHeight = true;
            this.customersGridView.DoubleClick += new System.EventHandler(this.customersGridView_DoubleClick);
            // 
            // firstNameGridColumn
            // 
            this.firstNameGridColumn.Caption = "Имя";
            this.firstNameGridColumn.FieldName = "FirstName";
            this.firstNameGridColumn.Name = "firstNameGridColumn";
            this.firstNameGridColumn.Visible = true;
            this.firstNameGridColumn.VisibleIndex = 1;
            // 
            // lastNameGridColumn
            // 
            this.lastNameGridColumn.Caption = "Фамилия";
            this.lastNameGridColumn.FieldName = "LastName";
            this.lastNameGridColumn.Name = "lastNameGridColumn";
            this.lastNameGridColumn.Visible = true;
            this.lastNameGridColumn.VisibleIndex = 0;
            // 
            // middleNameGridColumn
            // 
            this.middleNameGridColumn.Caption = "Отчество";
            this.middleNameGridColumn.FieldName = "MiddleName";
            this.middleNameGridColumn.Name = "middleNameGridColumn";
            this.middleNameGridColumn.Visible = true;
            this.middleNameGridColumn.VisibleIndex = 2;
            // 
            // cityGridColumn
            // 
            this.cityGridColumn.Caption = "Город";
            this.cityGridColumn.FieldName = "City";
            this.cityGridColumn.Name = "cityGridColumn";
            this.cityGridColumn.Visible = true;
            this.cityGridColumn.VisibleIndex = 3;
            // 
            // addressGridColumn
            // 
            this.addressGridColumn.Caption = "Адрес";
            this.addressGridColumn.FieldName = "Address";
            this.addressGridColumn.Name = "addressGridColumn";
            this.addressGridColumn.Visible = true;
            this.addressGridColumn.VisibleIndex = 4;
            // 
            // ordersCountGridColumn
            // 
            this.ordersCountGridColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.ordersCountGridColumn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ordersCountGridColumn.Caption = "Количество заказов";
            this.ordersCountGridColumn.FieldName = "CounOrders";
            this.ordersCountGridColumn.Name = "ordersCountGridColumn";
            this.ordersCountGridColumn.Visible = true;
            this.ordersCountGridColumn.VisibleIndex = 7;
            // 
            // ordersSumGridColumn
            // 
            this.ordersSumGridColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.ordersSumGridColumn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ordersSumGridColumn.Caption = "Общая сумма заказов";
            this.ordersSumGridColumn.FieldName = "SumOrders";
            this.ordersSumGridColumn.Name = "ordersSumGridColumn";
            this.ordersSumGridColumn.OptionsEditForm.RowSpan = 2;
            this.ordersSumGridColumn.Visible = true;
            this.ordersSumGridColumn.VisibleIndex = 8;
            // 
            // telephoneGridColumn
            // 
            this.telephoneGridColumn.Caption = "Телефон";
            this.telephoneGridColumn.FieldName = "Telephone";
            this.telephoneGridColumn.Name = "telephoneGridColumn";
            this.telephoneGridColumn.Visible = true;
            this.telephoneGridColumn.VisibleIndex = 5;
            // 
            // eMailGridColumn
            // 
            this.eMailGridColumn.Caption = "E-mail";
            this.eMailGridColumn.FieldName = "Email";
            this.eMailGridColumn.Name = "eMailGridColumn";
            this.eMailGridColumn.Visible = true;
            this.eMailGridColumn.VisibleIndex = 6;
            // 
            // idGridColumn
            // 
            this.idGridColumn.Caption = "Id";
            this.idGridColumn.FieldName = "Id";
            this.idGridColumn.Name = "idGridColumn";
            // 
            // statusGridColumn
            // 
            this.statusGridColumn.Caption = "Статус";
            this.statusGridColumn.Name = "statusGridColumn";
            this.statusGridColumn.Visible = true;
            this.statusGridColumn.VisibleIndex = 9;
            // 
            // filterCityComboBoxEdit
            // 
            this.filterCityComboBoxEdit.Location = new System.Drawing.Point(76, 12);
            this.filterCityComboBoxEdit.Name = "filterCityComboBoxEdit";
            this.filterCityComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.filterCityComboBoxEdit.Properties.Sorted = true;
            this.filterCityComboBoxEdit.Size = new System.Drawing.Size(716, 20);
            this.filterCityComboBoxEdit.StyleController = this.layoutControl1;
            this.filterCityComboBoxEdit.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.customersListItem,
            this.filterCityItem});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(804, 390);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // customersListItem
            // 
            this.customersListItem.Control = this.customersGridControl;
            this.customersListItem.Location = new System.Drawing.Point(0, 24);
            this.customersListItem.Name = "customersListItem";
            this.customersListItem.Size = new System.Drawing.Size(784, 346);
            this.customersListItem.Text = "Покупатели";
            this.customersListItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.customersListItem.TextSize = new System.Drawing.Size(61, 13);
            // 
            // filterCityItem
            // 
            this.filterCityItem.Control = this.filterCityComboBoxEdit;
            this.filterCityItem.Location = new System.Drawing.Point(0, 0);
            this.filterCityItem.Name = "filterCityItem";
            this.filterCityItem.Size = new System.Drawing.Size(784, 24);
            this.filterCityItem.Text = "Город";
            this.filterCityItem.TextSize = new System.Drawing.Size(61, 13);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Domain.Entities.Customer);
            // 
            // menuRibbonControl
            // 
            this.menuRibbonControl.Dock = System.Windows.Forms.DockStyle.None;
            this.menuRibbonControl.ExpandCollapseItem.Id = 0;
            this.menuRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.menuRibbonControl.ExpandCollapseItem,
            this.searchButtonItem,
            this.saveButtonItem,
            this.printButtonItem});
            this.menuRibbonControl.Location = new System.Drawing.Point(5, 2);
            this.menuRibbonControl.MaxItemId = 4;
            this.menuRibbonControl.Name = "menuRibbonControl";
            this.menuRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.menuRibbonControl.Size = new System.Drawing.Size(795, 141);
            // 
            // searchButtonItem
            // 
            this.searchButtonItem.Caption = "Поиск покупателей";
            this.searchButtonItem.Id = 1;
            this.searchButtonItem.ImageUri.Uri = "Find";
            this.searchButtonItem.Name = "searchButtonItem";
            this.searchButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.searchButtonItem_ItemClick);
            // 
            // saveButtonItem
            // 
            this.saveButtonItem.Caption = "Сохранить";
            this.saveButtonItem.Id = 2;
            this.saveButtonItem.ImageUri.Uri = "Save";
            this.saveButtonItem.Name = "saveButtonItem";
            this.saveButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveButtonItem_ItemClick);
            // 
            // printButtonItem
            // 
            this.printButtonItem.Caption = "Печатать";
            this.printButtonItem.Id = 3;
            this.printButtonItem.ImageUri.Uri = "Print";
            this.printButtonItem.Name = "printButtonItem";
            this.printButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.printButtonItem_ItemClick);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.searchRibbonPageGroup,
            this.saveRibbonPageGroup});
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Меню";
            // 
            // searchRibbonPageGroup
            // 
            this.searchRibbonPageGroup.ItemLinks.Add(this.searchButtonItem);
            this.searchRibbonPageGroup.MergeOrder = 5;
            this.searchRibbonPageGroup.Name = "searchRibbonPageGroup";
            this.searchRibbonPageGroup.Text = "Поиск";
            // 
            // saveRibbonPageGroup
            // 
            this.saveRibbonPageGroup.ItemLinks.Add(this.saveButtonItem);
            this.saveRibbonPageGroup.ItemLinks.Add(this.printButtonItem);
            this.saveRibbonPageGroup.MergeOrder = 6;
            this.saveRibbonPageGroup.Name = "saveRibbonPageGroup";
            this.saveRibbonPageGroup.Text = "Сохранение";
            // 
            // CustomersListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.menuRibbonControl);
            this.MinimumSize = new System.Drawing.Size(690, 550);
            this.Name = "CustomersListView";
            this.Text = "Список клиентов";
            this.Load += new System.EventHandler(this.CustomersListView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersListViewModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterCityComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersListItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterCityItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersListViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuRibbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ComboBoxEdit filterCityComboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem filterCityItem;
        private DevExpress.XtraGrid.GridControl customersGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView customersGridView;
        private DevExpress.XtraGrid.Columns.GridColumn firstNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn lastNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn middleNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn cityGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn addressGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn ordersCountGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn ordersSumGridColumn;
        private DevExpress.XtraLayout.LayoutControlItem customersListItem;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DevExpress.XtraBars.Ribbon.RibbonControl menuRibbonControl;
        private DevExpress.XtraBars.BarButtonItem searchButtonItem;
        private DevExpress.XtraBars.BarButtonItem saveButtonItem;
        private DevExpress.XtraBars.BarButtonItem printButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup searchRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup saveRibbonPageGroup;
        private System.Windows.Forms.BindingSource customersListViewModelBindingSource;
        private System.Windows.Forms.BindingSource customersListViewModelBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn telephoneGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn eMailGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn idGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn statusGridColumn;

    }
}