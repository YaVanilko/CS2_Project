namespace ContosoUI.Roles
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
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.saveRoleRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.saveRoleButton = new DevExpress.XtraBars.BarButtonItem();
            this.saveAndNewRoleButton = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.rolesRibbomItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            this.SuspendLayout();
            // 
            // rolesRibbomItem
            // 
            this.rolesRibbomItem.ExpandCollapseItem.Id = 0;
            this.rolesRibbomItem.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rolesRibbomItem.ExpandCollapseItem,
            this.saveRoleButton,
            this.saveAndNewRoleButton});
            this.rolesRibbomItem.Location = new System.Drawing.Point(0, 0);
            this.rolesRibbomItem.MaxItemId = 3;
            this.rolesRibbomItem.Name = "rolesRibbomItem";
            this.rolesRibbomItem.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.rolesRibbomItem.Size = new System.Drawing.Size(799, 141);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.saveRoleRibbonPageGroup});
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Меню";
            // 
            // saveRoleRibbonPageGroup
            // 
            this.saveRoleRibbonPageGroup.ItemLinks.Add(this.saveRoleButton);
            this.saveRoleRibbonPageGroup.ItemLinks.Add(this.saveAndNewRoleButton);
            this.saveRoleRibbonPageGroup.Name = "saveRoleRibbonPageGroup";
            this.saveRoleRibbonPageGroup.Text = "Сохранение";
            // 
            // saveRoleButton
            // 
            this.saveRoleButton.Caption = "Сохранить";
            this.saveRoleButton.Id = 1;
            this.saveRoleButton.ImageUri.Uri = "Save";
            this.saveRoleButton.Name = "saveRoleButton";
            // 
            // saveAndNewRoleButton
            // 
            this.saveAndNewRoleButton.Caption = "Сохранить/Создать";
            this.saveAndNewRoleButton.Id = 2;
            this.saveAndNewRoleButton.ImageUri.Uri = "SaveAndNew";
            this.saveAndNewRoleButton.Name = "saveAndNewRoleButton";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 141);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(799, 527);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(799, 527);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // RolesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 668);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.rolesRibbomItem);
            this.Name = "RolesView";
            this.Text = "Роли пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.rolesRibbomItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rolesRibbomItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup saveRoleRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem saveRoleButton;
        private DevExpress.XtraBars.BarButtonItem saveAndNewRoleButton;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    }
}