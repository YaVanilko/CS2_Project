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

        private void CustomerDetailsViev_Load(object sender, EventArgs e)
        {
            this.customerBindingSource.DataSource = presenter;
            firstNameTextEdit.DataBindings.Add("EditValue", customerBindingSource, "FirstName");
            lastNameTextEdit.DataBindings.Add("EditValue", customerBindingSource, "LastName");
            middleNameTextEdit.DataBindings.Add("EditValue", customerBindingSource, "MiddleName");
            cityTextEdit.DataBindings.Add("EditValue", customerBindingSource, "City");
            addressTextEdit.DataBindings.Add("EditValue", customerBindingSource, "Address");
            telephoneTextEdit.DataBindings.Add("EditValue", customerBindingSource, "Telephone");
            emailTextEdit.DataBindings.Add("EditValue", customerBindingSource, "Email");
            ordersGridControl.DataBindings.Add("DataSource", customerBindingSource, "Orders");
            commentsListBoxControl.DataBindings.Add("DataSource", customerBindingSource, "Comments");
            commentMemoEdit.DataBindings.Add("EditValue", customerBindingSource, "CurentComment");
        }

        private void saveEditButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            customerBindingSource.EndEdit();
            presenter.Save();
        }

        private void saveAndNewButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            customerBindingSource.EndEdit();
            presenter.SaveAndNew();
        }
    }
}
