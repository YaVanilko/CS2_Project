using ContosoUI.Customers.Add;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContosoUI.Customers.Search
{
    public partial class CustomersListView : DevExpress.XtraEditors.XtraForm
    {
        CustomersListPresenter presenter;
        public CustomersListView()
        {
            InitializeComponent();
            presenter = new CustomersListPresenter(this);
        }
        public void Refresh()
        {
            filterCityComboBoxEdit.Properties.Items.Clear();
            filterCityComboBoxEdit.Properties.Items.Add("Все города");
            filterCityComboBoxEdit.Properties.Items.AddRange(presenter.Cities.ToArray());
            filterCityComboBoxEdit.SelectedIndex = 0;
            customersGridControl.DataSource = presenter.viewModel;
            customersGridControl.RefreshDataSource();
        }
        private void CustomersListView_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void customersGridView_DoubleClick(object sender, EventArgs e)
        {
            GridHitInfo hi = customersGridView.CalcHitInfo(customersGridControl.PointToClient(MousePosition));
            if (hi.InRowCell)
            {
                GridView view = (GridView)sender;
                GridHitInfo info = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
                int id = (int)view.GetRowCellValue(info.RowHandle, "Id");
                var form = new CustomerDetailsViev(id);
                form.MdiParent = this.MdiParent;
                form.Show();
            }
        }

        private void searchButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            presenter.SearchCustomers(filterCityComboBoxEdit.Text);
            Refresh();
        }

        private void saveButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string FileName = saveFileDialog1.FileName;
                customersGridView.ExportToXls(FileName);
            }
        }

        private void printButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            customersGridView.ShowPrintPreview();
            customersGridView.Print();
        }
    }
}
