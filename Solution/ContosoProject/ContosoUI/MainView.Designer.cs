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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ordersMenuBtn = new DevExpress.XtraBars.BarButtonItem();
            this.customersMenuBtn = new DevExpress.XtraBars.BarButtonItem();
            this.usersMenuBtn = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.workRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.System = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.ordersMenuBtn,
            this.customersMenuBtn,
            this.usersMenuBtn});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 6;
            this.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowCategoryInCaption = false;
            this.ribbonControl.Size = new System.Drawing.Size(832, 141);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Exit";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Logout";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // ordersMenuBtn
            // 
            this.ordersMenuBtn.Caption = "Orders";
            this.ordersMenuBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("ordersMenuBtn.Glyph")));
            this.ordersMenuBtn.Id = 3;
            this.ordersMenuBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ordersMenuBtn.LargeGlyph")));
            this.ordersMenuBtn.Name = "ordersMenuBtn";
            this.ordersMenuBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ordersMenuBtn_ItemClick);
            // 
            // customersMenuBtn
            // 
            this.customersMenuBtn.Caption = "Customers";
            this.customersMenuBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("customersMenuBtn.Glyph")));
            this.customersMenuBtn.Id = 4;
            this.customersMenuBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("customersMenuBtn.LargeGlyph")));
            this.customersMenuBtn.Name = "customersMenuBtn";
            this.customersMenuBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.customersMenuBtn_ItemClick);
            // 
            // usersMenuBtn
            // 
            this.usersMenuBtn.Caption = "Users";
            this.usersMenuBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("usersMenuBtn.Glyph")));
            this.usersMenuBtn.Id = 5;
            this.usersMenuBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("usersMenuBtn.LargeGlyph")));
            this.usersMenuBtn.Name = "usersMenuBtn";
            this.usersMenuBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.usersMenuBtn_ItemClick);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.workRibbonPageGroup,
            this.System});
            this.mainRibbonPage.MergeOrder = 999;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Main";
            // 
            // workRibbonPageGroup
            // 
            this.workRibbonPageGroup.ItemLinks.Add(this.customersMenuBtn);
            this.workRibbonPageGroup.ItemLinks.Add(this.ordersMenuBtn);
            this.workRibbonPageGroup.ItemLinks.Add(this.usersMenuBtn);
            this.workRibbonPageGroup.MergeOrder = 100;
            this.workRibbonPageGroup.Name = "workRibbonPageGroup";
            this.workRibbonPageGroup.Text = "Work";
            // 
            // System
            // 
            this.System.ItemLinks.Add(this.barButtonItem2);
            this.System.ItemLinks.Add(this.barButtonItem1);
            this.System.MergeOrder = 999;
            this.System.Name = "System";
            this.System.Text = "System";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // MainView
            // 
            this.ClientSize = new System.Drawing.Size(832, 621);
            this.Controls.Add(this.ribbonControl);
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.Text = "MainView";
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem ordersMenuBtn;
        private DevExpress.XtraBars.BarButtonItem customersMenuBtn;
        private DevExpress.XtraBars.BarButtonItem usersMenuBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup workRibbonPageGroup;
    }
}