namespace ContosoUI.Customers.Report
{
    partial class CustomerReportView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerReportView));
            this.customerReportPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.customerReportPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.printButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.customerReportGridControl = new DevExpress.XtraGrid.GridControl();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerReportGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.firstNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.middleNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.addressGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderCountgridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ordersSumGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.telephoneGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.emailGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cityFilterComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cutsomerReportGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.cityFilterItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.customerReportItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.saveItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.printItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.searchItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityFilterComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutsomerReportGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityFilterItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // customerReportPrintDocument
            // 
            this.customerReportPrintDocument.DocumentName = "CustomerReport";
            // 
            // customerReportPrintPreviewDialog
            // 
            this.customerReportPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.customerReportPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.customerReportPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.customerReportPrintPreviewDialog.Document = this.customerReportPrintDocument;
            this.customerReportPrintPreviewDialog.Enabled = true;
            this.customerReportPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("customerReportPrintPreviewDialog.Icon")));
            this.customerReportPrintPreviewDialog.Name = "customerReportPrintPreviewDialog";
            this.customerReportPrintPreviewDialog.Visible = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.searchButton);
            this.layoutControl1.Controls.Add(this.printButton);
            this.layoutControl1.Controls.Add(this.saveButton);
            this.layoutControl1.Controls.Add(this.customerReportGridControl);
            this.layoutControl1.Controls.Add(this.cityFilterComboBoxEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(598, 293, 367, 350);
            this.layoutControl1.Root = this.cutsomerReportGroup;
            this.layoutControl1.Size = new System.Drawing.Size(762, 511);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // searchButton
            // 
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(431, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(271, 38);
            this.searchButton.StyleController = this.layoutControl1;
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Поиск клиентов";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // printButton
            // 
            this.printButton.Image = ((System.Drawing.Image)(resources.GetObject("printButton.Image")));
            this.printButton.Location = new System.Drawing.Point(154, 461);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(124, 38);
            this.printButton.StyleController = this.layoutControl1;
            this.printButton.TabIndex = 7;
            this.printButton.Text = "Распечатать";
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(12, 461);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(125, 38);
            this.saveButton.StyleController = this.layoutControl1;
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // customerReportGridControl
            // 
            this.customerReportGridControl.DataSource = this.customerBindingSource;
            this.customerReportGridControl.Location = new System.Drawing.Point(12, 80);
            this.customerReportGridControl.MainView = this.customerReportGridView;
            this.customerReportGridControl.Name = "customerReportGridControl";
            this.customerReportGridControl.Size = new System.Drawing.Size(738, 377);
            this.customerReportGridControl.TabIndex = 5;
            this.customerReportGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.customerReportGridView});
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Domain.Entities.Customer);
            // 
            // customerReportGridView
            // 
            this.customerReportGridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.customerReportGridView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.customerReportGridView.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.customerReportGridView.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.customerReportGridView.ColumnPanelRowHeight = 50;
            this.customerReportGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.firstNameGridColumn,
            this.LastNameGridColumn,
            this.middleNameGridColumn,
            this.cityGridColumn,
            this.addressGridColumn,
            this.orderCountgridColumn,
            this.ordersSumGridColumn,
            this.telephoneGridColumn,
            this.emailGridColumn});
            this.customerReportGridView.GridControl = this.customerReportGridControl;
            this.customerReportGridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.customerReportGridView.Name = "customerReportGridView";
            // 
            // firstNameGridColumn
            // 
            this.firstNameGridColumn.Caption = "Имя";
            this.firstNameGridColumn.FieldName = "PersonalInfo.FirstName";
            this.firstNameGridColumn.Name = "firstNameGridColumn";
            this.firstNameGridColumn.Visible = true;
            this.firstNameGridColumn.VisibleIndex = 0;
            // 
            // LastNameGridColumn
            // 
            this.LastNameGridColumn.Caption = "Фамилия";
            this.LastNameGridColumn.FieldName = "PersonalInfo.LastName";
            this.LastNameGridColumn.Name = "LastNameGridColumn";
            this.LastNameGridColumn.Visible = true;
            this.LastNameGridColumn.VisibleIndex = 1;
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
            // orderCountgridColumn
            // 
            this.orderCountgridColumn.Caption = "Количество заказов";
            this.orderCountgridColumn.FieldName = "OrdersCount";
            this.orderCountgridColumn.Name = "orderCountgridColumn";
            this.orderCountgridColumn.Visible = true;
            this.orderCountgridColumn.VisibleIndex = 7;
            // 
            // ordersSumGridColumn
            // 
            this.ordersSumGridColumn.Caption = "Общая сумма заказов";
            this.ordersSumGridColumn.FieldName = "TotalOrdersCoast";
            this.ordersSumGridColumn.Name = "ordersSumGridColumn";
            this.ordersSumGridColumn.Visible = true;
            this.ordersSumGridColumn.VisibleIndex = 8;
            // 
            // telephoneGridColumn
            // 
            this.telephoneGridColumn.Caption = "Телефон";
            this.telephoneGridColumn.FieldName = "Contacts.Telephone";
            this.telephoneGridColumn.Name = "telephoneGridColumn";
            this.telephoneGridColumn.Visible = true;
            this.telephoneGridColumn.VisibleIndex = 5;
            // 
            // emailGridColumn
            // 
            this.emailGridColumn.Caption = "E-mail";
            this.emailGridColumn.FieldName = "Contacts.Email";
            this.emailGridColumn.Name = "emailGridColumn";
            this.emailGridColumn.Visible = true;
            this.emailGridColumn.VisibleIndex = 6;
            // 
            // cityFilterComboBoxEdit
            // 
            this.cityFilterComboBoxEdit.Location = new System.Drawing.Point(131, 12);
            this.cityFilterComboBoxEdit.Name = "cityFilterComboBoxEdit";
            this.cityFilterComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cityFilterComboBoxEdit.Size = new System.Drawing.Size(248, 20);
            this.cityFilterComboBoxEdit.StyleController = this.layoutControl1;
            this.cityFilterComboBoxEdit.TabIndex = 4;
            // 
            // cutsomerReportGroup
            // 
            this.cutsomerReportGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.cutsomerReportGroup.GroupBordersVisible = false;
            this.cutsomerReportGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.cityFilterItem,
            this.customerReportItem,
            this.saveItem,
            this.printItem,
            this.emptySpaceItem1,
            this.emptySpaceItem3,
            this.emptySpaceItem2,
            this.emptySpaceItem4,
            this.searchItem,
            this.emptySpaceItem5});
            this.cutsomerReportGroup.Location = new System.Drawing.Point(0, 0);
            this.cutsomerReportGroup.Name = "Root";
            this.cutsomerReportGroup.Size = new System.Drawing.Size(762, 511);
            this.cutsomerReportGroup.TextVisible = false;
            // 
            // cityFilterItem
            // 
            this.cityFilterItem.Control = this.cityFilterComboBoxEdit;
            this.cityFilterItem.Location = new System.Drawing.Point(0, 0);
            this.cityFilterItem.Name = "cityFilterItem";
            this.cityFilterItem.Size = new System.Drawing.Size(371, 42);
            this.cityFilterItem.Text = "Город";
            this.cityFilterItem.TextSize = new System.Drawing.Size(116, 13);
            // 
            // customerReportItem
            // 
            this.customerReportItem.Control = this.customerReportGridControl;
            this.customerReportItem.Location = new System.Drawing.Point(0, 52);
            this.customerReportItem.Name = "customerReportItem";
            this.customerReportItem.Size = new System.Drawing.Size(742, 397);
            this.customerReportItem.Text = "Отчет по покупателям";
            this.customerReportItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.customerReportItem.TextSize = new System.Drawing.Size(116, 13);
            // 
            // saveItem
            // 
            this.saveItem.Control = this.saveButton;
            this.saveItem.Location = new System.Drawing.Point(0, 449);
            this.saveItem.Name = "saveItem";
            this.saveItem.Size = new System.Drawing.Size(129, 42);
            this.saveItem.TextSize = new System.Drawing.Size(0, 0);
            this.saveItem.TextVisible = false;
            // 
            // printItem
            // 
            this.printItem.Control = this.printButton;
            this.printItem.Location = new System.Drawing.Point(142, 449);
            this.printItem.Name = "printItem";
            this.printItem.Size = new System.Drawing.Size(128, 42);
            this.printItem.TextSize = new System.Drawing.Size(0, 0);
            this.printItem.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(694, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(48, 42);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(129, 449);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(13, 42);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 42);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(742, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(270, 449);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(472, 42);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // searchItem
            // 
            this.searchItem.Control = this.searchButton;
            this.searchItem.Location = new System.Drawing.Point(419, 0);
            this.searchItem.Name = "searchItem";
            this.searchItem.Size = new System.Drawing.Size(275, 42);
            this.searchItem.TextSize = new System.Drawing.Size(0, 0);
            this.searchItem.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(371, 0);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(48, 42);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // CustomerReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 511);
            this.Controls.Add(this.layoutControl1);
            this.MinimumSize = new System.Drawing.Size(690, 550);
            this.Name = "CustomerReportView";
            this.Text = "Отчет по клиентам";
            this.Load += new System.EventHandler(this.CustomerReportView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerReportGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityFilterComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutsomerReportGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityFilterItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument customerReportPrintDocument;
        private System.Windows.Forms.PrintPreviewDialog customerReportPrintPreviewDialog;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraGrid.GridControl customerReportGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView customerReportGridView;
        private DevExpress.XtraEditors.ComboBoxEdit cityFilterComboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlGroup cutsomerReportGroup;
        private DevExpress.XtraLayout.LayoutControlItem cityFilterItem;
        private DevExpress.XtraLayout.LayoutControlItem customerReportItem;
        private DevExpress.XtraLayout.LayoutControlItem saveItem;
        private DevExpress.XtraEditors.SimpleButton printButton;
        private DevExpress.XtraLayout.LayoutControlItem printItem;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraGrid.Columns.GridColumn firstNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn LastNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn middleNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn cityGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn addressGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn orderCountgridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn ordersSumGridColumn;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraLayout.LayoutControlItem searchItem;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn telephoneGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn emailGridColumn;

    }
}