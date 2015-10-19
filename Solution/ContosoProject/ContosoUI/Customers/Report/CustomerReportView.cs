using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContosoUI.Customers.Report
{
    public partial class CustomerReportView : Form
    {
        CustomerReportPresenter presenter;
        public CustomerReportView()
        {
            InitializeComponent();
            presenter = new CustomerReportPresenter(this);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            presenter.SearchCustomersForReport(cityFilterComboBoxEdit.Text);
            Refresh();
        }
        public void Refresh()
        {
            cityFilterComboBoxEdit.Properties.Items.Clear();
            cityFilterComboBoxEdit.Properties.Items.AddRange(presenter.Cities.ToArray());
            cityFilterComboBoxEdit.Properties.Items.Add("Все города");
            customerReportGridControl.DataSource = presenter.Customers;
            customerReportGridControl.RefreshDataSource();
        }

        private void CustomerReportView_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void printButton_Click(object sender, EventArgs e)
        {

        }
    }
}
