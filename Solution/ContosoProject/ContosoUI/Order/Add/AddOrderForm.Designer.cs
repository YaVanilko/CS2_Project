namespace ContosoUI.Order_Forms
{
    partial class addOrderForm
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.pricetextLabel = new System.Windows.Forms.Label();
            this.customerTextLabel = new System.Windows.Forms.Label();
            this.statusTextLlabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.addCommentButton = new System.Windows.Forms.Button();
            this.goodLabel = new System.Windows.Forms.Label();
            this.goodComboBox = new System.Windows.Forms.ComboBox();
            this.addGoodButton = new System.Windows.Forms.Button();
            this.goodsCheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.commentsCheckedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.saveAndCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsTextLabel = new System.Windows.Forms.Label();
            this.commentsTextLabel = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(784, 25);
            this.mainMenu.TabIndex = 3;
            this.mainMenu.Text = "menuStrip1";
            this.mainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.saveAndCloseToolStripMenuItem,
            this.closeToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.closeToolStripMenuItem.Text = "Save";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLabel.Location = new System.Drawing.Point(32, 182);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(90, 20);
            this.commentsLabel.TabIndex = 26;
            this.commentsLabel.Text = "Comments:";
            // 
            // pricetextLabel
            // 
            this.pricetextLabel.AllowDrop = true;
            this.pricetextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetextLabel.Location = new System.Drawing.Point(32, 137);
            this.pricetextLabel.Name = "pricetextLabel";
            this.pricetextLabel.Size = new System.Drawing.Size(100, 23);
            this.pricetextLabel.TabIndex = 24;
            this.pricetextLabel.Text = "Total price:";
            // 
            // customerTextLabel
            // 
            this.customerTextLabel.AutoSize = true;
            this.customerTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTextLabel.Location = new System.Drawing.Point(32, 95);
            this.customerTextLabel.Name = "customerTextLabel";
            this.customerTextLabel.Size = new System.Drawing.Size(82, 20);
            this.customerTextLabel.TabIndex = 19;
            this.customerTextLabel.Text = "Customer:";
            // 
            // statusTextLlabel
            // 
            this.statusTextLlabel.AutoSize = true;
            this.statusTextLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTextLlabel.Location = new System.Drawing.Point(32, 53);
            this.statusTextLlabel.Name = "statusTextLlabel";
            this.statusTextLlabel.Size = new System.Drawing.Size(119, 20);
            this.statusTextLlabel.TabIndex = 22;
            this.statusTextLlabel.Text = "Status of order:";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(202, 140);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(396, 20);
            this.PriceTextBox.TabIndex = 29;
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(202, 182);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(396, 20);
            this.commentTextBox.TabIndex = 30;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(202, 52);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(396, 21);
            this.statusComboBox.TabIndex = 31;
            // 
            // customerComboBox
            // 
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(202, 93);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(396, 21);
            this.customerComboBox.TabIndex = 32;
            // 
            // addCommentButton
            // 
            this.addCommentButton.Location = new System.Drawing.Point(619, 182);
            this.addCommentButton.Name = "addCommentButton";
            this.addCommentButton.Size = new System.Drawing.Size(93, 23);
            this.addCommentButton.TabIndex = 33;
            this.addCommentButton.Text = "Add";
            this.addCommentButton.UseVisualStyleBackColor = true;
            // 
            // goodLabel
            // 
            this.goodLabel.AutoSize = true;
            this.goodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodLabel.Location = new System.Drawing.Point(36, 230);
            this.goodLabel.Name = "goodLabel";
            this.goodLabel.Size = new System.Drawing.Size(49, 20);
            this.goodLabel.TabIndex = 34;
            this.goodLabel.Text = "Good";
            // 
            // goodComboBox
            // 
            this.goodComboBox.FormattingEnabled = true;
            this.goodComboBox.Location = new System.Drawing.Point(202, 228);
            this.goodComboBox.Name = "goodComboBox";
            this.goodComboBox.Size = new System.Drawing.Size(396, 21);
            this.goodComboBox.TabIndex = 35;
            // 
            // addGoodButton
            // 
            this.addGoodButton.Location = new System.Drawing.Point(619, 226);
            this.addGoodButton.Name = "addGoodButton";
            this.addGoodButton.Size = new System.Drawing.Size(93, 23);
            this.addGoodButton.TabIndex = 36;
            this.addGoodButton.Text = "Add";
            this.addGoodButton.UseVisualStyleBackColor = true;
            // 
            // goodsCheckedListBox1
            // 
            this.goodsCheckedListBox1.FormattingEnabled = true;
            this.goodsCheckedListBox1.Location = new System.Drawing.Point(36, 305);
            this.goodsCheckedListBox1.Name = "goodsCheckedListBox1";
            this.goodsCheckedListBox1.Size = new System.Drawing.Size(319, 244);
            this.goodsCheckedListBox1.TabIndex = 37;
            // 
            // commentsCheckedListBox2
            // 
            this.commentsCheckedListBox2.FormattingEnabled = true;
            this.commentsCheckedListBox2.Location = new System.Drawing.Point(392, 305);
            this.commentsCheckedListBox2.Name = "commentsCheckedListBox2";
            this.commentsCheckedListBox2.Size = new System.Drawing.Size(320, 244);
            this.commentsCheckedListBox2.TabIndex = 38;
            // 
            // saveAndCloseToolStripMenuItem
            // 
            this.saveAndCloseToolStripMenuItem.Name = "saveAndCloseToolStripMenuItem";
            this.saveAndCloseToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveAndCloseToolStripMenuItem.Text = "Save and close";
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.closeToolStripMenuItem1.Text = "Close";
            // 
            // goodsTextLabel
            // 
            this.goodsTextLabel.AutoSize = true;
            this.goodsTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodsTextLabel.Location = new System.Drawing.Point(36, 277);
            this.goodsTextLabel.Name = "goodsTextLabel";
            this.goodsTextLabel.Size = new System.Drawing.Size(57, 20);
            this.goodsTextLabel.TabIndex = 39;
            this.goodsTextLabel.Text = "Goods";
            // 
            // commentsTextLabel
            // 
            this.commentsTextLabel.AutoSize = true;
            this.commentsTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsTextLabel.Location = new System.Drawing.Point(392, 276);
            this.commentsTextLabel.Name = "commentsTextLabel";
            this.commentsTextLabel.Size = new System.Drawing.Size(86, 20);
            this.commentsTextLabel.TabIndex = 40;
            this.commentsTextLabel.Text = "Comments";
            // 
            // addOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.commentsTextLabel);
            this.Controls.Add(this.goodsTextLabel);
            this.Controls.Add(this.commentsCheckedListBox2);
            this.Controls.Add(this.goodsCheckedListBox1);
            this.Controls.Add(this.addGoodButton);
            this.Controls.Add(this.goodComboBox);
            this.Controls.Add(this.goodLabel);
            this.Controls.Add(this.addCommentButton);
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.pricetextLabel);
            this.Controls.Add(this.customerTextLabel);
            this.Controls.Add(this.statusTextLlabel);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "addOrderForm";
            this.Text = "Order";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.Label pricetextLabel;
        private System.Windows.Forms.Label customerTextLabel;
        private System.Windows.Forms.Label statusTextLlabel;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.Button addCommentButton;
        private System.Windows.Forms.Label goodLabel;
        private System.Windows.Forms.ComboBox goodComboBox;
        private System.Windows.Forms.Button addGoodButton;
        private System.Windows.Forms.CheckedListBox goodsCheckedListBox1;
        private System.Windows.Forms.CheckedListBox commentsCheckedListBox2;
        private System.Windows.Forms.ToolStripMenuItem saveAndCloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.Label goodsTextLabel;
        private System.Windows.Forms.Label commentsTextLabel;
    }
}