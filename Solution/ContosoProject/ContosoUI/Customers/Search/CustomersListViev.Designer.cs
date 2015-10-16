namespace ContosoUI.Customers.Search
{
    partial class CustomersListView
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
            this.customerFilterLableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cityLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.customerFiltergroupBox = new System.Windows.Forms.GroupBox();
            this.customerListGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountOrders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFilterLableLayoutPanel.SuspendLayout();
            this.customerFiltergroupBox.SuspendLayout();
            this.customerListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerFilterLableLayoutPanel
            // 
            this.customerFilterLableLayoutPanel.ColumnCount = 3;
            this.customerFilterLableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.customerFilterLableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.customerFilterLableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.customerFilterLableLayoutPanel.Controls.Add(this.cityLabel, 0, 0);
            this.customerFilterLableLayoutPanel.Controls.Add(this.FirstNameLabel, 1, 0);
            this.customerFilterLableLayoutPanel.Controls.Add(this.lastNameLabel, 2, 0);
            this.customerFilterLableLayoutPanel.Controls.Add(this.firstNameTextBox, 1, 1);
            this.customerFilterLableLayoutPanel.Controls.Add(this.lastNameTextBox, 2, 1);
            this.customerFilterLableLayoutPanel.Controls.Add(this.cityComboBox, 0, 1);
            this.customerFilterLableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerFilterLableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.customerFilterLableLayoutPanel.Name = "customerFilterLableLayoutPanel";
            this.customerFilterLableLayoutPanel.RowCount = 2;
            this.customerFilterLableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.37255F));
            this.customerFilterLableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.62745F));
            this.customerFilterLableLayoutPanel.Size = new System.Drawing.Size(644, 62);
            this.customerFilterLableLayoutPanel.TabIndex = 0;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(3, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(37, 13);
            this.cityLabel.TabIndex = 0;
            this.cityLabel.Text = "Город";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(219, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(29, 13);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "Имя";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(435, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Фамилия";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstNameTextBox.Location = new System.Drawing.Point(219, 22);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(210, 20);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastNameTextBox.Location = new System.Drawing.Point(435, 22);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(212, 20);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // cityComboBox
            // 
            this.cityComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cityComboBox.DropDownWidth = 205;
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Items.AddRange(new object[] {
            "Днепропетровск",
            "Днепродзержинск",
            "Одесса",
            "Львов",
            "Черновцы",
            "Ужгород",
            "Киев"});
            this.cityComboBox.Location = new System.Drawing.Point(3, 22);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(210, 21);
            this.cityComboBox.TabIndex = 5;
            // 
            // customerFiltergroupBox
            // 
            this.customerFiltergroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerFiltergroupBox.Controls.Add(this.customerFilterLableLayoutPanel);
            this.customerFiltergroupBox.Location = new System.Drawing.Point(12, 12);
            this.customerFiltergroupBox.Name = "customerFiltergroupBox";
            this.customerFiltergroupBox.Size = new System.Drawing.Size(650, 81);
            this.customerFiltergroupBox.TabIndex = 1;
            this.customerFiltergroupBox.TabStop = false;
            this.customerFiltergroupBox.Text = "Поиск клиентов";
            // 
            // customerListGroupBox
            // 
            this.customerListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerListGroupBox.Controls.Add(this.dataGridView1);
            this.customerListGroupBox.Location = new System.Drawing.Point(12, 112);
            this.customerListGroupBox.Name = "customerListGroupBox";
            this.customerListGroupBox.Size = new System.Drawing.Size(650, 387);
            this.customerListGroupBox.TabIndex = 2;
            this.customerListGroupBox.TabStop = false;
            this.customerListGroupBox.Text = "Список клиентов";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.MiddleName,
            this.City,
            this.CountOrders});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(638, 362);
            this.dataGridView1.TabIndex = 0;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Имя";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Фамилия";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // MiddleName
            // 
            this.MiddleName.HeaderText = "Отчество";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.ReadOnly = true;
            // 
            // City
            // 
            this.City.HeaderText = "Город";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // CountOrders
            // 
            this.CountOrders.HeaderText = "Количество заказов";
            this.CountOrders.Name = "CountOrders";
            this.CountOrders.ReadOnly = true;
            // 
            // CustomersListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 511);
            this.Controls.Add(this.customerListGroupBox);
            this.Controls.Add(this.customerFiltergroupBox);
            this.MinimumSize = new System.Drawing.Size(690, 550);
            this.Name = "CustomersListView";
            this.Text = "Список клиентов";
            this.customerFilterLableLayoutPanel.ResumeLayout(false);
            this.customerFilterLableLayoutPanel.PerformLayout();
            this.customerFiltergroupBox.ResumeLayout(false);
            this.customerListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel customerFilterLableLayoutPanel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.GroupBox customerFiltergroupBox;
        private System.Windows.Forms.GroupBox customerListGroupBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountOrders;
    }
}