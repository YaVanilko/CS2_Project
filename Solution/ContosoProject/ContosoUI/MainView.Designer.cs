namespace ContosoUI
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.exitBtn = new DevExpress.XtraBars.BarButtonItem();
            this.logoutBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ordersMenuBtn = new DevExpress.XtraBars.BarButtonItem();
            this.customersMenuBtn = new DevExpress.XtraBars.BarButtonItem();
            this.usersMenuBtn = new DevExpress.XtraBars.BarButtonItem();
            this.addNewCustomerBtn = new DevExpress.XtraBars.BarButtonItem();
            this.addNewOrderBtn = new DevExpress.XtraBars.BarButtonItem();
            this.addNewUserBtn = new DevExpress.XtraBars.BarButtonItem();
            this.goodsMenuBtn = new DevExpress.XtraBars.BarButtonItem();
            this.addGoodsBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.RolesButton = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.customersMenuGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ordersMenuGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.goodsMenuGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.usersMenuGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.System = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.exitBtn,
            this.logoutBtn,
            this.ordersMenuBtn,
            this.customersMenuBtn,
            this.usersMenuBtn,
            this.addNewCustomerBtn,
            this.addNewOrderBtn,
            this.addNewUserBtn,
            this.goodsMenuBtn,
            this.addGoodsBarButton,
            this.RolesButton});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 14;
            this.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowCategoryInCaption = false;
            this.ribbonControl.Size = new System.Drawing.Size(1028, 141);
            // 
            // exitBtn
            // 
            this.exitBtn.Caption = "Выйти";
            this.exitBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("exitBtn.Glyph")));
            this.exitBtn.Id = 1;
            this.exitBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("exitBtn.LargeGlyph")));
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Caption = "Сменить пользователя";
            this.logoutBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Glyph")));
            this.logoutBtn.Id = 2;
            this.logoutBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("logoutBtn.LargeGlyph")));
            this.logoutBtn.Name = "logoutBtn";
            // 
            // ordersMenuBtn
            // 
            this.ordersMenuBtn.Caption = "Заказы";
            this.ordersMenuBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("ordersMenuBtn.Glyph")));
            this.ordersMenuBtn.Id = 3;
            this.ordersMenuBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ordersMenuBtn.LargeGlyph")));
            this.ordersMenuBtn.Name = "ordersMenuBtn";
            this.ordersMenuBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ordersMenuBtn_ItemClick);
            // 
            // customersMenuBtn
            // 
            this.customersMenuBtn.Caption = "Клиенты";
            this.customersMenuBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("customersMenuBtn.Glyph")));
            this.customersMenuBtn.Id = 4;
            this.customersMenuBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("customersMenuBtn.LargeGlyph")));
            this.customersMenuBtn.Name = "customersMenuBtn";
            this.customersMenuBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.customersMenuBtn_ItemClick);
            // 
            // usersMenuBtn
            // 
            this.usersMenuBtn.Caption = "Пользователи";
            this.usersMenuBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("usersMenuBtn.Glyph")));
            this.usersMenuBtn.Id = 5;
            this.usersMenuBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("usersMenuBtn.LargeGlyph")));
            this.usersMenuBtn.Name = "usersMenuBtn";
            this.usersMenuBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.usersMenuBtn_ItemClick);
            // 
            // addNewCustomerBtn
            // 
            this.addNewCustomerBtn.Caption = "Добавить клиента";
            this.addNewCustomerBtn.Id = 6;
            this.addNewCustomerBtn.ImageUri.Uri = "Add";
            this.addNewCustomerBtn.Name = "addNewCustomerBtn";
            this.addNewCustomerBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addNewCustomerBtn_ItemClick);
            // 
            // addNewOrderBtn
            // 
            this.addNewOrderBtn.Caption = "Добавить заказ";
            this.addNewOrderBtn.Id = 8;
            this.addNewOrderBtn.ImageUri.Uri = "AddItem";
            this.addNewOrderBtn.Name = "addNewOrderBtn";
            // 
            // addNewUserBtn
            // 
            this.addNewUserBtn.ActAsDropDown = true;
            this.addNewUserBtn.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.addNewUserBtn.Caption = "Добавить пользователя";
            this.addNewUserBtn.Id = 9;
            this.addNewUserBtn.ImageUri.Uri = "Customization";
            this.addNewUserBtn.Name = "addNewUserBtn";
            this.addNewUserBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addNewUserBtn_ItemClick);
            // 
            // goodsMenuBtn
            // 
            this.goodsMenuBtn.Caption = "Товары";
            this.goodsMenuBtn.Id = 10;
            this.goodsMenuBtn.ImageUri.Uri = "ListBullets";
            this.goodsMenuBtn.Name = "goodsMenuBtn";
            // 
            // addGoodsBarButton
            // 
            this.addGoodsBarButton.Caption = "Добавить товар";
            this.addGoodsBarButton.Id = 12;
            this.addGoodsBarButton.ImageUri.Uri = "Apply";
            this.addGoodsBarButton.Name = "addGoodsBarButton";
            // 
            // RolesButton
            // 
            this.RolesButton.Caption = "Роли";
            this.RolesButton.Id = 13;
            this.RolesButton.ImageUri.Uri = "Show";
            this.RolesButton.Name = "RolesButton";
            this.RolesButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RolesButton_ItemClick);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.customersMenuGroup,
            this.ordersMenuGroup,
            this.goodsMenuGroup,
            this.usersMenuGroup,
            this.System});
            this.mainRibbonPage.MergeOrder = 999;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Меню";
            // 
            // customersMenuGroup
            // 
            this.customersMenuGroup.ItemLinks.Add(this.customersMenuBtn);
            this.customersMenuGroup.ItemLinks.Add(this.addNewCustomerBtn);
            this.customersMenuGroup.Name = "customersMenuGroup";
            this.customersMenuGroup.Text = "Клиенты";
            // 
            // ordersMenuGroup
            // 
            this.ordersMenuGroup.ItemLinks.Add(this.ordersMenuBtn);
            this.ordersMenuGroup.ItemLinks.Add(this.addNewOrderBtn);
            this.ordersMenuGroup.Name = "ordersMenuGroup";
            this.ordersMenuGroup.Text = "Заказы";
            // 
            // goodsMenuGroup
            // 
            this.goodsMenuGroup.ItemLinks.Add(this.goodsMenuBtn);
            this.goodsMenuGroup.ItemLinks.Add(this.addGoodsBarButton);
            this.goodsMenuGroup.Name = "goodsMenuGroup";
            this.goodsMenuGroup.Text = "Товары";
            // 
            // usersMenuGroup
            // 
            this.usersMenuGroup.ItemLinks.Add(this.usersMenuBtn);
            this.usersMenuGroup.ItemLinks.Add(this.addNewUserBtn);
            this.usersMenuGroup.ItemLinks.Add(this.RolesButton);
            this.usersMenuGroup.Name = "usersMenuGroup";
            this.usersMenuGroup.Text = "Пользователи";
            // 
            // System
            // 
            this.System.ItemLinks.Add(this.logoutBtn);
            this.System.ItemLinks.Add(this.exitBtn);
            this.System.Name = "System";
            this.System.Text = "Системные";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // MainView
            // 
            this.ClientSize = new System.Drawing.Size(1028, 621);
            this.Controls.Add(this.ribbonControl);
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.Text = "ContosoProgram";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup System;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem exitBtn;
        private DevExpress.XtraBars.BarButtonItem logoutBtn;
        private DevExpress.XtraBars.BarButtonItem ordersMenuBtn;
        private DevExpress.XtraBars.BarButtonItem customersMenuBtn;
        private DevExpress.XtraBars.BarButtonItem usersMenuBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup customersMenuGroup;
        private DevExpress.XtraBars.BarButtonItem addNewCustomerBtn;
        private DevExpress.XtraBars.BarButtonItem addNewOrderBtn;
        private DevExpress.XtraBars.BarButtonItem addNewUserBtn;
        private DevExpress.XtraBars.BarButtonItem goodsMenuBtn;
        private DevExpress.XtraBars.BarButtonItem addGoodsBarButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ordersMenuGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup goodsMenuGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup usersMenuGroup;
        private DevExpress.XtraBars.BarButtonItem RolesButton;
    }
}