namespace ContosoUI.EditUserForm
{
    partial class EditUser
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
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.OldPasswordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.userSelectComboBox = new System.Windows.Forms.ComboBox();
            this.SelectUserLabel = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.comfimTextBox = new System.Windows.Forms.TextBox();
            this.confimPasswordLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(187, 97);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(190, 20);
            this.passwordTextBox.TabIndex = 7;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(187, 60);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(190, 20);
            this.loginTextBox.TabIndex = 6;
            // 
            // OldPasswordLabel
            // 
            this.OldPasswordLabel.AutoSize = true;
            this.OldPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.OldPasswordLabel.Location = new System.Drawing.Point(60, 98);
            this.OldPasswordLabel.Name = "OldPasswordLabel";
            this.OldPasswordLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OldPasswordLabel.Size = new System.Drawing.Size(99, 17);
            this.OldPasswordLabel.TabIndex = 5;
            this.OldPasswordLabel.Text = "Old Password:";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.loginLabel.Location = new System.Drawing.Point(112, 61);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(47, 17);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Login:";
            // 
            // userSelectComboBox
            // 
            this.userSelectComboBox.FormattingEnabled = true;
            this.userSelectComboBox.Location = new System.Drawing.Point(187, 22);
            this.userSelectComboBox.Name = "userSelectComboBox";
            this.userSelectComboBox.Size = new System.Drawing.Size(190, 21);
            this.userSelectComboBox.TabIndex = 8;
            // 
            // SelectUserLabel
            // 
            this.SelectUserLabel.AutoSize = true;
            this.SelectUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.SelectUserLabel.Location = new System.Drawing.Point(74, 24);
            this.SelectUserLabel.Name = "SelectUserLabel";
            this.SelectUserLabel.Size = new System.Drawing.Size(85, 17);
            this.SelectUserLabel.TabIndex = 9;
            this.SelectUserLabel.Text = "Select User:";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(187, 134);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(190, 20);
            this.newPasswordTextBox.TabIndex = 11;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.newPasswordLabel.Location = new System.Drawing.Point(55, 135);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.newPasswordLabel.Size = new System.Drawing.Size(104, 17);
            this.newPasswordLabel.TabIndex = 10;
            this.newPasswordLabel.Text = "New Password:";
            // 
            // comfimTextBox
            // 
            this.comfimTextBox.Location = new System.Drawing.Point(187, 171);
            this.comfimTextBox.Name = "comfimTextBox";
            this.comfimTextBox.Size = new System.Drawing.Size(190, 20);
            this.comfimTextBox.TabIndex = 13;
            // 
            // confimPasswordLabel
            // 
            this.confimPasswordLabel.AutoSize = true;
            this.confimPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.confimPasswordLabel.Location = new System.Drawing.Point(36, 172);
            this.confimPasswordLabel.Name = "confimPasswordLabel";
            this.confimPasswordLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.confimPasswordLabel.Size = new System.Drawing.Size(123, 17);
            this.confimPasswordLabel.TabIndex = 12;
            this.confimPasswordLabel.Text = "Comfim Password:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(212, 234);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Camcel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(374, 234);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 14;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(293, 234);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 269);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.comfimTextBox);
            this.Controls.Add(this.confimPasswordLabel);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.SelectUserLabel);
            this.Controls.Add(this.userSelectComboBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.OldPasswordLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "EditUser";
            this.Text = "EditUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label OldPasswordLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.ComboBox userSelectComboBox;
        private System.Windows.Forms.Label SelectUserLabel;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.TextBox comfimTextBox;
        private System.Windows.Forms.Label confimPasswordLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button saveButton;
    }
}