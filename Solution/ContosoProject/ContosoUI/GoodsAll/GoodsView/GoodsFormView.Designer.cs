namespace ContosoUI.GoodsAll.GoodsF
{
    partial class GoodsForm
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodsForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.goodsGridControl = new DevExpress.XtraGrid.GridControl();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsGreedView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSKU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.goodsComboBoxCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSKU1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.exportBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.printBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.SearchbarButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.saveOrEditribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.searchRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsGreedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsComboBoxCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.isActiveCheckBox);
            this.layoutControl1.Controls.Add(this.goodsGridControl);
            this.layoutControl1.Controls.Add(this.goodsComboBoxCategory);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(336, 181, 409, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(871, 379);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.Location = new System.Drawing.Point(436, 12);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(423, 20);
            this.isActiveCheckBox.TabIndex = 7;
            this.isActiveCheckBox.Text = "Товар активен";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            this.isActiveCheckBox.CheckedChanged += new System.EventHandler(this.IsActiveCheckBox_CheckedChanged);
            // 
            // goodsGridControl
            // 
            this.goodsGridControl.DataSource = this.goodsBindingSource;
            gridLevelNode1.RelationName = "Level1";
            this.goodsGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.goodsGridControl.Location = new System.Drawing.Point(12, 52);
            this.goodsGridControl.MainView = this.goodsGreedView;
            this.goodsGridControl.Name = "goodsGridControl";
            this.goodsGridControl.Size = new System.Drawing.Size(847, 315);
            this.goodsGridControl.TabIndex = 5;
            this.goodsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.goodsGreedView,
            this.gridView2});
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataSource = typeof(Domain.Entities.Goods);
            // 
            // goodsGreedView
            // 
            this.goodsGreedView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colSKU,
            this.colPrice,
            this.colCount,
            this.colCategory,
            this.colUser,
            this.colId,
            this.colIsActive,
            this.colEditTime});
            this.goodsGreedView.GridControl = this.goodsGridControl;
            this.goodsGreedView.Name = "goodsGreedView";
            this.goodsGreedView.OptionsBehavior.Editable = false;
            this.goodsGreedView.DoubleClick += new System.EventHandler(this.goodsGreedView_DoubleClick);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colSKU
            // 
            this.colSKU.FieldName = "SKU";
            this.colSKU.Name = "colSKU";
            this.colSKU.Visible = true;
            this.colSKU.VisibleIndex = 1;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 2;
            // 
            // colCount
            // 
            this.colCount.FieldName = "Count";
            this.colCount.Name = "colCount";
            this.colCount.Visible = true;
            this.colCount.VisibleIndex = 3;
            // 
            // colCategory
            // 
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 4;
            // 
            // colUser
            // 
            this.colUser.FieldName = "User";
            this.colUser.Name = "colUser";
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
            // gridView2
            // 
            this.gridView2.GridControl = this.goodsGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // goodsComboBoxCategory
            // 
            this.goodsComboBoxCategory.EditValue = "";
            this.goodsComboBoxCategory.Location = new System.Drawing.Point(121, 12);
            this.goodsComboBoxCategory.Name = "goodsComboBoxCategory";
            this.goodsComboBoxCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.goodsComboBoxCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.goodsComboBoxCategory.Size = new System.Drawing.Size(311, 20);
            this.goodsComboBoxCategory.StyleController = this.layoutControl1;
            this.goodsComboBoxCategory.TabIndex = 4;
            this.goodsComboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.GoodsComboBoxCategory_SelectedIndexChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(871, 379);
            this.layoutControlGroup1.Text = " ";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.goodsGridControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(851, 335);
            this.layoutControlItem2.Text = " ";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.goodsComboBoxCategory;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(424, 24);
            this.layoutControlItem1.Text = "Категория продукта";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.isActiveCheckBox;
            this.layoutControlItem4.Location = new System.Drawing.Point(424, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(427, 24);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            // 
            // colSKU1
            // 
            this.colSKU1.FieldName = "SKU";
            this.colSKU1.Name = "colSKU1";
            // 
            // colPrice1
            // 
            this.colPrice1.FieldName = "Price";
            this.colPrice1.Name = "colPrice1";
            // 
            // colCount1
            // 
            this.colCount1.FieldName = "Count";
            this.colCount1.Name = "colCount1";
            // 
            // colCategory1
            // 
            this.colCategory1.FieldName = "Category";
            this.colCategory1.Name = "colCategory1";
            // 
            // colUser1
            // 
            this.colUser1.FieldName = "User";
            this.colUser1.Name = "colUser1";
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            // 
            // colIsActive1
            // 
            this.colIsActive1.FieldName = "IsActive";
            this.colIsActive1.Name = "colIsActive1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.exportBarButtonItem,
            this.printBarButtonItem,
            this.SearchbarButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.ribbonControl1.Size = new System.Drawing.Size(871, 141);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // exportBarButtonItem
            // 
            this.exportBarButtonItem.Caption = "Экспорт";
            this.exportBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("exportBarButtonItem.Glyph")));
            this.exportBarButtonItem.Id = 1;
            this.exportBarButtonItem.Name = "exportBarButtonItem";
            this.exportBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.exportBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.exportBarButtonItem_ItemClick);
            // 
            // printBarButtonItem
            // 
            this.printBarButtonItem.Caption = "Печать";
            this.printBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("printBarButtonItem.Glyph")));
            this.printBarButtonItem.Id = 3;
            this.printBarButtonItem.Name = "printBarButtonItem";
            this.printBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // SearchbarButtonItem1
            // 
            this.SearchbarButtonItem1.Caption = "Поиск";
            this.SearchbarButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("SearchbarButtonItem1.Glyph")));
            this.SearchbarButtonItem1.Id = 5;
            this.SearchbarButtonItem1.MergeOrder = 1;
            this.SearchbarButtonItem1.Name = "SearchbarButtonItem1";
            this.SearchbarButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.SearchbarButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SearchbarButtonItem1_ItemClick);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.saveOrEditribbonPageGroup,
            this.searchRibbonPageGroup});
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Меню";
            // 
            // saveOrEditribbonPageGroup
            // 
            this.saveOrEditribbonPageGroup.ItemLinks.Add(this.exportBarButtonItem);
            this.saveOrEditribbonPageGroup.ItemLinks.Add(this.printBarButtonItem);
            this.saveOrEditribbonPageGroup.MergeOrder = 5;
            this.saveOrEditribbonPageGroup.Name = "saveOrEditribbonPageGroup";
            this.saveOrEditribbonPageGroup.Text = "Сохранение";
            // 
            // searchRibbonPageGroup
            // 
            this.searchRibbonPageGroup.ItemLinks.Add(this.SearchbarButtonItem1);
            this.searchRibbonPageGroup.MergeOrder = 6;
            this.searchRibbonPageGroup.Name = "searchRibbonPageGroup";
            this.searchRibbonPageGroup.Text = "Поиск";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // GoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 379);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.layoutControl1);
            this.Name = "GoodsForm";
            this.Text = "Список товаров";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.goodsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsGreedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsComboBoxCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl goodsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView goodsGreedView;
        private DevExpress.XtraEditors.ComboBoxEdit goodsComboBoxCategory;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSKU;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCount;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colUser;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colEditTime;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colSKU1;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice1;
        private DevExpress.XtraGrid.Columns.GridColumn colCount1;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory1;
        private DevExpress.XtraGrid.Columns.GridColumn colUser1;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem exportBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem printBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup saveOrEditribbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup searchRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem SearchbarButtonItem1;
    }
}