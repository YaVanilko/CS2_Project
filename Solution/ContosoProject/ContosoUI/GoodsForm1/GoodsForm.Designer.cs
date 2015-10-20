namespace ContosoUI.GoodsForm1
{
    partial class GoodsForm
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
            this.GoodsCategoryComboBoxDE = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.GoodsGroupBox = new System.Windows.Forms.GroupBox();
            this.GoodsButtonSearch = new System.Windows.Forms.Button();
            this.GoodsButtonReport = new System.Windows.Forms.Button();
            this.GoodsGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GoodsButtonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsCategoryComboBoxDE.Properties)).BeginInit();
            this.GoodsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GoodsCategoryComboBoxDE
            // 
            this.GoodsCategoryComboBoxDE.Location = new System.Drawing.Point(6, 35);
            this.GoodsCategoryComboBoxDE.Name = "GoodsCategoryComboBoxDE";
            this.GoodsCategoryComboBoxDE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GoodsCategoryComboBoxDE.Size = new System.Drawing.Size(195, 20);
            this.GoodsCategoryComboBoxDE.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Products category";
            // 
            // GoodsGroupBox
            // 
            this.GoodsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GoodsGroupBox.Controls.Add(this.GoodsButtonReport);
            this.GoodsGroupBox.Controls.Add(this.GoodsButtonSearch);
            this.GoodsGroupBox.Controls.Add(this.label1);
            this.GoodsGroupBox.Controls.Add(this.GoodsCategoryComboBoxDE);
            this.GoodsGroupBox.Location = new System.Drawing.Point(3, 2);
            this.GoodsGroupBox.Name = "GoodsGroupBox";
            this.GoodsGroupBox.Size = new System.Drawing.Size(917, 100);
            this.GoodsGroupBox.TabIndex = 2;
            this.GoodsGroupBox.TabStop = false;
            this.GoodsGroupBox.Text = "Filter";
            // 
            // GoodsButtonSearch
            // 
            this.GoodsButtonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GoodsButtonSearch.Location = new System.Drawing.Point(836, 71);
            this.GoodsButtonSearch.Name = "GoodsButtonSearch";
            this.GoodsButtonSearch.Size = new System.Drawing.Size(75, 23);
            this.GoodsButtonSearch.TabIndex = 2;
            this.GoodsButtonSearch.Text = "Search";
            this.GoodsButtonSearch.UseVisualStyleBackColor = true;
            this.GoodsButtonSearch.Click += new System.EventHandler(this.GoodsButtonSearch_Click);
            // 
            // GoodsButtonReport
            // 
            this.GoodsButtonReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GoodsButtonReport.Location = new System.Drawing.Point(735, 71);
            this.GoodsButtonReport.Name = "GoodsButtonReport";
            this.GoodsButtonReport.Size = new System.Drawing.Size(75, 23);
            this.GoodsButtonReport.TabIndex = 3;
            this.GoodsButtonReport.Text = "Report";
            this.GoodsButtonReport.UseVisualStyleBackColor = true;
            this.GoodsButtonReport.Click += new System.EventHandler(this.GoodsButtonReport_Click);
            // 
            // GoodsGridControl
            // 
            this.GoodsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GoodsGridControl.Location = new System.Drawing.Point(3, 109);
            this.GoodsGridControl.MainView = this.gridView1;
            this.GoodsGridControl.Name = "GoodsGridControl";
            this.GoodsGridControl.Size = new System.Drawing.Size(917, 242);
            this.GoodsGridControl.TabIndex = 3;
            this.GoodsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GoodsGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // GoodsButtonCancel
            // 
            this.GoodsButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GoodsButtonCancel.Location = new System.Drawing.Point(838, 358);
            this.GoodsButtonCancel.Name = "GoodsButtonCancel";
            this.GoodsButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.GoodsButtonCancel.TabIndex = 4;
            this.GoodsButtonCancel.Text = "Cancel";
            this.GoodsButtonCancel.UseVisualStyleBackColor = true;
            this.GoodsButtonCancel.Click += new System.EventHandler(this.GoodsButtonCancel_Click);
            // 
            // GoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 385);
            this.Controls.Add(this.GoodsButtonCancel);
            this.Controls.Add(this.GoodsGridControl);
            this.Controls.Add(this.GoodsGroupBox);
            this.Name = "GoodsForm";
            this.Text = "GoodsForm";
            ((System.ComponentModel.ISupportInitialize)(this.GoodsCategoryComboBoxDE.Properties)).EndInit();
            this.GoodsGroupBox.ResumeLayout(false);
            this.GoodsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit GoodsCategoryComboBoxDE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GoodsGroupBox;
        private System.Windows.Forms.Button GoodsButtonReport;
        private System.Windows.Forms.Button GoodsButtonSearch;
        private DevExpress.XtraGrid.GridControl GoodsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button GoodsButtonCancel;
    }
}