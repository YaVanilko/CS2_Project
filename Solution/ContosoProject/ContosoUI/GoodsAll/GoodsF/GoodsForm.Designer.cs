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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.GoodsPrintButton = new System.Windows.Forms.Button();
            this.IsActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.GoodsButtonSave = new System.Windows.Forms.Button();
            this.GoodsGridControl = new DevExpress.XtraGrid.GridControl();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.GoodsComboBoxCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSKU1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsComboBoxCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.GoodsPrintButton);
            this.layoutControl1.Controls.Add(this.IsActiveCheckBox);
            this.layoutControl1.Controls.Add(this.GoodsButtonSave);
            this.layoutControl1.Controls.Add(this.GoodsGridControl);
            this.layoutControl1.Controls.Add(this.GoodsComboBoxCategory);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(336, 181, 409, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(871, 379);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // GoodsPrintButton
            // 
            this.GoodsPrintButton.Location = new System.Drawing.Point(541, 12);
            this.GoodsPrintButton.Name = "GoodsPrintButton";
            this.GoodsPrintButton.Size = new System.Drawing.Size(148, 20);
            this.GoodsPrintButton.TabIndex = 8;
            this.GoodsPrintButton.Text = "Печать";
            this.GoodsPrintButton.UseVisualStyleBackColor = true;
            this.GoodsPrintButton.Click += new System.EventHandler(this.GoodsPrintButton_Click);
            // 
            // IsActiveCheckBox
            // 
            this.IsActiveCheckBox.Location = new System.Drawing.Point(436, 12);
            this.IsActiveCheckBox.Name = "IsActiveCheckBox";
            this.IsActiveCheckBox.Size = new System.Drawing.Size(101, 20);
            this.IsActiveCheckBox.TabIndex = 7;
            this.IsActiveCheckBox.Text = "Товар активен";
            this.IsActiveCheckBox.UseVisualStyleBackColor = true;
            this.IsActiveCheckBox.CheckedChanged += new System.EventHandler(this.IsActiveCheckBox_CheckedChanged);
            // 
            // GoodsButtonSave
            // 
            this.GoodsButtonSave.Location = new System.Drawing.Point(693, 12);
            this.GoodsButtonSave.Name = "GoodsButtonSave";
            this.GoodsButtonSave.Size = new System.Drawing.Size(166, 20);
            this.GoodsButtonSave.TabIndex = 6;
            this.GoodsButtonSave.Text = "Сохранить";
            this.GoodsButtonSave.UseVisualStyleBackColor = true;
            this.GoodsButtonSave.Click += new System.EventHandler(this.GoodsButtonSave_Click);
            // 
            // GoodsGridControl
            // 
            this.GoodsGridControl.DataSource = this.goodsBindingSource;
            gridLevelNode1.RelationName = "Level1";
            this.GoodsGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.GoodsGridControl.Location = new System.Drawing.Point(12, 52);
            this.GoodsGridControl.MainView = this.gridView1;
            this.GoodsGridControl.Name = "GoodsGridControl";
            this.GoodsGridControl.Size = new System.Drawing.Size(847, 315);
            this.GoodsGridControl.TabIndex = 5;
            this.GoodsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            this.GoodsGridControl.Click += new System.EventHandler(this.GoodsGridControl_Click);
            this.GoodsGridControl.DoubleClick += new System.EventHandler(this.GoodsGridControl_Click);
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataSource = typeof(Domain.Entities.Goods);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colSKU,
            this.colPrice,
            this.colCount,
            this.colCategory,
            this.colUser,
            this.colId,
            this.colIsActive,
            this.colEditTime});
            this.gridView1.GridControl = this.GoodsGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
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
            this.colUser.Visible = true;
            this.colUser.VisibleIndex = 5;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 6;
            // 
            // colIsActive
            // 
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 7;
            // 
            // colEditTime
            // 
            this.colEditTime.FieldName = "EditTime";
            this.colEditTime.Name = "colEditTime";
            this.colEditTime.Visible = true;
            this.colEditTime.VisibleIndex = 8;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.GoodsGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // GoodsComboBoxCategory
            // 
            this.GoodsComboBoxCategory.EditValue = "Категории продуктов";
            this.GoodsComboBoxCategory.Location = new System.Drawing.Point(108, 12);
            this.GoodsComboBoxCategory.Name = "GoodsComboBoxCategory";
            this.GoodsComboBoxCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GoodsComboBoxCategory.Size = new System.Drawing.Size(324, 20);
            this.GoodsComboBoxCategory.StyleController = this.layoutControl1;
            this.GoodsComboBoxCategory.TabIndex = 4;
            this.GoodsComboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.GoodsComboBoxCategory_SelectedIndexChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(871, 379);
            this.layoutControlGroup1.Text = " ";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.GoodsGridControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(851, 335);
            this.layoutControlItem2.Text = " ";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.GoodsComboBoxCategory;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(424, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.GoodsButtonSave;
            this.layoutControlItem3.Location = new System.Drawing.Point(681, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(170, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.IsActiveCheckBox;
            this.layoutControlItem4.Location = new System.Drawing.Point(424, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(105, 24);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.GoodsPrintButton;
            this.layoutControlItem5.Location = new System.Drawing.Point(529, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(152, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
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
            // GoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 379);
            this.Controls.Add(this.layoutControl1);
            this.Name = "GoodsForm";
            this.Text = "GoodsForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GoodsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsComboBoxCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl GoodsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.ComboBoxEdit GoodsComboBoxCategory;
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
        private System.Windows.Forms.CheckBox IsActiveCheckBox;
        private System.Windows.Forms.Button GoodsButtonSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.Button GoodsPrintButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colSKU1;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice1;
        private DevExpress.XtraGrid.Columns.GridColumn colCount1;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory1;
        private DevExpress.XtraGrid.Columns.GridColumn colUser1;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive1;
    }
}