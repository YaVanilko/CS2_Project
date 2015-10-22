using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContosoUI.Customers.Add
{
    public partial class CustomerDetailsViev : DevExpress.XtraEditors.XtraForm
    {
        private readonly CustomerDetailsPresenter presenter;
        public CustomerDetailsViev()
        {
            InitializeComponent();
            presenter = new CustomerDetailsPresenter(this, -1);
        }
        public CustomerDetailsViev(int id)
        {
            InitializeComponent();
            presenter = new CustomerDetailsPresenter(this, id);
        }
        private void Refresh()
        {
            firstNameTextEdit.Text = presenter.FirstName;
            lastNameTextEdit.Text = presenter.LastName;
            middleNameTextEdit.Text = presenter.MiddleName;
            cityTextEdit.Text = presenter.City;
            addressTextEdit.Text = presenter.Address;
            telephoneTextEdit.Text = presenter.Telephone;
            emailTextEdit.Text = presenter.Email;
            ordersGridControl.DataSource = presenter.Orders;
            ordersGridControl.RefreshDataSource();
            commentsListBoxControl.Items.AddRange(presenter.Comments.ToArray());
        }

        private void CustomerDetailsViev_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void saveEditButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void saveAndNewButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
