namespace ContosoUI.EditUserForm
{
    partial class UserReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserReportForm));
            this.UserReportGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPersonalInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserReportGridControl = new DevExpress.XtraGrid.GridControl();
            this.userReportViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.userReportSaveBtn = new DevExpress.XtraBars.BarButtonItem();
            this.userReportPrintBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.userReportGridWiew = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UserReportGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserReportGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userReportViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userReportGridWiew)).BeginInit();
            this.SuspendLayout();
            // 
            // UserReportGridView
            // 
            this.UserReportGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPersonalInfo,
            this.colRole,
            this.colLogin,
            this.colId,
            this.colIsActive,
            this.colEditTime});
            this.UserReportGridView.GridControl = this.UserReportGridControl;
            this.UserReportGridView.Name = "UserReportGridView";
            this.UserReportGridView.OptionsFind.AlwaysVisible = true;
            this.UserReportGridView.DoubleClick += new System.EventHandler(this.UserReportGridView_DoubleClick);
            // 
            // colPersonalInfo
            // 
            this.colPersonalInfo.Caption = "ФИО";
            this.colPersonalInfo.FieldName = "Name";
            this.colPersonalInfo.Name = "colPersonalInfo";
            this.colPersonalInfo.OptionsColumn.AllowFocus = false;
            this.colPersonalInfo.OptionsColumn.ReadOnly = true;
            this.colPersonalInfo.Visible = true;
            this.colPersonalInfo.VisibleIndex = 2;
            this.colPersonalInfo.Width = 499;
            // 
            // colRole
            // 
            this.colRole.Caption = "Роль";
            this.colRole.FieldName = "Role";
            this.colRole.Name = "colRole";
            this.colRole.OptionsColumn.AllowFocus = false;
            this.colRole.OptionsColumn.ReadOnly = true;
            this.colRole.Visible = true;
            this.colRole.VisibleIndex = 0;
            this.colRole.Width = 133;
            // 
            // colLogin
            // 
            this.colLogin.Caption = "Логин";
            this.colLogin.FieldName = "Login";
            this.colLogin.Name = "colLogin";
            this.colLogin.OptionsColumn.AllowFocus = false;
            this.colLogin.OptionsColumn.ReadOnly = true;
            this.colLogin.Visible = true;
            this.colLogin.VisibleIndex = 1;
            this.colLogin.Width = 120;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowFocus = false;
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Width = 85;
            // 
            // colIsActive
            // 
            this.colIsActive.Caption = "Активен";
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.OptionsColumn.AllowFocus = false;
            this.colIsActive.OptionsColumn.ReadOnly = true;
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 3;
            this.colIsActive.Width = 115;
            // 
            // colEditTime
            // 
            this.colEditTime.Caption = "Добавлен";
            this.colEditTime.FieldName = "EditTime";
            this.colEditTime.Name = "colEditTime";
            this.colEditTime.OptionsColumn.AllowFocus = false;
            this.colEditTime.OptionsColumn.ReadOnly = true;
            this.colEditTime.Visible = true;
            this.colEditTime.VisibleIndex = 4;
            this.colEditTime.Width = 119;
            // 
            // UserReportGridControl
            // 
            this.UserReportGridControl.DataSource = this.userReportViewModelBindingSource;
            this.UserReportGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserReportGridControl.Location = new System.Drawing.Point(0, 143);
            this.UserReportGridControl.MainView = this.UserReportGridView;
            this.UserReportGridControl.MenuManager = this.ribbon;
            this.UserReportGridControl.Name = "UserReportGridControl";
            this.UserReportGridControl.Size = new System.Drawing.Size(1004, 275);
            this.UserReportGridControl.TabIndex = 2;
            this.UserReportGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UserReportGridView,
            this.userReportGridWiew});
            // 
            // userReportViewModelBindingSource
            // 
            this.userReportViewModelBindingSource.DataSource = typeof(ContosoUI.EditUserForm.UserReportViewModel);
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonGroup1,
            this.userReportSaveBtn,
            this.userReportPrintBtn});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(1004, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 1;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // userReportSaveBtn
            // 
            this.userReportSaveBtn.Caption = "Сохранить";
            this.userReportSaveBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("userReportSaveBtn.Glyph")));
            this.userReportSaveBtn.Id = 4;
            this.userReportSaveBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("userReportSaveBtn.LargeGlyph")));
            this.userReportSaveBtn.Name = "userReportSaveBtn";
            this.userReportSaveBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.UserReportSaveBtn_ItemClick);
            // 
            // userReportPrintBtn
            // 
            this.userReportPrintBtn.Caption = "Печать";
            this.userReportPrintBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("userReportPrintBtn.Glyph")));
            this.userReportPrintBtn.Id = 5;
            this.userReportPrintBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("userReportPrintBtn.LargeGlyph")));
            this.userReportPrintBtn.Name = "userReportPrintBtn";
            this.userReportPrintBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.UserReportPrintBtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Меню";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonGroup1);
            this.ribbonPageGroup1.ItemLinks.Add(this.userReportSaveBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.userReportPrintBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Сохранение";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1004, 31);
            // 
            // userReportGridWiew
            // 
            this.userReportGridWiew.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.userReportGridWiew.GridControl = this.UserReportGridControl;
            this.userReportGridWiew.Name = "userReportGridWiew";
            this.userReportGridWiew.OptionsFind.AlwaysVisible = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ФИО";
            this.gridColumn1.FieldName = "PersonalInfo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 189;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Роль";
            this.gridColumn2.FieldName = "Role";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 113;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Логин";
            this.gridColumn3.FieldName = "Login";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 191;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "Id";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Активен";
            this.gridColumn5.FieldName = "IsActive";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 140;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Добавил";
            this.gridColumn6.FieldName = "Operator";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 140;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Редактировали";
            this.gridColumn7.FieldName = "EditTime";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowFocus = false;
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 160;
            // 
            // UserReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 449);
            this.Controls.Add(this.UserReportGridControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "UserReportForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Список Пользователей";
            ((System.ComponentModel.ISupportInitialize)(this.UserReportGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserReportGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userReportViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userReportGridWiew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraGrid.GridControl UserReportGridControl;
        private System.Windows.Forms.BindingSource userReportViewModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView UserReportGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonalInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colRole;
        private DevExpress.XtraGrid.Columns.GridColumn colLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colEditTime;
        private DevExpress.XtraGrid.Views.Grid.GridView userReportGridWiew;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraBars.BarButtonItem userReportSaveBtn;
        private DevExpress.XtraBars.BarButtonItem userReportPrintBtn;
    }
}