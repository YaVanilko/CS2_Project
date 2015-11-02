using System;
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
            BindingSource bindings = new BindingSource();
            bindings.DataSource = presenter;

            statusComboBox.DataSource = presenter.Statuses;
            //statusComboBox.DataBindings.Add("DataSource", bindings, "Statuses");
            statusComboBox.SelectedItem = "Все статусы";
            resultGridControl.DataSource = presenter.viewModel;
            //statusComboBox.DataBindings.Add("DataSource", bindings, "Statuses");
        }

        private void searchBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            presenter.SelectOrdersByStatus(statusComboBox.Text);
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
    }
}