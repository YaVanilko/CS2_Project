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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersListView));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.searchCustomersButton = new DevExpress.XtraEditors.SimpleButton();
            this.customersGridControl = new DevExpress.XtraGrid.GridControl();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.firstNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lastNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.middleNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.addressGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ordersCountGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ordersSumGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.filterCityComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.filterCityItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.customersListItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.searchCustomersItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterCityComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterCityItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersListItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCustomersItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.searchCustomersButton);
            this.layoutControl1.Controls.Add(this.customersGridControl);
            this.layoutControl1.Controls.Add(this.filterCityComboBoxEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(401, 347, 498, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(804, 561);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // searchCustomersButton
            // 
            this.searchCustomersButton.Image = ((System.Drawing.Image)(resources.GetObject("searchCustomersButton.Image")));
            this.searchCustomersButton.Location = new System.Drawing.Point(452, 12);
            this.searchCustomersButton.Name = "searchCustomersButton";
            this.searchCustomersButton.Size = new System.Drawing.Size(291, 38);
            this.searchCustomersButton.StyleController = this.layoutControl1;
            this.searchCustomersButton.TabIndex = 6;
            this.searchCustomersButton.Text = "Поиск клиентов";
            this.searchCustomersButton.Click += new System.EventHandler(this.searchCustomersButton_Click);
            // 
            // customersGridControl
            // 
            this.customersGridControl.DataSource = this.customerBindingSource;
            this.customersGridControl.Location = new System.Drawing.Point(12, 90);
            this.customersGridControl.MainView = this.customersGridView;
            this.customersGridControl.Name = "customersGridControl";
            this.customersGridControl.Size = new System.Drawing.Size(780, 459);
            this.customersGridControl.TabIndex = 5;
            this.customersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.customersGridView});
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Domain.Entities.Customer);
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
            this.ordersSumGridColumn});
            this.customersGridView.GridControl = this.customersGridControl;
            this.customersGridView.Name = "customersGridView";
            this.customersGridView.OptionsBehavior.Editable = false;
            this.customersGridView.OptionsView.RowAutoHeight = true;
            this.customersGridView.DoubleClick += new System.EventHandler(this.customersGridView_DoubleClick);
            // 
            // firstNameGridColumn
            // 
            this.firstNameGridColumn.Caption = "Имя";
            this.firstNameGridColumn.FieldName = "PersonalInfo.FirstName";
            this.firstNameGridColumn.Name = "firstNameGridColumn";
            this.firstNameGridColumn.Visible = true;
            this.firstNameGridColumn.VisibleIndex = 0;
            // 
            // lastNameGridColumn
            // 
            this.lastNameGridColumn.Caption = "Фамилия";
            this.lastNameGridColumn.FieldName = "PersonalInfo.LastName";
            this.lastNameGridColumn.Name = "lastNameGridColumn";
            this.lastNameGridColumn.Visible = true;
            this.lastNameGridColumn.VisibleIndex = 1;
            // 
            // middleNameGridColumn
            // 
            this.middleNameGridColumn.Caption = "Отчество";
            this.middleNameGridColumn.FieldName = "PersonalInfo.MiddleName";
            this.middleNameGridColumn.Name = "middleNameGridColumn";
            this.middleNameGridColumn.Visible = true;
            this.middleNameGridColumn.VisibleIndex = 2;
            // 
            // cityGridColumn
            // 
            this.cityGridColumn.Caption = "Город";
            this.cityGridColumn.FieldName = "Contacts.City";
            this.cityGridColumn.Name = "cityGridColumn";
            this.cityGridColumn.Visible = true;
            this.cityGridColumn.VisibleIndex = 3;
            // 
            // addressGridColumn
            // 
            this.addressGridColumn.Caption = "Адрес";
            this.addressGridColumn.FieldName = "Contacts.Adress";
            this.addressGridColumn.Name = "addressGridColumn";
            this.addressGridColumn.Visible = true;
            this.addressGridColumn.VisibleIndex = 4;
            // 
            // ordersCountGridColumn
            // 
            this.ordersCountGridColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.ordersCountGridColumn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ordersCountGridColumn.Caption = "Количество заказов";
            this.ordersCountGridColumn.FieldName = "OrdersCount";
            this.ordersCountGridColumn.Name = "ordersCountGridColumn";
            this.ordersCountGridColumn.Visible = true;
            this.ordersCountGridColumn.VisibleIndex = 5;
            // 
            // ordersSumGridColumn
            // 
            this.ordersSumGridColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.ordersSumGridColumn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ordersSumGridColumn.Caption = "Общая сумма заказов";
            this.ordersSumGridColumn.FieldName = "TotalOrdersCoast";
            this.ordersSumGridColumn.Name = "ordersSumGridColumn";
            this.ordersSumGridColumn.OptionsEditForm.RowSpan = 2;
            this.ordersSumGridColumn.Visible = true;
            this.ordersSumGridColumn.VisibleIndex = 6;
            // 
            // filterCityComboBoxEdit
            // 
            this.filterCityComboBoxEdit.Location = new System.Drawing.Point(76, 12);
            this.filterCityComboBoxEdit.Name = "filterCityComboBoxEdit";
            this.filterCityComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.filterCityComboBoxEdit.Properties.Sorted = true;
            this.filterCityComboBoxEdit.Size = new System.Drawing.Size(324, 20);
            this.filterCityComboBoxEdit.StyleController = this.layoutControl1;
            this.filterCityComboBoxEdit.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.filterCityItem,
            this.customersListItem,
            this.emptySpaceItem2,
            this.searchCustomersItem,
            this.emptySpaceItem1,
            this.emptySpaceItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(804, 561);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // filterCityItem
            // 
            this.filterCityItem.Control = this.filterCityComboBoxEdit;
            this.filterCityItem.Location = new System.Drawing.Point(0, 0);
            this.filterCityItem.Name = "filterCityItem";
            this.filterCityItem.Size = new System.Drawing.Size(392, 42);
            this.filterCityItem.Text = "Город";
            this.filterCityItem.TextSize = new System.Drawing.Size(61, 13);
            // 
            // customersListItem
            // 
            this.customersListItem.Control = this.customersGridControl;
            this.customersListItem.Location = new System.Drawing.Point(0, 62);
            this.customersListItem.Name = "customersListItem";
            this.customersListItem.Size = new System.Drawing.Size(784, 479);
            this.customersListItem.Text = "Покупатели";
            this.customersListItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.customersListItem.TextSize = new System.Drawing.Size(61, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 42);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(784, 20);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // searchCustomersItem
            // 
            this.searchCustomersItem.Control = this.searchCustomersButton;
            this.searchCustomersItem.Location = new System.Drawing.Point(440, 0);
            this.searchCustomersItem.Name = "searchCustomersItem";
            this.searchCustomersItem.Size = new System.Drawing.Size(295, 42);
            this.searchCustomersItem.TextSize = new System.Drawing.Size(0, 0);
            this.searchCustomersItem.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(392, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(48, 42);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(735, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(49, 42);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // CustomersListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.layoutControl1);
            this.MinimumSize = new System.Drawing.Size(690, 550);
            this.Name = "CustomersListView";
            this.Text = "Список клиентов";
            this.Load += new System.EventHandler(this.CustomersListView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterCityComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterCityItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersListItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCustomersItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

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
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DevExpress.XtraEditors.SimpleButton searchCustomersButton;
        private DevExpress.XtraLayout.LayoutControlItem searchCustomersItem;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;

    }
}