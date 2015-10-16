namespace ContosoUI.Customers.Add
{
    partial class CustomerDetailsViev
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
            this.personalInfoBox = new System.Windows.Forms.GroupBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.contactsInfoBox = new System.Windows.Forms.GroupBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.orderListBox = new System.Windows.Forms.GroupBox();
            this.ordersListDataGridView = new System.Windows.Forms.DataGridView();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalContactInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.telephoneEmailtableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.personalInfoBox.SuspendLayout();
            this.contactsInfoBox.SuspendLayout();
            this.orderListBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersListDataGridView)).BeginInit();
            this.personalContactInfoTableLayoutPanel.SuspendLayout();
            this.telephoneEmailtableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // personalInfoBox
            // 
            this.personalInfoBox.Controls.Add(this.middleNameTextBox);
            this.personalInfoBox.Controls.Add(this.lastNameTextBox);
            this.personalInfoBox.Controls.Add(this.firstNameTextBox);
            this.personalInfoBox.Controls.Add(this.middleNameLabel);
            this.personalInfoBox.Controls.Add(this.lastNameLabel);
            this.personalInfoBox.Controls.Add(this.firstNameLabel);
            this.personalInfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personalInfoBox.Location = new System.Drawing.Point(3, 3);
            this.personalInfoBox.Name = "personalInfoBox";
            this.personalInfoBox.Size = new System.Drawing.Size(314, 220);
            this.personalInfoBox.TabIndex = 0;
            this.personalInfoBox.TabStop = false;
            this.personalInfoBox.Text = "Персональные данные заказчика";
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middleNameTextBox.Location = new System.Drawing.Point(15, 154);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(285, 20);
            this.middleNameTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTextBox.Location = new System.Drawing.Point(15, 100);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(285, 20);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTextBox.Location = new System.Drawing.Point(15, 47);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(284, 20);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(12, 137);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(54, 13);
            this.middleNameLabel.TabIndex = 2;
            this.middleNameLabel.Text = "Отчество";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 83);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Фамилия";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 30);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(29, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "Имя";
            // 
            // contactsInfoBox
            // 
            this.contactsInfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactsInfoBox.Controls.Add(this.telephoneEmailtableLayoutPanel);
            this.contactsInfoBox.Controls.Add(this.addressTextBox);
            this.contactsInfoBox.Controls.Add(this.cityTextBox);
            this.contactsInfoBox.Controls.Add(this.addressLabel);
            this.contactsInfoBox.Controls.Add(this.cityLabel);
            this.contactsInfoBox.Location = new System.Drawing.Point(323, 3);
            this.contactsInfoBox.Name = "contactsInfoBox";
            this.contactsInfoBox.Size = new System.Drawing.Size(314, 220);
            this.contactsInfoBox.TabIndex = 1;
            this.contactsInfoBox.TabStop = false;
            this.contactsInfoBox.Text = "Контактные данные заказчика";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(150, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(133, 13);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "E-Mail";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextBox.Location = new System.Drawing.Point(18, 99);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(286, 20);
            this.addressTextBox.TabIndex = 4;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cityTextBox.Location = new System.Drawing.Point(18, 46);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(286, 20);
            this.cityTextBox.TabIndex = 3;
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Location = new System.Drawing.Point(3, 0);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(141, 13);
            this.telephoneLabel.TabIndex = 2;
            this.telephoneLabel.Text = "Телефон";
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(15, 83);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(38, 13);
            this.addressLabel.TabIndex = 1;
            this.addressLabel.Text = "Адрес";
            // 
            // cityLabel
            // 
            this.cityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(15, 30);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(37, 13);
            this.cityLabel.TabIndex = 0;
            this.cityLabel.Text = "Город";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Коментарии";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 433);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(646, 53);
            this.textBox1.TabIndex = 3;
            // 
            // orderListBox
            // 
            this.orderListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderListBox.Controls.Add(this.ordersListDataGridView);
            this.orderListBox.Location = new System.Drawing.Point(12, 245);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(641, 158);
            this.orderListBox.TabIndex = 4;
            this.orderListBox.TabStop = false;
            this.orderListBox.Text = "Список заказов";
            // 
            // ordersListDataGridView
            // 
            this.ordersListDataGridView.AllowUserToAddRows = false;
            this.ordersListDataGridView.AllowUserToDeleteRows = false;
            this.ordersListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersListDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ordersListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderNumber,
            this.OrderDate,
            this.OrderSum,
            this.OrderState});
            this.ordersListDataGridView.Location = new System.Drawing.Point(15, 30);
            this.ordersListDataGridView.Name = "ordersListDataGridView";
            this.ordersListDataGridView.ReadOnly = true;
            this.ordersListDataGridView.Size = new System.Drawing.Size(615, 110);
            this.ordersListDataGridView.TabIndex = 0;
            // 
            // OrderNumber
            // 
            this.OrderNumber.HeaderText = "Номер заказа";
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "Дата заказа";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // OrderSum
            // 
            this.OrderSum.HeaderText = "Общая сумма заказа";
            this.OrderSum.Name = "OrderSum";
            this.OrderSum.ReadOnly = true;
            // 
            // OrderState
            // 
            this.OrderState.HeaderText = "Статус Заказа";
            this.OrderState.Name = "OrderState";
            this.OrderState.ReadOnly = true;
            // 
            // personalContactInfoTableLayoutPanel
            // 
            this.personalContactInfoTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personalContactInfoTableLayoutPanel.ColumnCount = 2;
            this.personalContactInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.personalContactInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.personalContactInfoTableLayoutPanel.Controls.Add(this.personalInfoBox, 0, 0);
            this.personalContactInfoTableLayoutPanel.Controls.Add(this.contactsInfoBox, 1, 0);
            this.personalContactInfoTableLayoutPanel.Location = new System.Drawing.Point(13, 13);
            this.personalContactInfoTableLayoutPanel.Name = "personalContactInfoTableLayoutPanel";
            this.personalContactInfoTableLayoutPanel.RowCount = 1;
            this.personalContactInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.personalContactInfoTableLayoutPanel.Size = new System.Drawing.Size(640, 226);
            this.personalContactInfoTableLayoutPanel.TabIndex = 5;
            // 
            // telephoneEmailtableLayoutPanel
            // 
            this.telephoneEmailtableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.telephoneEmailtableLayoutPanel.ColumnCount = 2;
            this.telephoneEmailtableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.3986F));
            this.telephoneEmailtableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.6014F));
            this.telephoneEmailtableLayoutPanel.Controls.Add(this.telephoneLabel, 0, 0);
            this.telephoneEmailtableLayoutPanel.Controls.Add(this.emailLabel, 1, 0);
            this.telephoneEmailtableLayoutPanel.Controls.Add(this.maskedTextBox1, 1, 1);
            this.telephoneEmailtableLayoutPanel.Controls.Add(this.textBox2, 0, 1);
            this.telephoneEmailtableLayoutPanel.Location = new System.Drawing.Point(18, 137);
            this.telephoneEmailtableLayoutPanel.Name = "telephoneEmailtableLayoutPanel";
            this.telephoneEmailtableLayoutPanel.RowCount = 2;
            this.telephoneEmailtableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.telephoneEmailtableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.telephoneEmailtableLayoutPanel.Size = new System.Drawing.Size(286, 63);
            this.telephoneEmailtableLayoutPanel.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(3, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 7;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox1.Location = new System.Drawing.Point(150, 17);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(133, 20);
            this.maskedTextBox1.TabIndex = 8;
            // 
            // CustomerDetailsViev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 511);
            this.Controls.Add(this.personalContactInfoTableLayoutPanel);
            this.Controls.Add(this.orderListBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(690, 550);
            this.Name = "CustomerDetailsViev";
            this.Text = "Заказчик";
            this.personalInfoBox.ResumeLayout(false);
            this.personalInfoBox.PerformLayout();
            this.contactsInfoBox.ResumeLayout(false);
            this.contactsInfoBox.PerformLayout();
            this.orderListBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersListDataGridView)).EndInit();
            this.personalContactInfoTableLayoutPanel.ResumeLayout(false);
            this.telephoneEmailtableLayoutPanel.ResumeLayout(false);
            this.telephoneEmailtableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox personalInfoBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.GroupBox contactsInfoBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox orderListBox;
        private System.Windows.Forms.DataGridView ordersListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderState;
        private System.Windows.Forms.TableLayoutPanel personalContactInfoTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel telephoneEmailtableLayoutPanel;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}