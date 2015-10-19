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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerReportView));
            this.customerReportPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.customerReportPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.customerReportGridControl = new DevExpress.XtraGrid.GridControl();
            this.customerBindingSource = new System.Windows.Forms.BindingSource();
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
            this.cutsomerReportGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.customerReportItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutsomerReportGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
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
            this.layoutControl1.Controls.Add(this.textBox1);
            this.layoutControl1.Controls.Add(this.customerReportGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.layoutControl1.Location = new System.Drawing.Point(0, 137);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(518, 293, 367, 350);
            this.layoutControl1.Root = this.cutsomerReportGroup;
            this.layoutControl1.Size = new System.Drawing.Size(762, 374);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // customerReportGridControl
            // 
            this.customerReportGridControl.DataSource = this.customerBindingSource;
            this.customerReportGridControl.Location = new System.Drawing.Point(12, 52);
            this.customerReportGridControl.MainView = this.customerReportGridView;
            this.customerReportGridControl.Name = "customerReportGridControl";
            this.customerReportGridControl.Size = new System.Drawing.Size(738, 310);
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
            // cutsomerReportGroup
            // 
            this.cutsomerReportGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.cutsomerReportGroup.GroupBordersVisible = false;
            this.cutsomerReportGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.customerReportItem,
            this.layoutControlItem1});
            this.cutsomerReportGroup.Location = new System.Drawing.Point(0, 0);
            this.cutsomerReportGroup.Name = "Root";
            this.cutsomerReportGroup.Size = new System.Drawing.Size(762, 374);
            this.cutsomerReportGroup.TextVisible = false;
            // 
            // customerReportItem
            // 
            this.customerReportItem.Control = this.customerReportGridControl;
            this.customerReportItem.Location = new System.Drawing.Point(0, 24);
            this.customerReportItem.Name = "customerReportItem";
            this.customerReportItem.Size = new System.Drawing.Size(742, 330);
            this.customerReportItem.Text = "Отчет по покупателям";
            this.customerReportItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.customerReportItem.TextSize = new System.Drawing.Size(116, 13);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barEditItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemComboBox1});
            this.ribbonControl1.Size = new System.Drawing.Size(762, 141);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Main";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barEditItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.MergeOrder = 10;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Search";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.MergeOrder = 20;
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Save";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Save and New";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 5;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemComboBox1;
            this.barEditItem1.Id = 7;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.Width = 120;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(619, 20);
            this.textBox1.TabIndex = 6;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textBox1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(742, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(116, 13);
            // 
            // CustomerReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 511);
            this.Controls.Add(this.ribbonControl1);
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
            ((System.ComponentModel.ISupportInitialize)(this.cutsomerReportGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument customerReportPrintDocument;
        private System.Windows.Forms.PrintPreviewDialog customerReportPrintPreviewDialog;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl customerReportGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView customerReportGridView;
        private DevExpress.XtraLayout.LayoutControlGroup cutsomerReportGroup;
        private DevExpress.XtraLayout.LayoutControlItem customerReportItem;
        private DevExpress.XtraGrid.Columns.GridColumn firstNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn LastNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn middleNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn cityGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn addressGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn orderCountgridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn ordersSumGridColumn;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn telephoneGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn emailGridColumn;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;

    }
}