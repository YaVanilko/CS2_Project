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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersListView));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.searchCustomersButton = new DevExpress.XtraEditors.SimpleButton();
            this.customersGridControl = new DevExpress.XtraGrid.GridControl();
            this.customersListViewModelBindingSource = new System.Windows.Forms.BindingSource();
            this.customersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.filterCityComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.filterCityItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.customersListItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.searchCustomersItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.customerBindingSource = new System.Windows.Forms.BindingSource();
            this.collName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladdress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colqty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsum = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersListViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterCityComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterCityItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersListItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCustomersItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.checkBox1);
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
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(771, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(21, 20);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
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
            this.customersGridControl.DataSource = this.customersListViewModelBindingSource;
            this.customersGridControl.Location = new System.Drawing.Point(12, 90);
            this.customersGridControl.MainView = this.customersGridView;
            this.customersGridControl.Name = "customersGridControl";
            this.customersGridControl.Size = new System.Drawing.Size(780, 459);
            this.customersGridControl.TabIndex = 5;
            this.customersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.customersGridView});
            // 
            // customersListViewModelBindingSource
            // 
            this.customersListViewModelBindingSource.DataSource = typeof(ContosoUI.Customers.Search.CustomersListViewModel);
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
            this.collName,
            this.colfName,
            this.colmName,
            this.colcity,
            this.coladdress,
            this.colqty,
            this.colsum});
            this.customersGridView.GridControl = this.customersGridControl;
            this.customersGridView.Name = "customersGridView";
            this.customersGridView.OptionsBehavior.Editable = false;
            this.customersGridView.OptionsView.RowAutoHeight = true;
            this.customersGridView.DoubleClick += new System.EventHandler(this.customersGridView_DoubleClick);
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
            this.emptySpaceItem3,
            this.layoutControlItem1});
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
            this.emptySpaceItem3.Size = new System.Drawing.Size(24, 42);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.checkBox1;
            this.layoutControlItem1.Location = new System.Drawing.Point(759, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(25, 42);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Domain.Entities.Customer);
            // 
            // collName
            // 
            this.collName.FieldName = "lName";
            this.collName.Name = "collName";
            this.collName.Visible = true;
            this.collName.VisibleIndex = 0;
            // 
            // colfName
            // 
            this.colfName.FieldName = "fName";
            this.colfName.Name = "colfName";
            this.colfName.Visible = true;
            this.colfName.VisibleIndex = 1;
            // 
            // colmName
            // 
            this.colmName.FieldName = "mName";
            this.colmName.Name = "colmName";
            this.colmName.Visible = true;
            this.colmName.VisibleIndex = 2;
            // 
            // colcity
            // 
            this.colcity.FieldName = "city";
            this.colcity.Name = "colcity";
            this.colcity.Visible = true;
            this.colcity.VisibleIndex = 3;
            // 
            // coladdress
            // 
            this.coladdress.FieldName = "address";
            this.coladdress.Name = "coladdress";
            this.coladdress.Visible = true;
            this.coladdress.VisibleIndex = 4;
            // 
            // colqty
            // 
            this.colqty.FieldName = "qty";
            this.colqty.Name = "colqty";
            this.colqty.Visible = true;
            this.colqty.VisibleIndex = 5;
            // 
            // colsum
            // 
            this.colsum.FieldName = "sum";
            this.colsum.Name = "colsum";
            this.colsum.Visible = true;
            this.colsum.VisibleIndex = 6;
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
            ((System.ComponentModel.ISupportInitialize)(this.customersListViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterCityComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterCityItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersListItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCustomersItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ComboBoxEdit filterCityComboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem filterCityItem;
        private DevExpress.XtraGrid.GridControl customersGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView customersGridView;
        private DevExpress.XtraLayout.LayoutControlItem customersListItem;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DevExpress.XtraEditors.SimpleButton searchCustomersButton;
        private DevExpress.XtraLayout.LayoutControlItem searchCustomersItem;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource customersListViewModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn collName;
        private DevExpress.XtraGrid.Columns.GridColumn colfName;
        private DevExpress.XtraGrid.Columns.GridColumn colmName;
        private DevExpress.XtraGrid.Columns.GridColumn colcity;
        private DevExpress.XtraGrid.Columns.GridColumn coladdress;
        private DevExpress.XtraGrid.Columns.GridColumn colqty;
        private DevExpress.XtraGrid.Columns.GridColumn colsum;

    }
}