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
        }

        private void searchBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void resultGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}