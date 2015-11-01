namespace ContosoUI.Order.Search
{
    partial class SearchView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchView));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.searchBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.searchRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.resultGridControl = new DevExpress.XtraGrid.GridControl();
            this.searchViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcountOfGoods = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcountOfComments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.statusLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusLayoutControlItem)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.searchBarButtonItem});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 2;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.ribbonControl.Size = new System.Drawing.Size(784, 141);
            // 
            // searchBarButtonItem
            // 
            this.searchBarButtonItem.Caption = "Искать";
            this.searchBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("searchBarButtonItem.Glyph")));
            this.searchBarButtonItem.Id = 1;
            this.searchBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("searchBarButtonItem.LargeGlyph")));
            this.searchBarButtonItem.Name = "searchBarButtonItem";
            this.searchBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.searchBarButtonItem_ItemClick);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.searchRibbonPageGroup});
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Меню";
            // 
            // searchRibbonPageGroup
            // 
            this.searchRibbonPageGroup.ItemLinks.Add(this.searchBarButtonItem);
            this.searchRibbonPageGroup.MergeOrder = 10;
            this.searchRibbonPageGroup.Name = "searchRibbonPageGroup";
            this.searchRibbonPageGroup.Text = "Поиск";
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.statusComboBox);
            this.layoutControl.Controls.Add(this.resultGridControl);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.layoutControl.Location = new System.Drawing.Point(0, 137);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.layoutControlGroup;
            this.layoutControl.Size = new System.Drawing.Size(784, 424);
            this.layoutControl.TabIndex = 1;
            this.layoutControl.Text = "layoutControl1";
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(12, 28);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(760, 21);
            this.statusComboBox.TabIndex = 5;
            // 
            // resultGridControl
            // 
            this.resultGridControl.Location = new System.Drawing.Point(12, 53);
            this.resultGridControl.MainView = this.ordersGridView;
            this.resultGridControl.MenuManager = this.ribbonControl;
            this.resultGridControl.Name = "resultGridControl";
            this.resultGridControl.Size = new System.Drawing.Size(760, 359);
            this.resultGridControl.TabIndex = 4;
            this.resultGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ordersGridView});
            this.resultGridControl.Click += new System.EventHandler(this.resultGridControl_Click);
            // 
            // ordersGridView
            // 
            this.ordersGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStatus,
            this.colCustomer,
            this.colcountOfGoods,
            this.colTotalCost,
            this.colcountOfComments});
            this.ordersGridView.GridControl = this.resultGridControl;
            this.ordersGridView.Name = "ordersGridView";
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Статус";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 0;
            this.colStatus.Width = 148;
            // 
            // colCustomer
            // 
            this.colCustomer.Caption = "Клиент";
            this.colCustomer.FieldName = "Customer";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 1;
            this.colCustomer.Width = 148;
            // 
            // colcountOfGoods
            // 
            this.colcountOfGoods.Caption = "Кол-во товаров";
            this.colcountOfGoods.FieldName = "countOfGoods";
            this.colcountOfGoods.Name = "colcountOfGoods";
            this.colcountOfGoods.Visible = true;
            this.colcountOfGoods.VisibleIndex = 2;
            this.colcountOfGoods.Width = 88;
            // 
            // colTotalCost
            // 
            this.colTotalCost.Caption = "Цена";
            this.colTotalCost.FieldName = "TotalCost";
            this.colTotalCost.Name = "colTotalCost";
            this.colTotalCost.Visible = true;
            this.colTotalCost.VisibleIndex = 3;
            this.colTotalCost.Width = 69;
            // 
            // colcountOfComments
            // 
            this.colcountOfComments.Caption = "Кол-во комментариев";
            this.colcountOfComments.FieldName = "countOfComments";
            this.colcountOfComments.Name = "colcountOfComments";
            this.colcountOfComments.Visible = true;
            this.colcountOfComments.VisibleIndex = 4;
            this.colcountOfComments.Width = 181;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.statusLayoutControlItem});
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "layoutControlGroup";
            this.layoutControlGroup.Size = new System.Drawing.Size(784, 424);
            this.layoutControlGroup.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.resultGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 41);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(764, 363);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // statusLayoutControlItem
            // 
            this.statusLayoutControlItem.Control = this.statusComboBox;
            this.statusLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.statusLayoutControlItem.Name = "statusLayoutControlItem";
            this.statusLayoutControlItem.Size = new System.Drawing.Size(764, 41);
            this.statusLayoutControlItem.Text = "Статус";
            this.statusLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.statusLayoutControlItem.TextSize = new System.Drawing.Size(36, 13);
            // 
            // SearchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.layoutControl);
            this.Controls.Add(this.ribbonControl);
            this.Name = "SearchView";
            this.Text = "Поиск";
            this.Load += new System.EventHandler(this.SearchView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusLayoutControlItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup searchRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem searchBarButtonItem;
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraGrid.GridControl resultGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ordersGridView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.ComboBox statusComboBox;
        private DevExpress.XtraLayout.LayoutControlItem statusLayoutControlItem;
        private System.Windows.Forms.BindingSource searchViewModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colcountOfGoods;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCost;
        private DevExpress.XtraGrid.Columns.GridColumn colcountOfComments;
    }
}