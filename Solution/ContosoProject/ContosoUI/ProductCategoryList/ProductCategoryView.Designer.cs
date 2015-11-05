namespace ContosoUI.ProductCategoryList
{
    partial class ProductCategoryView
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
            this.categoryAddOrEditRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.saveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.saveButton = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.saveRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.categoryViewLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.productCategoryGridControl = new DevExpress.XtraGrid.GridControl();
            this.productCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.categoryLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.productCategoryControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.categoryAddOrEditRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryViewLayoutControl)).BeginInit();
            this.categoryViewLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryControlItem)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryAddOrEditRibbonControl
            // 
            this.categoryAddOrEditRibbonControl.ExpandCollapseItem.Id = 0;
            this.categoryAddOrEditRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.categoryAddOrEditRibbonControl.ExpandCollapseItem,
            this.saveAndNew,
            this.saveButton});
            this.categoryAddOrEditRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.categoryAddOrEditRibbonControl.MaxItemId = 3;
            this.categoryAddOrEditRibbonControl.Name = "categoryAddOrEditRibbonControl";
            this.categoryAddOrEditRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.categoryAddOrEditRibbonControl.Size = new System.Drawing.Size(805, 141);
            // 
            // saveAndNew
            // 
            this.saveAndNew.Caption = "Добавить";
            this.saveAndNew.Id = 1;
            this.saveAndNew.ImageUri.Uri = "SaveAndNew";
            this.saveAndNew.Name = "saveAndNew";
            this.saveAndNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveAndNew_ItemClick);
            // 
            // saveButton
            // 
            this.saveButton.Caption = "Сохранить";
            this.saveButton.Id = 2;
            this.saveButton.ImageUri.Uri = "Save";
            this.saveButton.Name = "saveButton";
            this.saveButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveButton_ItemClick);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.saveRibbonPageGroup});
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Меню";
            // 
            // saveRibbonPageGroup
            // 
            this.saveRibbonPageGroup.ItemLinks.Add(this.saveAndNew);
            this.saveRibbonPageGroup.ItemLinks.Add(this.saveButton);
            this.saveRibbonPageGroup.MergeOrder = 5;
            this.saveRibbonPageGroup.Name = "saveRibbonPageGroup";
            this.saveRibbonPageGroup.Text = "Сохранение";
            // 
            // categoryViewLayoutControl
            // 
            this.categoryViewLayoutControl.Controls.Add(this.productCategoryGridControl);
            this.categoryViewLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryViewLayoutControl.Location = new System.Drawing.Point(0, 141);
            this.categoryViewLayoutControl.Name = "categoryViewLayoutControl";
            this.categoryViewLayoutControl.Root = this.categoryLayoutControlGroup;
            this.categoryViewLayoutControl.Size = new System.Drawing.Size(805, 358);
            this.categoryViewLayoutControl.TabIndex = 1;
            this.categoryViewLayoutControl.Text = "layoutControl1";
            // 
            // productCategoryGridControl
            // 
            this.productCategoryGridControl.DataSource = this.productCategoryBindingSource;
            this.productCategoryGridControl.Location = new System.Drawing.Point(12, 12);
            this.productCategoryGridControl.MainView = this.categoriesGridView;
            this.productCategoryGridControl.MenuManager = this.categoryAddOrEditRibbonControl;
            this.productCategoryGridControl.Name = "productCategoryGridControl";
            this.productCategoryGridControl.Size = new System.Drawing.Size(781, 334);
            this.productCategoryGridControl.TabIndex = 4;
            this.productCategoryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.categoriesGridView});
            // 
            // productCategoryBindingSource
            // 
            this.productCategoryBindingSource.DataSource = typeof(Domain.Entities.ProductCategory);
            // 
            // categoriesGridView
            // 
            this.categoriesGridView.ColumnPanelRowHeight = 50;
            this.categoriesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCategoryName,
            this.colId,
            this.colIsActive,
            this.colEditTime});
            this.categoriesGridView.GridControl = this.productCategoryGridControl;
            this.categoriesGridView.Name = "categoriesGridView";
            this.categoriesGridView.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.categoriesGridView.OptionsView.RowAutoHeight = true;
            // 
            // colCategoryName
            // 
            this.colCategoryName.Caption = "Название категории";
            this.colCategoryName.FieldName = "CategoryName";
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.OptionsEditForm.RowSpan = 2;
            this.colCategoryName.OptionsEditForm.VisibleIndex = 2;
            this.colCategoryName.Visible = true;
            this.colCategoryName.VisibleIndex = 1;
            this.colCategoryName.Width = 318;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.OptionsEditForm.VisibleIndex = 1;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 39;
            // 
            // colIsActive
            // 
            this.colIsActive.Caption = "Статус  (активировать / деактивировать)";
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.OptionsEditForm.RowSpan = 2;
            this.colIsActive.OptionsEditForm.VisibleIndex = 3;
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 2;
            this.colIsActive.Width = 213;
            // 
            // colEditTime
            // 
            this.colEditTime.Caption = "Дата редактирования";
            this.colEditTime.FieldName = "EditTime";
            this.colEditTime.Name = "colEditTime";
            this.colEditTime.OptionsColumn.AllowEdit = false;
            this.colEditTime.OptionsColumn.ReadOnly = true;
            this.colEditTime.OptionsEditForm.RowSpan = 2;
            this.colEditTime.OptionsEditForm.VisibleIndex = 4;
            this.colEditTime.Visible = true;
            this.colEditTime.VisibleIndex = 3;
            this.colEditTime.Width = 193;
            // 
            // categoryLayoutControlGroup
            // 
            this.categoryLayoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.categoryLayoutControlGroup.GroupBordersVisible = false;
            this.categoryLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.productCategoryControlItem});
            this.categoryLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.categoryLayoutControlGroup.Name = "categoryLayoutControlGroup";
            this.categoryLayoutControlGroup.Size = new System.Drawing.Size(805, 358);
            this.categoryLayoutControlGroup.TextVisible = false;
            // 
            // productCategoryControlItem
            // 
            this.productCategoryControlItem.Control = this.productCategoryGridControl;
            this.productCategoryControlItem.Location = new System.Drawing.Point(0, 0);
            this.productCategoryControlItem.Name = "productCategoryControlItem";
            this.productCategoryControlItem.Size = new System.Drawing.Size(785, 338);
            this.productCategoryControlItem.Text = "Список категорий товаров";
            this.productCategoryControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.productCategoryControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.productCategoryControlItem.TextVisible = false;
            // 
            // ProductCategoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 499);
            this.Controls.Add(this.categoryViewLayoutControl);
            this.Controls.Add(this.categoryAddOrEditRibbonControl);
            this.Name = "ProductCategoryView";
            this.Text = "Категории товаров";
            this.Load += new System.EventHandler(this.ProductCategoryView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryAddOrEditRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryViewLayoutControl)).EndInit();
            this.categoryViewLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryControlItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl categoryAddOrEditRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup saveRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem saveAndNew;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.BarButtonItem saveButton;
        private DevExpress.XtraLayout.LayoutControl categoryViewLayoutControl;
        private DevExpress.XtraGrid.GridControl productCategoryGridControl;
        private System.Windows.Forms.BindingSource productCategoryBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView categoriesGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colEditTime;
        private DevExpress.XtraLayout.LayoutControlGroup categoryLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem productCategoryControlItem;
    }
}