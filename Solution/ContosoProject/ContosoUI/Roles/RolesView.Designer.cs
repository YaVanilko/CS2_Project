﻿namespace ContosoUI.Roles
{
    partial class RolesView
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
            this.rolesRibbomItem = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.saveRoleButton = new DevExpress.XtraBars.BarButtonItem();
            this.addNewRoleButton = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.saveRoleRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.roleLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.permissionsCheckedListBoxControl = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.rolesGridControl = new DevExpress.XtraGrid.GridControl();
            this.rolesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rolePermissionLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.roleControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.permissionsControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.rolesRibbomItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleLayoutControl)).BeginInit();
            this.roleLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.permissionsCheckedListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolePermissionLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionsControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // rolesRibbomItem
            // 
            this.rolesRibbomItem.ExpandCollapseItem.Id = 0;
            this.rolesRibbomItem.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rolesRibbomItem.ExpandCollapseItem,
            this.saveRoleButton,
            this.addNewRoleButton});
            this.rolesRibbomItem.Location = new System.Drawing.Point(0, 0);
            this.rolesRibbomItem.MaxItemId = 3;
            this.rolesRibbomItem.Name = "rolesRibbomItem";
            this.rolesRibbomItem.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.rolesRibbomItem.Size = new System.Drawing.Size(799, 141);
            // 
            // saveRoleButton
            // 
            this.saveRoleButton.Caption = "Сохранить";
            this.saveRoleButton.Id = 1;
            this.saveRoleButton.ImageUri.Uri = "Save";
            this.saveRoleButton.Name = "saveRoleButton";
            this.saveRoleButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveRoleButton_ItemClick);
            // 
            // addNewRoleButton
            // 
            this.addNewRoleButton.Caption = "Добавить";
            this.addNewRoleButton.Id = 2;
            this.addNewRoleButton.ImageUri.Uri = "SaveAndNew";
            this.addNewRoleButton.Name = "addNewRoleButton";
            this.addNewRoleButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addNewRoleButton_ItemClick);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.saveRoleRibbonPageGroup});
            this.mainRibbonPage.MergeOrder = 1;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Меню";
            // 
            // saveRoleRibbonPageGroup
            // 
            this.saveRoleRibbonPageGroup.ItemLinks.Add(this.saveRoleButton);
            this.saveRoleRibbonPageGroup.ItemLinks.Add(this.addNewRoleButton);
            this.saveRoleRibbonPageGroup.MergeOrder = 5;
            this.saveRoleRibbonPageGroup.Name = "saveRoleRibbonPageGroup";
            this.saveRoleRibbonPageGroup.Text = "Сохранение";
            // 
            // roleLayoutControl
            // 
            this.roleLayoutControl.Controls.Add(this.permissionsCheckedListBoxControl);
            this.roleLayoutControl.Controls.Add(this.rolesGridControl);
            this.roleLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roleLayoutControl.Location = new System.Drawing.Point(0, 141);
            this.roleLayoutControl.Name = "roleLayoutControl";
            this.roleLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(196, 127, 328, 350);
            this.roleLayoutControl.Root = this.rolePermissionLayoutControlGroup;
            this.roleLayoutControl.Size = new System.Drawing.Size(799, 527);
            this.roleLayoutControl.TabIndex = 1;
            this.roleLayoutControl.Text = "layoutControl1";
            // 
            // permissionsCheckedListBoxControl
            // 
            this.permissionsCheckedListBoxControl.CheckOnClick = true;
            this.permissionsCheckedListBoxControl.DisplayMember = "Name";
            this.permissionsCheckedListBoxControl.Location = new System.Drawing.Point(540, 28);
            this.permissionsCheckedListBoxControl.Name = "permissionsCheckedListBoxControl";
            this.permissionsCheckedListBoxControl.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.permissionsCheckedListBoxControl.Size = new System.Drawing.Size(247, 487);
            this.permissionsCheckedListBoxControl.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.permissionsCheckedListBoxControl.StyleController = this.roleLayoutControl;
            this.permissionsCheckedListBoxControl.TabIndex = 5;
            this.permissionsCheckedListBoxControl.ValueMember = "Id";
            // 
            // rolesGridControl
            // 
            this.rolesGridControl.Location = new System.Drawing.Point(12, 28);
            this.rolesGridControl.MainView = this.rolesGridView;
            this.rolesGridControl.MenuManager = this.rolesRibbomItem;
            this.rolesGridControl.Name = "rolesGridControl";
            this.rolesGridControl.Size = new System.Drawing.Size(507, 487);
            this.rolesGridControl.TabIndex = 4;
            this.rolesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.rolesGridView});
            // 
            // rolesGridView
            // 
            this.rolesGridView.ColumnPanelRowHeight = 50;
            this.rolesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colId,
            this.colIsActive,
            this.colEditTime});
            this.rolesGridView.GridControl = this.rolesGridControl;
            this.rolesGridView.Name = "rolesGridView";
            this.rolesGridView.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.rolesGridView.OptionsView.RowAutoHeight = true;
            this.rolesGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.rolesGridView_FocusedRowChanged);
            this.rolesGridView.BeforeLeaveRow += new DevExpress.XtraGrid.Views.Base.RowAllowEventHandler(this.rolesGridView_BeforeLeaveRow);
            // 
            // colName
            // 
            this.colName.Caption = "Имя роли";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 171;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 72;
            // 
            // colIsActive
            // 
            this.colIsActive.Caption = "Статус (активировать/ деактивировать)";
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.OptionsEditForm.RowSpan = 2;
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 2;
            this.colIsActive.Width = 124;
            // 
            // colEditTime
            // 
            this.colEditTime.Caption = "Дата редактирования";
            this.colEditTime.FieldName = "EditTime";
            this.colEditTime.Name = "colEditTime";
            this.colEditTime.OptionsColumn.AllowEdit = false;
            this.colEditTime.OptionsColumn.ReadOnly = true;
            this.colEditTime.Visible = true;
            this.colEditTime.VisibleIndex = 3;
            this.colEditTime.Width = 122;
            // 
            // rolePermissionLayoutControlGroup
            // 
            this.rolePermissionLayoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.rolePermissionLayoutControlGroup.GroupBordersVisible = false;
            this.rolePermissionLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.roleControlItem,
            this.permissionsControlItem,
            this.emptySpaceItem1});
            this.rolePermissionLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.rolePermissionLayoutControlGroup.Name = "rolePermissionLayoutControlGroup";
            this.rolePermissionLayoutControlGroup.Size = new System.Drawing.Size(799, 527);
            this.rolePermissionLayoutControlGroup.TextVisible = false;
            // 
            // roleControlItem
            // 
            this.roleControlItem.Control = this.rolesGridControl;
            this.roleControlItem.Location = new System.Drawing.Point(0, 0);
            this.roleControlItem.Name = "roleControlItem";
            this.roleControlItem.Size = new System.Drawing.Size(511, 507);
            this.roleControlItem.Text = "Список ролей";
            this.roleControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.roleControlItem.TextSize = new System.Drawing.Size(100, 13);
            // 
            // permissionsControlItem
            // 
            this.permissionsControlItem.Control = this.permissionsCheckedListBoxControl;
            this.permissionsControlItem.Location = new System.Drawing.Point(528, 0);
            this.permissionsControlItem.Name = "permissionsControlItem";
            this.permissionsControlItem.Size = new System.Drawing.Size(251, 507);
            this.permissionsControlItem.Text = "Список разрешений";
            this.permissionsControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.permissionsControlItem.TextSize = new System.Drawing.Size(100, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(511, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(17, 507);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // RolesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 668);
            this.Controls.Add(this.roleLayoutControl);
            this.Controls.Add(this.rolesRibbomItem);
            this.Name = "RolesView";
            this.Text = "Роли пользователя";
            this.Load += new System.EventHandler(this.RolesView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolesRibbomItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleLayoutControl)).EndInit();
            this.roleLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.permissionsCheckedListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolePermissionLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionsControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rolesRibbomItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup saveRoleRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem saveRoleButton;
        private DevExpress.XtraBars.BarButtonItem addNewRoleButton;
        private DevExpress.XtraLayout.LayoutControl roleLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup rolePermissionLayoutControlGroup;
        private DevExpress.XtraGrid.GridControl rolesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView rolesGridView;
        private DevExpress.XtraLayout.LayoutControlItem roleControlItem;
        private DevExpress.XtraEditors.CheckedListBoxControl permissionsCheckedListBoxControl;
        private DevExpress.XtraLayout.LayoutControlItem permissionsControlItem;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colEditTime;
    }
}