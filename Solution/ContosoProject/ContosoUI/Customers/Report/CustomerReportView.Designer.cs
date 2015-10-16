namespace ContosoUI.Customers.Report
{
    partial class CustomerReportView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerReportView));
            this.customerReportPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.customerReportPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.customerReportDataGridView = new System.Windows.Forms.DataGridView();
            this.printButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveOrderCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityFilterLbel = new System.Windows.Forms.Label();
            this.cityFilterComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerReportPrintDocument
            // 
            this.customerReportPrintDocument.DocumentName = "CustomerReport";
            // 
            // customerReportPrintPreviewDialog
            // 
            this.customerReportPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.customerReportPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.customerReportPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.customerReportPrintPreviewDialog.Document = this.customerReportPrintDocument;
            this.customerReportPrintPreviewDialog.Enabled = true;
            this.customerReportPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("customerReportPrintPreviewDialog.Icon")));
            this.customerReportPrintPreviewDialog.Name = "customerReportPrintPreviewDialog";
            this.customerReportPrintPreviewDialog.Visible = false;
            // 
            // customerReportDataGridView
            // 
            this.customerReportDataGridView.AllowUserToAddRows = false;
            this.customerReportDataGridView.AllowUserToDeleteRows = false;
            this.customerReportDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerReportDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerReportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.MiddleName,
            this.City,
            this.Address,
            this.OrdersCount,
            this.ActiveOrderCount});
            this.customerReportDataGridView.Location = new System.Drawing.Point(24, 73);
            this.customerReportDataGridView.Name = "customerReportDataGridView";
            this.customerReportDataGridView.ReadOnly = true;
            this.customerReportDataGridView.Size = new System.Drawing.Size(726, 369);
            this.customerReportDataGridView.TabIndex = 0;
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.printButton.Location = new System.Drawing.Point(24, 457);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(123, 23);
            this.printButton.TabIndex = 1;
            this.printButton.Text = "Печатать";
            this.printButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Location = new System.Drawing.Point(174, 457);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(116, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Имя";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Фамилия";
            this.LastName.Name = "LastName";
            // 
            // MiddleName
            // 
            this.MiddleName.HeaderText = "Отчество";
            this.MiddleName.Name = "MiddleName";
            // 
            // City
            // 
            this.City.HeaderText = "Город";
            this.City.Name = "City";
            // 
            // Address
            // 
            this.Address.HeaderText = "Адрес";
            this.Address.Name = "Address";
            // 
            // OrdersCount
            // 
            this.OrdersCount.HeaderText = "Количество заказов";
            this.OrdersCount.Name = "OrdersCount";
            // 
            // ActiveOrderCount
            // 
            this.ActiveOrderCount.HeaderText = "Количество незакрытых заказов";
            this.ActiveOrderCount.Name = "ActiveOrderCount";
            // 
            // cityFilterLbel
            // 
            this.cityFilterLbel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cityFilterLbel.AutoSize = true;
            this.cityFilterLbel.Location = new System.Drawing.Point(24, 26);
            this.cityFilterLbel.Name = "cityFilterLbel";
            this.cityFilterLbel.Size = new System.Drawing.Size(83, 13);
            this.cityFilterLbel.TabIndex = 3;
            this.cityFilterLbel.Text = "Выбрать город";
            // 
            // cityFilterComboBox
            // 
            this.cityFilterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cityFilterComboBox.FormattingEnabled = true;
            this.cityFilterComboBox.Items.AddRange(new object[] {
            "Все города",
            "Днепропетровск",
            "Днепродзержинск",
            "Одесса",
            "Львов",
            "Черновцы",
            "Ужгород",
            "Киев"});
            this.cityFilterComboBox.Location = new System.Drawing.Point(113, 23);
            this.cityFilterComboBox.Name = "cityFilterComboBox";
            this.cityFilterComboBox.Size = new System.Drawing.Size(258, 21);
            this.cityFilterComboBox.TabIndex = 4;
            // 
            // CustomerReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 511);
            this.Controls.Add(this.cityFilterComboBox);
            this.Controls.Add(this.cityFilterLbel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.customerReportDataGridView);
            this.MinimumSize = new System.Drawing.Size(690, 550);
            this.Name = "CustomerReportView";
            this.Text = "Отчет по клиентам";
            ((System.ComponentModel.ISupportInitialize)(this.customerReportDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument customerReportPrintDocument;
        private System.Windows.Forms.PrintPreviewDialog customerReportPrintPreviewDialog;
        private System.Windows.Forms.DataGridView customerReportDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdersCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveOrderCount;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label cityFilterLbel;
        private System.Windows.Forms.ComboBox cityFilterComboBox;

    }
}