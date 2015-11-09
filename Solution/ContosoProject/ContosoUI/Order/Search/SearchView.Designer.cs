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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.searchBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.searchRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.resultGridControl = new DevExpress.XtraGrid.GridControl();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoodsList = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.statusLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
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
            this.searchBarButtonItem,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 6;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.ribbonControl.Size = new System.Drawing.Size(784, 141);
            // 
            // searchBarButtonItem
            // 
            this.searchBarButtonItem.Caption = "Искать заказы";
            this.searchBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("searchBarButtonItem.Glyph")));
            this.searchBarButtonItem.Id = 1;
            this.searchBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("searchBarButtonItem.LargeGlyph")));
            this.searchBarButtonItem.Name = "searchBarButtonItem";
            this.searchBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.searchBarButtonItem_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Сохранить";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Печатать";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.searchRibbonPageGroup,
            this.ribbonPageGroup1});
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Меню";
            // 
            // searchRibbonPageGroup
            // 
            this.searchRibbonPageGroup.ItemLinks.Add(this.searchBarButtonItem);
            this.searchRibbonPageGroup.MergeOrder = 5;
            this.searchRibbonPageGroup.Name = "searchRibbonPageGroup";
            this.searchRibbonPageGroup.Text = "Поиск";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.MergeOrder = 6;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Сохранить";
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.statusComboBox);
            this.layoutControl.Controls.Add(this.resultGridControl);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 141);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.layoutControlGroup;
            this.layoutControl.Size = new System.Drawing.Size(784, 420);
            this.layoutControl.TabIndex = 1;
            this.layoutControl.Text = "layoutControl1";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(12, 28);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(760, 21);
            this.statusComboBox.TabIndex = 5;
            // 
            // resultGridControl
            // 
            this.resultGridControl.DataSource = this.orderBindingSource;
            this.resultGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.resultGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.resultGridControl.Location = new System.Drawing.Point(12, 53);
            this.resultGridControl.MainView = this.ordersGridView;
            this.resultGridControl.MenuManager = this.ribbonControl;
            this.resultGridControl.Name = "resultGridControl";
            this.resultGridControl.Size = new System.Drawing.Size(760, 355);
            this.resultGridControl.TabIndex = 4;
            this.resultGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ordersGridView});
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Domain.Entities.Order);
            // 
            // ordersGridView
            // 
            this.ordersGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomer,
            this.colGoodsList,
            this.colTotalCost,
            this.colStatus,
            this.colComments,
            this.colId,
            this.colIsActive,
            this.colEditTime});
            this.ordersGridView.GridControl = this.resultGridControl;
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.OptionsBehavior.Editable = false;
            this.ordersGridView.DoubleClick += new System.EventHandler(this.ordersGridView__DoubleClick);
            // 
            // colCustomer
            // 
            this.colCustomer.Caption = "Клиент";
            this.colCustomer.FieldName = "Customer";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 1;
            this.colCustomer.Width = 312;
            // 
            // colGoodsList
            // 
            this.colGoodsList.Caption = "Список товаров";
            this.colGoodsList.FieldName = "GoodsList";
            this.colGoodsList.Name = "colGoodsList";
            this.colGoodsList.Visible = true;
            this.colGoodsList.VisibleIndex = 2;
            this.colGoodsList.Width = 268;
            // 
            // colTotalCost
            // 
            this.colTotalCost.Caption = "Цена";
            this.colTotalCost.FieldName = "TotalCost";
            this.colTotalCost.Name = "colTotalCost";
            this.colTotalCost.OptionsColumn.ReadOnly = true;
            this.colTotalCost.Visible = true;
            this.colTotalCost.VisibleIndex = 3;
            this.colTotalCost.Width = 85;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Статус";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 0;
            this.colStatus.Width = 77;
            // 
            // colComments
            // 
            this.colComments.FieldName = "Comments";
            this.colComments.Name = "colComments";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colIsActive
            // 
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            // 
            // colEditTime
            // 
            this.colEditTime.FieldName = "EditTime";
            this.colEditTime.Name = "colEditTime";
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.statusLayoutControlItem});
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "Root";
            this.layoutControlGroup.Size = new System.Drawing.Size(784, 420);
            this.layoutControlGroup.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.resultGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 41);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(764, 359);
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
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodsList;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCost;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colComments;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colEditTime;
    }
}