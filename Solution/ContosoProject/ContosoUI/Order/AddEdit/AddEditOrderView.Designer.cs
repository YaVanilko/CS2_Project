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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditOrderView));
            this.mainLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.commentsListBoxControl = new DevExpress.XtraEditors.ListBoxControl();
            this.goodsListBoxControl = new DevExpress.XtraEditors.ListBoxControl();
            this.statusComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.saveOrderButton = new DevExpress.XtraBars.BarButtonItem();
            this.saveAndNewOrderButton = new DevExpress.XtraBars.BarButtonItem();
            this.addGoodButton = new DevExpress.XtraBars.BarButtonItem();
            this.addCommentButton = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.addGroupPage = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.deleteRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.commentTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.totalCostTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.customerComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.goodComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.goodLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.customerLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.totalCostlayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.commenLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.statusLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).BeginInit();
            this.mainLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentsListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalCostTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalCostlayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commenLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutControl
            // 
            this.mainLayoutControl.Controls.Add(this.commentsListBoxControl);
            this.mainLayoutControl.Controls.Add(this.goodsListBoxControl);
            this.mainLayoutControl.Controls.Add(this.statusComboBoxEdit);
            this.mainLayoutControl.Controls.Add(this.commentTextEdit);
            this.mainLayoutControl.Controls.Add(this.totalCostTextEdit);
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
            // commentsListBoxControl
            // 
            this.commentsListBoxControl.Location = new System.Drawing.Point(394, 132);
            this.commentsListBoxControl.Name = "commentsListBoxControl";
            this.commentsListBoxControl.Size = new System.Drawing.Size(378, 277);
            this.commentsListBoxControl.StyleController = this.mainLayoutControl;
            this.commentsListBoxControl.TabIndex = 0;
            // 
            // goodsListBoxControl
            // 
            this.goodsListBoxControl.Location = new System.Drawing.Point(12, 132);
            this.goodsListBoxControl.Name = "goodsListBoxControl";
            this.goodsListBoxControl.Size = new System.Drawing.Size(760, 277);
            this.goodsListBoxControl.StyleController = this.mainLayoutControl;
            this.goodsListBoxControl.TabIndex = 9;
            // 
            // statusComboBoxEdit
            // 
            this.statusComboBoxEdit.Location = new System.Drawing.Point(82, 36);
            this.statusComboBoxEdit.MenuManager = this.mainRibbonControl;
            this.statusComboBoxEdit.Name = "statusComboBoxEdit";
            this.statusComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.statusComboBoxEdit.Size = new System.Drawing.Size(690, 20);
            this.statusComboBoxEdit.StyleController = this.mainLayoutControl;
            this.statusComboBoxEdit.TabIndex = 8;
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.saveOrderButton,
            this.saveAndNewOrderButton,
            this.addGoodButton,
            this.addCommentButton,
            this.barButtonItem1,
            this.barButtonItem2});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 7;
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
            // addGoodButton
            // 
            this.addGoodButton.Caption = "Добавить товар";
            this.addGoodButton.Glyph = ((System.Drawing.Image)(resources.GetObject("addGoodButton.Glyph")));
            this.addGoodButton.Id = 3;
            this.addGoodButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addGoodButton.LargeGlyph")));
            this.addGoodButton.Name = "addGoodButton";
            // 
            // addCommentButton
            // 
            this.addCommentButton.Caption = "Добавить комментарий";
            this.addCommentButton.Glyph = ((System.Drawing.Image)(resources.GetObject("addCommentButton.Glyph")));
            this.addCommentButton.Id = 4;
            this.addCommentButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addCommentButton.LargeGlyph")));
            this.addCommentButton.Name = "addCommentButton";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Удалить товар";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Удалить комментарий";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 6;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.addGroupPage,
            this.deleteRibbonPageGroup,
            this.ribbonPageGroup1});
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Меню";
            // 
            // addGroupPage
            // 
            this.addGroupPage.ItemLinks.Add(this.addGoodButton);
            this.addGroupPage.ItemLinks.Add(this.addCommentButton);
            this.addGroupPage.MergeOrder = 10;
            this.addGroupPage.Name = "addGroupPage";
            this.addGroupPage.Text = "Добавить";
            // 
            // deleteRibbonPageGroup
            // 
            this.deleteRibbonPageGroup.ItemLinks.Add(this.barButtonItem1);
            this.deleteRibbonPageGroup.ItemLinks.Add(this.barButtonItem2);
            this.deleteRibbonPageGroup.MergeOrder = 20;
            this.deleteRibbonPageGroup.Name = "deleteRibbonPageGroup";
            this.deleteRibbonPageGroup.Text = "Удалить";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.saveOrderButton);
            this.ribbonPageGroup1.ItemLinks.Add(this.saveAndNewOrderButton);
            this.ribbonPageGroup1.MergeOrder = 30;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Сохранить";
            // 
            // commentTextEdit
            // 
            this.commentTextEdit.Location = new System.Drawing.Point(82, 84);
            this.commentTextEdit.MenuManager = this.mainRibbonControl;
            this.commentTextEdit.Name = "commentTextEdit";
            this.commentTextEdit.Size = new System.Drawing.Size(690, 20);
            this.commentTextEdit.StyleController = this.mainLayoutControl;
            this.commentTextEdit.TabIndex = 7;
            // 
            // totalCostTextEdit
            // 
            this.totalCostTextEdit.Location = new System.Drawing.Point(82, 60);
            this.totalCostTextEdit.MenuManager = this.mainRibbonControl;
            this.totalCostTextEdit.Name = "totalCostTextEdit";
            this.totalCostTextEdit.Size = new System.Drawing.Size(690, 20);
            this.totalCostTextEdit.StyleController = this.mainLayoutControl;
            this.totalCostTextEdit.TabIndex = 6;
            // 
            // customerComboBoxEdit
            // 
            this.customerComboBoxEdit.Location = new System.Drawing.Point(82, 12);
            this.customerComboBoxEdit.MenuManager = this.mainRibbonControl;
            this.customerComboBoxEdit.Name = "customerComboBoxEdit";
            this.customerComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customerComboBoxEdit.Size = new System.Drawing.Size(690, 20);
            this.customerComboBoxEdit.StyleController = this.mainLayoutControl;
            this.customerComboBoxEdit.TabIndex = 5;
            // 
            // goodComboBoxEdit
            // 
            this.goodComboBoxEdit.Location = new System.Drawing.Point(82, 108);
            this.goodComboBoxEdit.MenuManager = this.mainRibbonControl;
            this.goodComboBoxEdit.Name = "goodComboBoxEdit";
            this.goodComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.goodComboBoxEdit.Size = new System.Drawing.Size(690, 20);
            this.goodComboBoxEdit.StyleController = this.mainLayoutControl;
            this.goodComboBoxEdit.TabIndex = 4;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.goodLayoutControlItem,
            this.customerLayoutControlItem,
            this.totalCostlayoutControlItem,
            this.commenLayoutControlItem,
            this.layoutControlItem,
            this.statusLayoutControlItem});
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "Root";
            this.layoutControlGroup.Size = new System.Drawing.Size(784, 421);
            this.layoutControlGroup.TextVisible = false;
            // 
            // goodLayoutControlItem
            // 
            this.goodLayoutControlItem.Control = this.goodComboBoxEdit;
            this.goodLayoutControlItem.Location = new System.Drawing.Point(0, 96);
            this.goodLayoutControlItem.Name = "goodLayoutControlItem";
            this.goodLayoutControlItem.Size = new System.Drawing.Size(764, 24);
            this.goodLayoutControlItem.Text = "Товар";
            this.goodLayoutControlItem.TextSize = new System.Drawing.Size(67, 13);
            // 
            // customerLayoutControlItem
            // 
            this.customerLayoutControlItem.Control = this.customerComboBoxEdit;
            this.customerLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.customerLayoutControlItem.Name = "customerLayoutControlItem";
            this.customerLayoutControlItem.Size = new System.Drawing.Size(764, 24);
            this.customerLayoutControlItem.Text = "Клиент";
            this.customerLayoutControlItem.TextSize = new System.Drawing.Size(67, 13);
            // 
            // totalCostlayoutControlItem
            // 
            this.totalCostlayoutControlItem.Control = this.totalCostTextEdit;
            this.totalCostlayoutControlItem.Location = new System.Drawing.Point(0, 48);
            this.totalCostlayoutControlItem.Name = "totalCostlayoutControlItem";
            this.totalCostlayoutControlItem.Size = new System.Drawing.Size(764, 24);
            this.totalCostlayoutControlItem.Text = "Цена";
            this.totalCostlayoutControlItem.TextSize = new System.Drawing.Size(67, 13);
            // 
            // commenLayoutControlItem
            // 
            this.commenLayoutControlItem.Control = this.commentTextEdit;
            this.commenLayoutControlItem.Location = new System.Drawing.Point(0, 72);
            this.commenLayoutControlItem.Name = "commenLayoutControlItem";
            this.commenLayoutControlItem.Size = new System.Drawing.Size(764, 24);
            this.commenLayoutControlItem.Text = "Комментарий";
            this.commenLayoutControlItem.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem
            // 
            this.layoutControlItem.Control = this.goodsListBoxControl;
            this.layoutControlItem.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem.Name = "layoutControlItem";
            this.layoutControlItem.Size = new System.Drawing.Size(764, 281);
            this.layoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem.TextVisible = false;
            // 
            // statusLayoutControlItem
            // 
            this.statusLayoutControlItem.Control = this.statusComboBoxEdit;
            this.statusLayoutControlItem.Location = new System.Drawing.Point(0, 24);
            this.statusLayoutControlItem.Name = "statusLayoutControlItem";
            this.statusLayoutControlItem.Size = new System.Drawing.Size(764, 24);
            this.statusLayoutControlItem.Text = "Статус";
            this.statusLayoutControlItem.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Location = new System.Drawing.Point(382, 120);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(382, 281);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(50, 20);
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
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).EndInit();
            this.mainLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.commentsListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalCostTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalCostlayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commenLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl mainLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup addGroupPage;
        private DevExpress.XtraEditors.ComboBoxEdit goodComboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlItem goodLayoutControlItem;
        private DevExpress.XtraEditors.TextEdit totalCostTextEdit;
        private DevExpress.XtraEditors.ComboBoxEdit customerComboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlItem customerLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem totalCostlayoutControlItem;
        private DevExpress.XtraEditors.TextEdit commentTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem commenLayoutControlItem;
        private DevExpress.XtraEditors.ComboBoxEdit statusComboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlItem statusLayoutControlItem;
        private DevExpress.XtraEditors.ListBoxControl commentsListBoxControl;
        private DevExpress.XtraEditors.ListBoxControl goodsListBoxControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraBars.BarButtonItem saveOrderButton;
        private DevExpress.XtraBars.BarButtonItem saveAndNewOrderButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem addGoodButton;
        private DevExpress.XtraBars.BarButtonItem addCommentButton;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup deleteRibbonPageGroup;
    }
}