namespace ContosoUI.Order_Forms
{
    partial class orderForm
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
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.commentsListBox = new System.Windows.Forms.ListBox();
            this.pricetextLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.customerTextLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusTextLlabel = new System.Windows.Forms.Label();
            this.goodsListLabel = new System.Windows.Forms.Label();
            this.goodsListBox = new System.Windows.Forms.ListBox();
            this.customerLabel = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(784, 24);
            this.mainMenu.TabIndex = 3;
            this.mainMenu.Text = "menuStrip1";
            this.mainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLabel.Location = new System.Drawing.Point(32, 166);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(88, 18);
            this.commentsLabel.TabIndex = 26;
            this.commentsLabel.Text = "Comments:";
            // 
            // commentsListBox
            // 
            this.commentsListBox.FormattingEnabled = true;
            this.commentsListBox.Location = new System.Drawing.Point(35, 191);
            this.commentsListBox.Name = "commentsListBox";
            this.commentsListBox.Size = new System.Drawing.Size(323, 342);
            this.commentsListBox.TabIndex = 25;
            // 
            // pricetextLabel
            // 
            this.pricetextLabel.AllowDrop = true;
            this.pricetextLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetextLabel.Location = new System.Drawing.Point(32, 127);
            this.pricetextLabel.Name = "pricetextLabel";
            this.pricetextLabel.Size = new System.Drawing.Size(100, 23);
            this.pricetextLabel.TabIndex = 24;
            this.pricetextLabel.Text = "Total price:";
            // 
            // priceLabel
            // 
            this.priceLabel.AllowDrop = true;
            this.priceLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(197, 127);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(53, 23);
            this.priceLabel.TabIndex = 21;
            this.priceLabel.Text = "Price";
            // 
            // customerTextLabel
            // 
            this.customerTextLabel.AutoSize = true;
            this.customerTextLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTextLabel.Location = new System.Drawing.Point(32, 91);
            this.customerTextLabel.Name = "customerTextLabel";
            this.customerTextLabel.Size = new System.Drawing.Size(80, 18);
            this.customerTextLabel.TabIndex = 19;
            this.customerTextLabel.Text = "Customer:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(197, 54);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(52, 18);
            this.statusLabel.TabIndex = 23;
            this.statusLabel.Text = "Status";
            // 
            // statusTextLlabel
            // 
            this.statusTextLlabel.AutoSize = true;
            this.statusTextLlabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTextLlabel.Location = new System.Drawing.Point(32, 54);
            this.statusTextLlabel.Name = "statusTextLlabel";
            this.statusTextLlabel.Size = new System.Drawing.Size(114, 18);
            this.statusTextLlabel.TabIndex = 22;
            this.statusTextLlabel.Text = "Status of order:";
            // 
            // goodsListLabel
            // 
            this.goodsListLabel.AutoSize = true;
            this.goodsListLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodsListLabel.Location = new System.Drawing.Point(392, 54);
            this.goodsListLabel.Name = "goodsListLabel";
            this.goodsListLabel.Size = new System.Drawing.Size(98, 18);
            this.goodsListLabel.TabIndex = 18;
            this.goodsListLabel.Text = "List of goods";
            // 
            // goodsListBox
            // 
            this.goodsListBox.FormattingEnabled = true;
            this.goodsListBox.Location = new System.Drawing.Point(395, 87);
            this.goodsListBox.Name = "goodsListBox";
            this.goodsListBox.Size = new System.Drawing.Size(358, 446);
            this.goodsListBox.TabIndex = 17;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(197, 91);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(76, 18);
            this.customerLabel.TabIndex = 20;
            this.customerLabel.Text = "Customer";
            // 
            // orderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.commentsListBox);
            this.Controls.Add(this.pricetextLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.customerTextLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.statusTextLlabel);
            this.Controls.Add(this.goodsListLabel);
            this.Controls.Add(this.goodsListBox);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "orderForm";
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
        private System.Windows.Forms.ListBox commentsListBox;
        private System.Windows.Forms.Label pricetextLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label customerTextLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label statusTextLlabel;
        private System.Windows.Forms.Label goodsListLabel;
        private System.Windows.Forms.ListBox goodsListBox;
        private System.Windows.Forms.Label customerLabel;
    }
}