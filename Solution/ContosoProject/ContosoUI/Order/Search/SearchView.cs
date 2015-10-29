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
            statusComboBox.Items.Add("Все статусы");
            statusComboBox.Items.AddRange(presenter.statuses.ToArray());
        }

        private void searchBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            presenter.SelectOdersByStatus(statusComboBox.Text);
        }
    }
}