using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;

namespace ContosoUI.Order.Search
{
    public partial class SearchView : XtraForm
    {
        SearchPresenter presenter;
        IUserNotify notifyManager = Program.MainWiewInstance;
        const int defaultIndex = 5;

        public SearchView()
        {
            InitializeComponent();
            presenter = new SearchPresenter(this);
        }

        private void SearchView_Load(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = presenter;

            statusComboBox.DataBindings.Add("DataSource", orderBindingSource, "StatusesList");
            statusComboBox.SelectedIndex = defaultIndex;

            resultGridControl.DataBindings.Add("DataSource", orderBindingSource, "OrdersList");
            
        }

        private void searchBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            presenter.SelectOrdersByStatus(statusComboBox.SelectedValue as Domain.Entities.OrderStatus);
            resultGridControl.RefreshDataSource();
        }

        private void ordersGridView__DoubleClick(object sender, EventArgs e)
        {
            GridHitInfo hi = ordersGridView.CalcHitInfo(resultGridControl.PointToClient(MousePosition));
            if (hi.InRowCell)
            {
                GridView view = (GridView)sender;
                GridHitInfo info = view.CalcHitInfo(view.GridControl.PointToClient(MousePosition));
                int id = (int)view.GetRowCellValue(info.RowHandle, "Id");
                var form = new AddEditOrderView(id);
                form.MdiParent = MdiParent;
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