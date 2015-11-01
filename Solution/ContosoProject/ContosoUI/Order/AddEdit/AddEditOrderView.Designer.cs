namespace ContosoUI.Order
{
    partial class AddEditOrderView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditOrderView));
            this.mainLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.priceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.saveOrderButton = new DevExpress.XtraBars.BarButtonItem();
            this.saveAndNewOrderButton = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.saveRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.countTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.addGoodsButton = new DevExpress.XtraEditors.SimpleButton();
            this.addCommentsButton = new DevExpress.XtraEditors.SimpleButton();
            this.commentsComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.commetnsListBox = new DevExpress.XtraEditors.ListBoxControl();
            this.goodsRowGridControl = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.goodsRowGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGoods = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customerComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.goodComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.customerLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.goodLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.goodsLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.countofGoodslayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.statusLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.priceLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).BeginInit();
            this.mainLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commetnsListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsRowGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsRowGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countofGoodslayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutControl
            // 
            this.mainLayoutControl.Controls.Add(this.priceTextEdit);
            this.mainLayoutControl.Controls.Add(this.statusComboBoxEdit);
            this.mainLayoutControl.Controls.Add(this.countTextEdit);
            this.mainLayoutControl.Controls.Add(this.addGoodsButton);
            this.mainLayoutControl.Controls.Add(this.addCommentsButton);
            this.mainLayoutControl.Controls.Add(this.commentsComboBoxEdit);
            this.mainLayoutControl.Controls.Add(this.commetnsListBox);
            this.mainLayoutControl.Controls.Add(this.goodsRowGridControl);
            this.mainLayoutControl.Controls.Add(this.customerComboBoxEdit);
            this.mainLayoutControl.Controls.Add(this.goodComboBoxEdit);
            this.mainLayoutControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainLayoutControl.Location = new System.Drawing.Point(0, 140);
            this.mainLayoutControl.Name = "mainLayoutControl";
            this.mainLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(878, 363, 250, 350);
            this.mainLayoutControl.Root = this.layoutControlGroup;
            this.mainLayoutControl.Size = new System.Drawing.Size(784, 421);
            this.mainLayoutControl.TabIndex = 0;
            this.mainLayoutControl.Text = "layoutControl1";
            // 
            // priceTextEdit
            // 
            this.priceTextEdit.Location = new System.Drawing.Point(297, 389);
            this.priceTextEdit.MenuManager = this.mainRibbonControl;
            this.priceTextEdit.Name = "priceTextEdit";
            this.priceTextEdit.Size = new System.Drawing.Size(475, 20);
            this.priceTextEdit.StyleController = this.mainLayoutControl;
            this.priceTextEdit.TabIndex = 28;
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.saveOrderButton,
            this.saveAndNewOrderButton});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 11;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.Size = new System.Drawing.Size(784, 141);
            // 
            // saveOrderButton
            // 
            this.saveOrderButton.Caption = "Сохранить";
            this.saveOrderButton.Glyph = ((System.Drawing.Image)(resources.GetObject("saveOrderButton.Glyph")));
            this.saveOrderButton.Id = 1;
            this.saveOrderButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("saveOrderButton.LargeGlyph")));
            this.saveOrderButton.Name = "saveOrderButton";
            // 
            // saveAndNewOrderButton
            // 
            this.saveAndNewOrderButton.Caption = "Сохранить и Добавить";
            this.saveAndNewOrderButton.Glyph = ((System.Drawing.Image)(resources.GetObject("saveAndNewOrderButton.Glyph")));
            this.saveAndNewOrderButton.Id = 2;
            this.saveAndNewOrderButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("saveAndNewOrderButton.LargeGlyph")));
            this.saveAndNewOrderButton.Name = "saveAndNewOrderButton";
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
            this.saveRibbonPageGroup.ItemLinks.Add(this.saveOrderButton);
            this.saveRibbonPageGroup.ItemLinks.Add(this.saveAndNewOrderButton);
            this.saveRibbonPageGroup.MergeOrder = 30;
            this.saveRibbonPageGroup.Name = "saveRibbonPageGroup";
            this.saveRibbonPageGroup.Text = "Сохранить";
            // 
            // statusComboBoxEdit
            // 
            this.statusComboBoxEdit.Location = new System.Drawing.Point(12, 68);
            this.statusComboBoxEdit.MenuManager = this.mainRibbonControl;
            this.statusComboBoxEdit.Name = "statusComboBoxEdit";
            this.statusComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.statusComboBoxEdit.Size = new System.Drawing.Size(281, 20);
            this.statusComboBoxEdit.StyleController = this.mainLayoutControl;
            this.statusComboBoxEdit.TabIndex = 26;
            // 
            // countTextEdit
            // 
            this.countTextEdit.Location = new System.Drawing.Point(597, 28);
            this.countTextEdit.Name = "countTextEdit";
            this.countTextEdit.Size = new System.Drawing.Size(93, 20);
            this.countTextEdit.StyleController = this.mainLayoutControl;
            this.countTextEdit.TabIndex = 27;
            // 
            // addGoodsButton
            // 
            this.addGoodsButton.Location = new System.Drawing.Point(694, 12);
            this.addGoodsButton.Name = "addGoodsButton";
            this.addGoodsButton.Size = new System.Drawing.Size(78, 36);
            this.addGoodsButton.StyleController = this.mainLayoutControl;
            this.addGoodsButton.TabIndex = 24;
            this.addGoodsButton.Text = "Добавить";
            // 
            // addCommentsButton
            // 
            this.addCommentsButton.Location = new System.Drawing.Point(218, 373);
            this.addCommentsButton.Name = "addCommentsButton";
            this.addCommentsButton.Size = new System.Drawing.Size(75, 36);
            this.addCommentsButton.StyleController = this.mainLayoutControl;
            this.addCommentsButton.TabIndex = 23;
            this.addCommentsButton.Text = "Добавить";
            // 
            // commentsComboBoxEdit
            // 
            this.commentsComboBoxEdit.Location = new System.Drawing.Point(12, 389);
            this.commentsComboBoxEdit.MenuManager = this.mainRibbonControl;
            this.commentsComboBoxEdit.Name = "commentsComboBoxEdit";
            this.commentsComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.commentsComboBoxEdit.Size = new System.Drawing.Size(202, 20);
            this.commentsComboBoxEdit.StyleController = this.mainLayoutControl;
            this.commentsComboBoxEdit.TabIndex = 21;
            // 
            // commetnsListBox
            // 
            this.commetnsListBox.Location = new System.Drawing.Point(12, 92);
            this.commetnsListBox.Name = "commetnsListBox";
            this.commetnsListBox.Size = new System.Drawing.Size(281, 277);
            this.commetnsListBox.StyleController = this.mainLayoutControl;
            this.commetnsListBox.TabIndex = 20;
            // 
            // goodsRowGridControl
            // 
            this.goodsRowGridControl.DataSource = this.bindingSource1;
            this.goodsRowGridControl.Location = new System.Drawing.Point(297, 68);
            this.goodsRowGridControl.MainView = this.goodsRowGridView;
            this.goodsRowGridControl.MenuManager = this.mainRibbonControl;
            this.goodsRowGridControl.Name = "goodsRowGridControl";
            this.goodsRowGridControl.Size = new System.Drawing.Size(475, 301);
            this.goodsRowGridControl.TabIndex = 19;
            this.goodsRowGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.goodsRowGridView});
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Domain.Entities.GoodsRow);
            // 
            // goodsRowGridView
            // 
            this.goodsRowGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGoods,
            this.colCount,
            this.colPrice,
            this.colTotalPrice});
            this.goodsRowGridView.GridControl = this.goodsRowGridControl;
            this.goodsRowGridView.Name = "goodsRowGridView";
            // 
            // colGoods
            // 
            this.colGoods.Caption = "Товар";
            this.colGoods.FieldName = "Goods";
            this.colGoods.Name = "colGoods";
            this.colGoods.Visible = true;
            this.colGoods.VisibleIndex = 0;
            this.colGoods.Width = 308;
            // 
            // colCount
            // 
            this.colCount.Caption = "Кол-во";
            this.colCount.FieldName = "Count";
            this.colCount.Name = "colCount";
            this.colCount.Visible = true;
            this.colCount.VisibleIndex = 1;
            this.colCount.Width = 39;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Цена";
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 2;
            this.colPrice.Width = 38;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "Общая цена";
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 3;
            this.colTotalPrice.Width = 72;
            // 
            // customerComboBoxEdit
            // 
            this.customerComboBoxEdit.Location = new System.Drawing.Point(12, 28);
            this.customerComboBoxEdit.MenuManager = this.mainRibbonControl;
            this.customerComboBoxEdit.Name = "customerComboBoxEdit";
            this.customerComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customerComboBoxEdit.Size = new System.Drawing.Size(281, 20);
            this.customerComboBoxEdit.StyleController = this.mainLayoutControl;
            this.customerComboBoxEdit.TabIndex = 5;
            // 
            // goodComboBoxEdit
            // 
            this.goodComboBoxEdit.Location = new System.Drawing.Point(297, 28);
            this.goodComboBoxEdit.MenuManager = this.mainRibbonControl;
            this.goodComboBoxEdit.Name = "goodComboBoxEdit";
            this.goodComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.goodComboBoxEdit.Size = new System.Drawing.Size(296, 20);
            this.goodComboBoxEdit.StyleController = this.mainLayoutControl;
            this.goodComboBoxEdit.TabIndex = 4;
            this.goodComboBoxEdit.SelectedIndexChanged += new System.EventHandler(this.goodComboBoxEdit_SelectedIndexChanged);
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.customerLayoutControlItem,
            this.goodLayoutControlItem,
            this.goodsLayoutControlItem,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.countofGoodslayoutControlItem,
            this.statusLayoutControlItem,
            this.priceLayoutControlItem});
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "Root";
            this.layoutControlGroup.Size = new System.Drawing.Size(784, 421);
            this.layoutControlGroup.TextVisible = false;
            // 
            // customerLayoutControlItem
            // 
            this.customerLayoutControlItem.Control = this.customerComboBoxEdit;
            this.customerLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.customerLayoutControlItem.Name = "customerLayoutControlItem";
            this.customerLayoutControlItem.Size = new System.Drawing.Size(285, 40);
            this.customerLayoutControlItem.Text = "Клиент";
            this.customerLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.customerLayoutControlItem.TextSize = new System.Drawing.Size(81, 13);
            // 
            // goodLayoutControlItem
            // 
            this.goodLayoutControlItem.Control = this.goodComboBoxEdit;
            this.goodLayoutControlItem.Location = new System.Drawing.Point(285, 0);
            this.goodLayoutControlItem.Name = "goodLayoutControlItem";
            this.goodLayoutControlItem.Size = new System.Drawing.Size(300, 40);
            this.goodLayoutControlItem.Text = "Товар";
            this.goodLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.goodLayoutControlItem.TextSize = new System.Drawing.Size(81, 13);
            // 
            // goodsLayoutControlItem
            // 
            this.goodsLayoutControlItem.Control = this.goodsRowGridControl;
            this.goodsLayoutControlItem.Location = new System.Drawing.Point(285, 40);
            this.goodsLayoutControlItem.Name = "goodsLayoutControlItem";
            this.goodsLayoutControlItem.Size = new System.Drawing.Size(479, 321);
            this.goodsLayoutControlItem.Text = "Список товаров";
            this.goodsLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.goodsLayoutControlItem.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.commetnsListBox;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(285, 281);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.commentsComboBoxEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 361);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(206, 40);
            this.layoutControlItem3.Text = "Комментарий";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.addCommentsButton;
            this.layoutControlItem5.Location = new System.Drawing.Point(206, 361);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(65, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(79, 40);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.addGoodsButton;
            this.layoutControlItem6.Location = new System.Drawing.Point(682, 0);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(82, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(82, 40);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // countofGoodslayoutControlItem
            // 
            this.countofGoodslayoutControlItem.Control = this.countTextEdit;
            this.countofGoodslayoutControlItem.Location = new System.Drawing.Point(585, 0);
            this.countofGoodslayoutControlItem.Name = "countofGoodslayoutControlItem";
            this.countofGoodslayoutControlItem.Size = new System.Drawing.Size(97, 40);
            this.countofGoodslayoutControlItem.Text = "Кол-во";
            this.countofGoodslayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.countofGoodslayoutControlItem.TextSize = new System.Drawing.Size(81, 13);
            // 
            // statusLayoutControlItem
            // 
            this.statusLayoutControlItem.Control = this.statusComboBoxEdit;
            this.statusLayoutControlItem.Location = new System.Drawing.Point(0, 40);
            this.statusLayoutControlItem.Name = "statusLayoutControlItem";
            this.statusLayoutControlItem.Size = new System.Drawing.Size(285, 40);
            this.statusLayoutControlItem.Text = "Статус";
            this.statusLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.statusLayoutControlItem.TextSize = new System.Drawing.Size(81, 13);
            // 
            // priceLayoutControlItem
            // 
            this.priceLayoutControlItem.Control = this.priceTextEdit;
            this.priceLayoutControlItem.Location = new System.Drawing.Point(285, 361);
            this.priceLayoutControlItem.Name = "priceLayoutControlItem";
            this.priceLayoutControlItem.Size = new System.Drawing.Size(479, 40);
            this.priceLayoutControlItem.Text = "Цена";
            this.priceLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.priceLayoutControlItem.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem
            // 
            this.layoutControlItem.Location = new System.Drawing.Point(382, 120);
            this.layoutControlItem.Name = "layoutControlItem7";
            this.layoutControlItem.Size = new System.Drawing.Size(382, 281);
            this.layoutControlItem.TextSize = new System.Drawing.Size(50, 20);
            // 
            // AddEditOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mainRibbonControl);
            this.Controls.Add(this.mainLayoutControl);
            this.Name = "AddEditOrderView";
            this.Text = "Добавить/Редактировать заказ";
            this.Load += new System.EventHandler(this.AddEditOrderView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).EndInit();
            this.mainLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.priceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commetnsListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsRowGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsRowGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countofGoodslayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl mainLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraEditors.ComboBoxEdit goodComboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlItem goodLayoutControlItem;
        private DevExpress.XtraEditors.ComboBoxEdit customerComboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlItem customerLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem;
        private DevExpress.XtraBars.BarButtonItem saveOrderButton;
        private DevExpress.XtraBars.BarButtonItem saveAndNewOrderButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup saveRibbonPageGroup;
        private DevExpress.XtraEditors.SimpleButton addGoodsButton;
        private DevExpress.XtraEditors.SimpleButton addCommentsButton;
        private DevExpress.XtraEditors.ComboBoxEdit commentsComboBoxEdit;
        private DevExpress.XtraEditors.ListBoxControl commetnsListBox;
        private DevExpress.XtraGrid.GridControl goodsRowGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView goodsRowGridView;
        private DevExpress.XtraLayout.LayoutControlItem goodsLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.TextEdit countTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem countofGoodslayoutControlItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colGoods;
        private DevExpress.XtraGrid.Columns.GridColumn colCount;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraEditors.ComboBoxEdit statusComboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlItem statusLayoutControlItem;
        private DevExpress.XtraEditors.TextEdit priceTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem priceLayoutControlItem;
    }
}