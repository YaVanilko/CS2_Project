using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContosoUI.Customers.Search
{
    public partial class CustomersListView : Form
    {
        private CustomersListPresenter presenter;
        public CustomersListView()
        {
            InitializeComponent();
            presenter = new CustomersListPresenter(this);
        }
        public void Refresh()
        {
            filterCityComboBoxEdit.Properties.Items.Clear();
            filterCityComboBoxEdit.Properties.Items.AddRange(presenter.Cities.ToArray());
            filterCityComboBoxEdit.Properties.Items.Add("Все города");
            customersGridControl.DataSource = presenter.Customers;
            customersGridControl.RefreshDataSource();
        }

        private void searchCustomersButton_Click(object sender, EventArgs e)
        {
            presenter.SearchCustomers(filterCityComboBoxEdit.Text);
            Refresh();
        }

        private void CustomersListView_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void DoRowDoubleClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
            }

        }
        private void customersGridView_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            DoRowDoubleClick(view, pt);
        }

    }
}
