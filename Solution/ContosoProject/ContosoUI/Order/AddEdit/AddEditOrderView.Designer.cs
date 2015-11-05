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
            this.goodsRowGridControl = new DevExpress.XtraGrid.GridControl();
            this.goodsRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGoods = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.saveOrderButton = new DevExpress.XtraBars.BarButtonItem();
            this.saveAndNewOrderButton = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.saveRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.priceEdit = new DevExpress.XtraEditors.TextEdit();
            this.addGoodButton = new DevExpress.XtraEditors.SimpleButton();
            this.addCommentButton = new DevExpress.XtraEditors.SimpleButton();
            this.commentTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.commentsListBox = new DevExpress.XtraEditors.ListBoxControl();
            this.countOfGoodTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.goodsComboBox = new System.Windows.Forms.ComboBox();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.goodLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.statusLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.customerLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.commentLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.priceLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).BeginInit();
            this.mainLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsRowGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsRowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countOfGoodTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutControl
            // 
            this.mainLayoutControl.Controls.Add(this.goodsRowGridControl);
            this.mainLayoutControl.Controls.Add(this.priceEdit);
            this.mainLayoutControl.Controls.Add(this.addGoodButton);
            this.mainLayoutControl.Controls.Add(this.addCommentButton);
            this.mainLayoutControl.Controls.Add(this.commentTextEdit);
            this.mainLayoutControl.Controls.Add(this.commentsListBox);
            this.mainLayoutControl.Controls.Add(this.countOfGoodTextEdit);
            this.mainLayoutControl.Controls.Add(this.goodsComboBox);
            this.mainLayoutControl.Controls.Add(this.customerComboBox);
            this.mainLayoutControl.Controls.Add(this.statusComboBox);
            this.mainLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutControl.Name = "mainLayoutControl";
            this.mainLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(582, 363, 250, 350);
            this.mainLayoutControl.Root = this.layoutControlGroup;
            this.mainLayoutControl.Size = new System.Drawing.Size(784, 561);
            this.mainLayoutControl.TabIndex = 0;
            this.mainLayoutControl.Text = "layoutControl1";
            // 
            // goodsRowGridControl
            // 
            this.goodsRowGridControl.DataSource = this.goodsRowBindingSource;
            this.goodsRowGridControl.Location = new System.Drawing.Point(290, 120);
            this.goodsRowGridControl.MainView = this.ordersGridView;
            this.goodsRowGridControl.MenuManager = this.mainRibbonControl;
            this.goodsRowGridControl.Name = "goodsRowGridControl";
            this.goodsRowGridControl.Size = new System.Drawing.Size(482, 405);
            this.goodsRowGridControl.TabIndex = 20;
            this.goodsRowGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ordersGridView});
            // 
            // goodsRowBindingSource
            // 
            this.goodsRowBindingSource.DataSource = typeof(Domain.Entities.GoodsRow);
            // 
            // ordersGridView
            // 
            this.ordersGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGoods,
            this.colCount,
            this.colPrice,
            this.colTotalPrice,
            this.colId,
            this.colIsActive1,
            this.colEditTime});
            this.ordersGridView.GridControl = this.goodsRowGridControl;
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.ordersGridView_CellValueChanged);
            // 
            // colGoods
            // 
            this.colGoods.Caption = "Товар";
            this.colGoods.FieldName = "Goods";
            this.colGoods.Name = "colGoods";
            this.colGoods.Visible = true;
            this.colGoods.VisibleIndex = 0;
            // 
            // colCount
            // 
            this.colCount.Caption = "Кол-во";
            this.colCount.FieldName = "Count";
            this.colCount.Name = "colCount";
            this.colCount.Visible = true;
            this.colCount.VisibleIndex = 1;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "Цена";
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.OptionsColumn.ReadOnly = true;
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 2;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colIsActive1
            // 
            this.colIsActive1.Caption = "Активен";
            this.colIsActive1.FieldName = "IsActive";
            this.colIsActive1.Name = "colIsActive1";
            this.colIsActive1.Visible = true;
            this.colIsActive1.VisibleIndex = 3;
            // 
            // colEditTime
            // 
            this.colEditTime.FieldName = "EditTime";
            this.colEditTime.Name = "colEditTime";
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.Dock = System.Windows.Forms.DockStyle.None;
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
            this.saveOrderButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveOrderButton_ItemClick);
            // 
            // saveAndNewOrderButton
            // 
            this.saveAndNewOrderButton.Caption = "Сохранить и Добавить";
            this.saveAndNewOrderButton.Glyph = ((System.Drawing.Image)(resources.GetObject("saveAndNewOrderButton.Glyph")));
            this.saveAndNewOrderButton.Id = 2;
            this.saveAndNewOrderButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("saveAndNewOrderButton.LargeGlyph")));
            this.saveAndNewOrderButton.Name = "saveAndNewOrderButton";
            this.saveAndNewOrderButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveAndNewOrderButton_ItemClick);
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
            this.saveRibbonPageGroup.MergeOrder = 5;
            this.saveRibbonPageGroup.Name = "saveRibbonPageGroup";
            this.saveRibbonPageGroup.Text = "Сохранить";
            // 
            // priceEdit
            // 
            this.priceEdit.Enabled = false;
            this.priceEdit.Location = new System.Drawing.Point(82, 529);
            this.priceEdit.MenuManager = this.mainRibbonControl;
            this.priceEdit.Name = "priceEdit";
            this.priceEdit.Properties.ReadOnly = true;
            this.priceEdit.Size = new System.Drawing.Size(690, 20);
            this.priceEdit.StyleController = this.mainLayoutControl;
            this.priceEdit.TabIndex = 9;
            // 
            // addGoodButton
            // 
            this.addGoodButton.Location = new System.Drawing.Point(290, 94);
            this.addGoodButton.Name = "addGoodButton";
            this.addGoodButton.Size = new System.Drawing.Size(482, 22);
            this.addGoodButton.StyleController = this.mainLayoutControl;
            this.addGoodButton.TabIndex = 7;
            this.addGoodButton.Text = "Добавить";
            this.addGoodButton.Click += new System.EventHandler(this.addGoodButton_Click);
            // 
            // addCommentButton
            // 
            this.addCommentButton.Location = new System.Drawing.Point(12, 93);
            this.addCommentButton.Name = "addCommentButton";
            this.addCommentButton.Size = new System.Drawing.Size(274, 22);
            this.addCommentButton.StyleController = this.mainLayoutControl;
            this.addCommentButton.TabIndex = 6;
            this.addCommentButton.Text = "Добавить";
            this.addCommentButton.Click += new System.EventHandler(this.addCommentButton_Click);
            // 
            // commentTextEdit
            // 
            this.commentTextEdit.Location = new System.Drawing.Point(12, 69);
            this.commentTextEdit.MenuManager = this.mainRibbonControl;
            this.commentTextEdit.Name = "commentTextEdit";
            this.commentTextEdit.Size = new System.Drawing.Size(274, 20);
            this.commentTextEdit.StyleController = this.mainLayoutControl;
            this.commentTextEdit.TabIndex = 3;
            // 
            // commentsListBox
            // 
            this.commentsListBox.Location = new System.Drawing.Point(12, 120);
            this.commentsListBox.Name = "commentsListBox";
            this.commentsListBox.Size = new System.Drawing.Size(274, 405);
            this.commentsListBox.StyleController = this.mainLayoutControl;
            this.commentsListBox.TabIndex = 8;
            // 
            // countOfGoodTextEdit
            // 
            this.countOfGoodTextEdit.Location = new System.Drawing.Point(679, 69);
            this.countOfGoodTextEdit.MenuManager = this.mainRibbonControl;
            this.countOfGoodTextEdit.Name = "countOfGoodTextEdit";
            this.countOfGoodTextEdit.Size = new System.Drawing.Size(93, 20);
            this.countOfGoodTextEdit.StyleController = this.mainLayoutControl;
            this.countOfGoodTextEdit.TabIndex = 5;
            // 
            // goodsComboBox
            // 
            this.goodsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.goodsComboBox.FormattingEnabled = true;
            this.goodsComboBox.Location = new System.Drawing.Point(290, 69);
            this.goodsComboBox.Name = "goodsComboBox";
            this.goodsComboBox.Size = new System.Drawing.Size(385, 21);
            this.goodsComboBox.TabIndex = 4;
            // 
            // customerComboBox
            // 
            this.customerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(290, 28);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(482, 21);
            this.customerComboBox.TabIndex = 2;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(12, 28);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(274, 21);
            this.statusComboBox.TabIndex = 0;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.goodLayoutControlItem,
            this.statusLayoutControlItem,
            this.customerLayoutControlItem,
            this.layoutControlItem1,
            this.commentLayoutControlItem,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.priceLayoutControlItem,
            this.gridLayoutControlItem});
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "Root";
            this.layoutControlGroup.Size = new System.Drawing.Size(784, 561);
            this.layoutControlGroup.TextVisible = false;
            // 
            // goodLayoutControlItem
            // 
            this.goodLayoutControlItem.Control = this.goodsComboBox;
            this.goodLayoutControlItem.Location = new System.Drawing.Point(278, 41);
            this.goodLayoutControlItem.Name = "goodLayoutControlItem";
            this.goodLayoutControlItem.Size = new System.Drawing.Size(389, 41);
            this.goodLayoutControlItem.Text = "Товары";
            this.goodLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.goodLayoutControlItem.TextSize = new System.Drawing.Size(67, 13);
            // 
            // statusLayoutControlItem
            // 
            this.statusLayoutControlItem.Control = this.statusComboBox;
            this.statusLayoutControlItem.CustomizationFormText = "Статус";
            this.statusLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.statusLayoutControlItem.Name = "statusLayoutControlItem";
            this.statusLayoutControlItem.Size = new System.Drawing.Size(278, 41);
            this.statusLayoutControlItem.Text = "Статус";
            this.statusLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.statusLayoutControlItem.TextSize = new System.Drawing.Size(67, 13);
            // 
            // customerLayoutControlItem
            // 
            this.customerLayoutControlItem.Control = this.customerComboBox;
            this.customerLayoutControlItem.Location = new System.Drawing.Point(278, 0);
            this.customerLayoutControlItem.Name = "customerLayoutControlItem";
            this.customerLayoutControlItem.Size = new System.Drawing.Size(486, 41);
            this.customerLayoutControlItem.Text = "Клиент";
            this.customerLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.customerLayoutControlItem.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.commentsListBox;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 108);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(278, 409);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // commentLayoutControlItem
            // 
            this.commentLayoutControlItem.Control = this.commentTextEdit;
            this.commentLayoutControlItem.Location = new System.Drawing.Point(0, 41);
            this.commentLayoutControlItem.Name = "commentLayoutControlItem";
            this.commentLayoutControlItem.Size = new System.Drawing.Size(278, 40);
            this.commentLayoutControlItem.Text = "Комментарий";
            this.commentLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.commentLayoutControlItem.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.addCommentButton;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 81);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(278, 27);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.addGoodButton;
            this.layoutControlItem4.Location = new System.Drawing.Point(278, 82);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(82, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(486, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.countOfGoodTextEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(667, 41);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(97, 41);
            this.layoutControlItem2.Text = "Кол-во";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(67, 13);
            // 
            // priceLayoutControlItem
            // 
            this.priceLayoutControlItem.Control = this.priceEdit;
            this.priceLayoutControlItem.Location = new System.Drawing.Point(0, 517);
            this.priceLayoutControlItem.Name = "priceLayoutControlItem";
            this.priceLayoutControlItem.Size = new System.Drawing.Size(764, 24);
            this.priceLayoutControlItem.Text = "Цена заказа";
            this.priceLayoutControlItem.TextSize = new System.Drawing.Size(67, 13);
            // 
            // gridLayoutControlItem
            // 
            this.gridLayoutControlItem.Control = this.goodsRowGridControl;
            this.gridLayoutControlItem.Location = new System.Drawing.Point(278, 108);
            this.gridLayoutControlItem.Name = "gridLayoutControlItem";
            this.gridLayoutControlItem.Size = new System.Drawing.Size(486, 409);
            this.gridLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.gridLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.gridLayoutControlItem.TextVisible = false;
            // 
            // layoutControlItem
            // 
            this.layoutControlItem.Location = new System.Drawing.Point(382, 120);
            this.layoutControlItem.Name = "layoutControlItem7";
            this.layoutControlItem.Size = new System.Drawing.Size(382, 281);
            this.layoutControlItem.TextSize = new System.Drawing.Size(50, 20);
            // 
            // colIsActive
            // 
            this.colIsActive.Caption = "Активен";
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 1;
            // 
            // AddEditOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mainLayoutControl);
            this.Controls.Add(this.mainRibbonControl);
            this.Name = "AddEditOrderView";
            this.Text = "Добавить/Редактировать заказ";
            this.Load += new System.EventHandler(this.AddEditOrderView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).EndInit();
            this.mainLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.goodsRowGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsRowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countOfGoodTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl mainLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem;
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.BarButtonItem saveOrderButton;
        private DevExpress.XtraBars.BarButtonItem saveAndNewOrderButton;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup saveRibbonPageGroup;
        private System.Windows.Forms.ComboBox customerComboBox;
        private DevExpress.XtraLayout.LayoutControlItem customerLayoutControlItem;
        private System.Windows.Forms.ComboBox statusComboBox;
        private DevExpress.XtraLayout.LayoutControlItem statusLayoutControlItem;
        private DevExpress.XtraEditors.TextEdit countOfGoodTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton addGoodButton;
        private DevExpress.XtraEditors.SimpleButton addCommentButton;
        private DevExpress.XtraEditors.TextEdit commentTextEdit;
        private DevExpress.XtraEditors.ListBoxControl commentsListBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem commentLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.ComboBox goodsComboBox;
        private DevExpress.XtraLayout.LayoutControlItem goodLayoutControlItem;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.GridControl goodsRowGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ordersGridView;
        private DevExpress.XtraLayout.LayoutControlItem gridLayoutControlItem;
        private System.Windows.Forms.BindingSource goodsRowBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colGoods;
        private DevExpress.XtraGrid.Columns.GridColumn colCount;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive1;
        private DevExpress.XtraGrid.Columns.GridColumn colEditTime;
        private DevExpress.XtraEditors.TextEdit priceEdit;
        private DevExpress.XtraLayout.LayoutControlItem priceLayoutControlItem;
    }
}