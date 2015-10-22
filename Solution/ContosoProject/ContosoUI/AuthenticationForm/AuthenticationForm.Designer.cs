namespace ContosoUI.AuthenticationForm
{
    partial class AuthenticationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthenticationForm));
            this.OkButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.LoginPictureBox = new System.Windows.Forms.PictureBox();
            this.LoginTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PasswordEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleButtonLCI = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButtonLCI)).BeginInit();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.AutoWidthInLayoutControl = true;
            this.OkButton.Image = ((System.Drawing.Image)(resources.GetObject("OkButton.Image")));
            this.OkButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.OkButton.Location = new System.Drawing.Point(458, 305);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(64, 44);
            this.OkButton.StyleController = this.layoutControl1;
            this.OkButton.TabIndex = 4;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.LoginPictureBox);
            this.layoutControl1.Controls.Add(this.LoginTextEdit);
            this.layoutControl1.Controls.Add(this.PasswordEdit);
            this.layoutControl1.Controls.Add(this.OkButton);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(733, 33, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(534, 361);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // LoginPictureBox
            // 
            this.LoginPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LoginPictureBox.Image")));
            this.LoginPictureBox.Location = new System.Drawing.Point(12, 12);
            this.LoginPictureBox.Name = "LoginPictureBox";
            this.LoginPictureBox.Size = new System.Drawing.Size(510, 289);
            this.LoginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginPictureBox.TabIndex = 8;
            this.LoginPictureBox.TabStop = false;
            // 
            // LoginTextEdit
            // 
            this.LoginTextEdit.EditValue = "";
            this.LoginTextEdit.Location = new System.Drawing.Point(56, 305);
            this.LoginTextEdit.Name = "LoginTextEdit";
            this.LoginTextEdit.Size = new System.Drawing.Size(398, 20);
            this.LoginTextEdit.StyleController = this.layoutControl1;
            this.LoginTextEdit.TabIndex = 4;
            // 
            // PasswordEdit
            // 
            this.PasswordEdit.EditValue = "";
            this.PasswordEdit.Location = new System.Drawing.Point(56, 329);
            this.PasswordEdit.Name = "PasswordEdit";
            this.PasswordEdit.Size = new System.Drawing.Size(398, 20);
            this.PasswordEdit.StyleController = this.layoutControl1;
            this.PasswordEdit.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlGroup3,
            this.layoutControlGroup4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(534, 361);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.LoginPictureBox;
            this.layoutControlItem1.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem1.Image")));
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(514, 293);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 293);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(446, 48);
            this.layoutControlGroup3.Text = "layoutControlGroup2";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.LoginTextEdit;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(98, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(446, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Логин:";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(41, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.PasswordEdit;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(446, 24);
            this.layoutControlItem3.Text = "Пароль:";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(41, 13);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.CustomizationFormText = "layoutControlGroup3";
            this.layoutControlGroup4.GroupBordersVisible = false;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.simpleButtonLCI});
            this.layoutControlGroup4.Location = new System.Drawing.Point(446, 293);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(68, 48);
            this.layoutControlGroup4.Text = "layoutControlGroup3";
            // 
            // simpleButtonLCI
            // 
            this.simpleButtonLCI.Control = this.OkButton;
            this.simpleButtonLCI.ControlAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.simpleButtonLCI.CustomizationFormText = "simpleButtonLCI";
            this.simpleButtonLCI.Location = new System.Drawing.Point(0, 0);
            this.simpleButtonLCI.MinSize = new System.Drawing.Size(46, 42);
            this.simpleButtonLCI.Name = "simpleButtonLCI";
            this.simpleButtonLCI.Size = new System.Drawing.Size(68, 48);
            this.simpleButtonLCI.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.simpleButtonLCI.TextLocation = DevExpress.Utils.Locations.Left;
            this.simpleButtonLCI.TextSize = new System.Drawing.Size(0, 0);
            this.simpleButtonLCI.TextVisible = false;
            this.simpleButtonLCI.TrimClientAreaToControl = false;
            this.simpleButtonLCI.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // AuthenticationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AuthenticationForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизуйтесь пожалуйста!";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButtonLCI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton OkButton;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.PictureBox LoginPictureBox;
        private DevExpress.XtraEditors.TextEdit LoginTextEdit;
        private DevExpress.XtraEditors.TextEdit PasswordEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem simpleButtonLCI;


    }
}