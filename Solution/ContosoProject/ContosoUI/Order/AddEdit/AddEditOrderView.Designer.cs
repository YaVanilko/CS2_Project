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
            this.deleteGoodButton = new DevExpress.XtraEditors.SimpleButton();
            this.priceEdit = new DevExpress.XtraEditors.TextEdit();
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.saveOrderButton = new DevExpress.XtraBars.BarButtonItem();
            this.saveAndNewOrderButton = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.saveRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.addGoodButton = new DevExpress.XtraEditors.SimpleButton();
            this.addCommentButton = new DevExpress.XtraEditors.SimpleButton();
            this.commentTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.commentsListBox = new DevExpress.XtraEditors.ListBoxControl();
            this.countOfGoodTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.goodsComboBox = new System.Windows.Forms.ComboBox();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.goodsRowGridControl = new DevExpress.XtraGrid.GridControl();
            this.addEditViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsRowGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGood = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.goodsLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.goodLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.statusLayoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.customerLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.commentLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.priceLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).BeginInit();
            this.mainLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countOfGoodTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsRowGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEditViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsRowGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusLayoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutControl
            // 
            this.mainLayoutControl.Controls.Add(this.deleteGoodButton);
            this.mainLayoutControl.Controls.Add(this.priceEdit);
            this.mainLayoutControl.Controls.Add(this.addGoodButton);
            this.mainLayoutControl.Controls.Add(this.addCommentButton);
            this.mainLayoutControl.Controls.Add(this.commentTextEdit);
            this.mainLayoutControl.Controls.Add(this.commentsListBox);
            this.mainLayoutControl.Controls.Add(this.countOfGoodTextEdit);
            this.mainLayoutControl.Controls.Add(this.goodsComboBox);
            this.mainLayoutControl.Controls.Add(this.customerComboBox);
            this.mainLayoutControl.Controls.Add(this.goodsRowGridControl);
            this.mainLayoutControl.Controls.Add(this.statusComboBox);
            this.mainLayoutControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainLayoutControl.Location = new System.Drawing.Point(0, 140);
            this.mainLayoutControl.Name = "mainLayoutControl";
            this.mainLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(878, 363, 250, 350);
            this.mainLayoutControl.Root = this.layoutControlGroup;
            this.mainLayoutControl.Size = new System.Drawing.Size(784, 421);
            this.mainLayoutControl.TabIndex = 0;
            this.mainLayoutControl.Text = "layoutControl1";
            // 
            // deleteGoodButton
            // 
            this.deleteGoodButton.Location = new System.Drawing.Point(290, 363);
            this.deleteGoodButton.Name = "deleteGoodButton";
            this.deleteGoodButton.Size = new System.Drawing.Size(482, 22);
            this.deleteGoodButton.StyleController = this.mainLayoutControl;
            this.deleteGoodButton.TabIndex = 44;
            this.deleteGoodButton.Text = "Удалить товар из списка";
            this.deleteGoodButton.Click += new System.EventHandler(this.deleteGoodButton_Click);
            // 
            // priceEdit
            // 
            this.priceEdit.Location = new System.Drawing.Point(96, 389);
            this.priceEdit.MenuManager = this.mainRibbonControl;
            this.priceEdit.Name = "priceEdit";
            this.priceEdit.Properties.ReadOnly = true;
            this.priceEdit.Size = new System.Drawing.Size(676, 20);
            this.priceEdit.StyleController = this.mainLayoutControl;
            this.priceEdit.TabIndex = 43;
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
            this.saveRibbonPageGroup.MergeOrder = 30;
            this.saveRibbonPageGroup.Name = "saveRibbonPageGroup";
            this.saveRibbonPageGroup.Text = "Сохранить";
            // 
            // addGoodButton
            // 
            this.addGoodButton.Location = new System.Drawing.Point(290, 94);
            this.addGoodButton.Name = "addGoodButton";
            this.addGoodButton.Size = new System.Drawing.Size(482, 22);
            this.addGoodButton.StyleController = this.mainLayoutControl;
            this.addGoodButton.TabIndex = 42;
            this.addGoodButton.Text = "Добавить";
            this.addGoodButton.Click += new System.EventHandler(this.addGoodButton_Click);
            // 
            // addCommentButton
            // 
            this.addCommentButton.Location = new System.Drawing.Point(12, 93);
            this.addCommentButton.Name = "addCommentButton";
            this.addCommentButton.Size = new System.Drawing.Size(274, 22);
            this.addCommentButton.StyleController = this.mainLayoutControl;
            this.addCommentButton.TabIndex = 41;
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
            this.commentTextEdit.TabIndex = 40;
            // 
            // commentsListBox
            // 
            this.commentsListBox.Location = new System.Drawing.Point(12, 120);
            this.commentsListBox.Name = "commentsListBox";
            this.commentsListBox.Size = new System.Drawing.Size(274, 265);
            this.commentsListBox.StyleController = this.mainLayoutControl;
            this.commentsListBox.TabIndex = 39;
            // 
            // countOfGoodTextEdit
            // 
            this.countOfGoodTextEdit.Location = new System.Drawing.Point(679, 69);
            this.countOfGoodTextEdit.MenuManager = this.mainRibbonControl;
            this.countOfGoodTextEdit.Name = "countOfGoodTextEdit";
            this.countOfGoodTextEdit.Size = new System.Drawing.Size(93, 20);
            this.countOfGoodTextEdit.StyleController = this.mainLayoutControl;
            this.countOfGoodTextEdit.TabIndex = 34;
            // 
            // goodsComboBox
            // 
            this.goodsComboBox.FormattingEnabled = true;
            this.goodsComboBox.Location = new System.Drawing.Point(290, 69);
            this.goodsComboBox.Name = "goodsComboBox";
            this.goodsComboBox.Size = new System.Drawing.Size(385, 21);
            this.goodsComboBox.TabIndex = 31;
            // 
            // customerComboBox
            // 
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(290, 28);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(482, 21);
            this.customerComboBox.TabIndex = 30;
            // 
            // goodsRowGridControl
            // 
            this.goodsRowGridControl.DataSource = this.addEditViewModelBindingSource;
            this.goodsRowGridControl.Location = new System.Drawing.Point(290, 136);
            this.goodsRowGridControl.MainView = this.goodsRowGridView;
            this.goodsRowGridControl.MenuManager = this.mainRibbonControl;
            this.goodsRowGridControl.Name = "goodsRowGridControl";
            this.goodsRowGridControl.Size = new System.Drawing.Size(482, 223);
            this.goodsRowGridControl.TabIndex = 19;
            this.goodsRowGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.goodsRowGridView});
            // 
            // addEditViewModelBindingSource
            // 
            this.addEditViewModelBindingSource.DataSource = typeof(ContosoUI.Order.AddEdit.AddEditViewModel);
            // 
            // goodsRowGridView
            // 
            this.goodsRowGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGood,
            this.colCount,
            this.colTotalCost});
            this.goodsRowGridView.GridControl = this.goodsRowGridControl;
            this.goodsRowGridView.Name = "goodsRowGridView";
            this.goodsRowGridView.OptionsBehavior.Editable = false;
            // 
            // colGood
            // 
            this.colGood.FieldName = "Good";
            this.colGood.Name = "colGood";
            this.colGood.Visible = true;
            this.colGood.VisibleIndex = 0;
            // 
            // colCount
            // 
            this.colCount.FieldName = "Count";
            this.colCount.Name = "colCount";
            this.colCount.Visible = true;
            this.colCount.VisibleIndex = 1;
            // 
            // colTotalCost
            // 
            this.colTotalCost.FieldName = "TotalCost";
            this.colTotalCost.Name = "colTotalCost";
            this.colTotalCost.Visible = true;
            this.colTotalCost.VisibleIndex = 2;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(12, 28);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(274, 21);
            this.statusComboBox.TabIndex = 5;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.goodsLayoutControlItem,
            this.goodLayoutControlItem,
            this.statusLayoutControlItem1,
            this.customerLayoutControlItem,
            this.layoutControlItem1,
            this.commentLayoutControlItem,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.priceLayoutControlItem,
            this.layoutControlItem3});
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "Root";
            this.layoutControlGroup.Size = new System.Drawing.Size(784, 421);
            this.layoutControlGroup.TextVisible = false;
            // 
            // goodsLayoutControlItem
            // 
            this.goodsLayoutControlItem.Control = this.goodsRowGridControl;
            this.goodsLayoutControlItem.Location = new System.Drawing.Point(278, 108);
            this.goodsLayoutControlItem.Name = "goodsLayoutControlItem";
            this.goodsLayoutControlItem.Size = new System.Drawing.Size(486, 243);
            this.goodsLayoutControlItem.Text = "Список товаров";
            this.goodsLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.goodsLayoutControlItem.TextSize = new System.Drawing.Size(81, 13);
            // 
            // goodLayoutControlItem
            // 
            this.goodLayoutControlItem.Control = this.goodsComboBox;
            this.goodLayoutControlItem.Location = new System.Drawing.Point(278, 41);
            this.goodLayoutControlItem.Name = "goodLayoutControlItem";
            this.goodLayoutControlItem.Size = new System.Drawing.Size(389, 41);
            this.goodLayoutControlItem.Text = "Товары";
            this.goodLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.goodLayoutControlItem.TextSize = new System.Drawing.Size(81, 13);
            // 
            // statusLayoutControlItem1
            // 
            this.statusLayoutControlItem1.Control = this.statusComboBox;
            this.statusLayoutControlItem1.CustomizationFormText = "Статус";
            this.statusLayoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.statusLayoutControlItem1.Name = "statusLayoutControlItem1";
            this.statusLayoutControlItem1.Size = new System.Drawing.Size(278, 41);
            this.statusLayoutControlItem1.Text = "Статус";
            this.statusLayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.statusLayoutControlItem1.TextSize = new System.Drawing.Size(81, 13);
            // 
            // customerLayoutControlItem
            // 
            this.customerLayoutControlItem.Control = this.customerComboBox;
            this.customerLayoutControlItem.Location = new System.Drawing.Point(278, 0);
            this.customerLayoutControlItem.Name = "customerLayoutControlItem";
            this.customerLayoutControlItem.Size = new System.Drawing.Size(486, 41);
            this.customerLayoutControlItem.Text = "Клиент";
            this.customerLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.customerLayoutControlItem.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.commentsListBox;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 108);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(278, 269);
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
            this.commentLayoutControlItem.TextSize = new System.Drawing.Size(81, 13);
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
            this.layoutControlItem2.TextSize = new System.Drawing.Size(81, 13);
            // 
            // priceLayoutControlItem
            // 
            this.priceLayoutControlItem.Control = this.priceEdit;
            this.priceLayoutControlItem.Location = new System.Drawing.Point(0, 377);
            this.priceLayoutControlItem.Name = "priceLayoutControlItem";
            this.priceLayoutControlItem.Size = new System.Drawing.Size(764, 24);
            this.priceLayoutControlItem.Text = "Цена заказа";
            this.priceLayoutControlItem.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.deleteGoodButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(278, 351);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(486, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.priceEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countOfGoodTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsRowGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEditViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsRowGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusLayoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl mainLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem;
        private DevExpress.XtraGrid.GridControl goodsRowGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView goodsRowGridView;
        private DevExpress.XtraLayout.LayoutControlItem goodsLayoutControlItem;
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.BarButtonItem saveOrderButton;
        private DevExpress.XtraBars.BarButtonItem saveAndNewOrderButton;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup saveRibbonPageGroup;
        private System.Windows.Forms.ComboBox customerComboBox;
        private DevExpress.XtraLayout.LayoutControlItem customerLayoutControlItem;
        private System.Windows.Forms.ComboBox statusComboBox;
        private DevExpress.XtraLayout.LayoutControlItem statusLayoutControlItem1;
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
        private DevExpress.XtraEditors.TextEdit priceEdit;
        private DevExpress.XtraLayout.LayoutControlItem priceLayoutControlItem;
        private System.Windows.Forms.ComboBox goodsComboBox;
        private DevExpress.XtraLayout.LayoutControlItem goodLayoutControlItem;
        private System.Windows.Forms.BindingSource addEditViewModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colGood;
        private DevExpress.XtraGrid.Columns.GridColumn colCount;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCost;
        private DevExpress.XtraEditors.SimpleButton deleteGoodButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}