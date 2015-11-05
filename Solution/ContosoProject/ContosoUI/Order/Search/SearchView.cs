﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;

namespace ContosoUI.Order.Search
{
    public partial class SearchView : DevExpress.XtraEditors.XtraForm
    {
        SearchPresenter presenter;
        
        public SearchView()
        {
            InitializeComponent();
            presenter = new SearchPresenter(this);
        }

        private void SearchView_Load(object sender, EventArgs e)
        {
            searchViewModelBindingSource.DataSource = presenter;

            statusComboBox.DataBindings.Add("DataSource", searchViewModelBindingSource, "StatusesList");
            statusComboBox.SelectedIndex = 5;

            resultGridControl.DataBindings.Add("DataSource", searchViewModelBindingSource, "viewModel");
            
        }

        private void searchBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Domain.Entities.OrderStatus currentStatus = new Domain.Entities.OrderStatus() { Status = statusComboBox.Text };
            presenter.SelectOrdersByStatus(currentStatus);
            resultGridControl.RefreshDataSource();
        }

        private void ordersGridView__DoubleClick(object sender, EventArgs e)
        {
            GridHitInfo hi = ordersGridView.CalcHitInfo(resultGridControl.PointToClient(MousePosition));
            if (hi.InRowCell)
            {
                GridView view = (GridView)sender;
                GridHitInfo info = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
                int id = (int)view.GetRowCellValue(info.RowHandle, "Id");
                var form = new AddEditOrderView(id);
                form.MdiParent = this.MdiParent;
                form.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
                ordersGridView.ExportToXls(FileName);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ordersGridView.ShowPrintPreview();
            ordersGridView.Print();
        }
    }
}