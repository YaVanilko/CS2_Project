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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchView));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.searchBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.searchRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.resultGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.statusLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.searchViewModelBindingSource = new System.Windows.Forms.BindingSource();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcountOfGoods = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcountOfComments = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewModelBindingSource)).BeginInit();
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
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.searchRibbonPageGroup});
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Главная";
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
            this.statusComboBox.Location = new System.Drawing.Point(51, 12);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(721, 21);
            this.statusComboBox.TabIndex = 5;
            // 
            // resultGridControl
            // 
            this.resultGridControl.DataSource = this.searchViewModelBindingSource;
            this.resultGridControl.Location = new System.Drawing.Point(12, 37);
            this.resultGridControl.MainView = this.gridView1;
            this.resultGridControl.MenuManager = this.ribbonControl;
            this.resultGridControl.Name = "resultGridControl";
            this.resultGridControl.Size = new System.Drawing.Size(760, 375);
            this.resultGridControl.TabIndex = 4;
            this.resultGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomer,
            this.colcountOfGoods,
            this.colTotalCost,
            this.colStatus,
            this.colcountOfComments});
            this.gridView1.GridControl = this.resultGridControl;
            this.gridView1.Name = "gridView1";
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
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 25);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(764, 379);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // statusLayoutControlItem
            // 
            this.statusLayoutControlItem.Control = this.statusComboBox;
            this.statusLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.statusLayoutControlItem.Name = "statusLayoutControlItem";
            this.statusLayoutControlItem.Size = new System.Drawing.Size(764, 25);
            this.statusLayoutControlItem.Text = "Статус";
            this.statusLayoutControlItem.TextSize = new System.Drawing.Size(36, 13);
            // 
            // searchViewModelBindingSource
            // 
            this.searchViewModelBindingSource.DataSource = typeof(ContosoUI.Order.Search.SearchViewModel);
            // 
            // colCustomer
            // 
            this.colCustomer.FieldName = "Customer";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 0;
            // 
            // colcountOfGoods
            // 
            this.colcountOfGoods.FieldName = "countOfGoods";
            this.colcountOfGoods.Name = "colcountOfGoods";
            this.colcountOfGoods.Visible = true;
            this.colcountOfGoods.VisibleIndex = 1;
            // 
            // colTotalCost
            // 
            this.colTotalCost.FieldName = "TotalCost";
            this.colTotalCost.Name = "colTotalCost";
            this.colTotalCost.Visible = true;
            this.colTotalCost.VisibleIndex = 2;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 3;
            // 
            // colcountOfComments
            // 
            this.colcountOfComments.FieldName = "countOfComments";
            this.colcountOfComments.Name = "colcountOfComments";
            this.colcountOfComments.Visible = true;
            this.colcountOfComments.VisibleIndex = 4;
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
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewModelBindingSource)).EndInit();
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
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.ComboBox statusComboBox;
        private DevExpress.XtraLayout.LayoutControlItem statusLayoutControlItem;
        private System.Windows.Forms.BindingSource searchViewModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colcountOfGoods;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCost;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colcountOfComments;
    }
}