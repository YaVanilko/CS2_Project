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
using ContosoUI.Order.AddEdit;

namespace ContosoUI.Order
{
    public partial class AddEditOrderView : XtraForm
    {
        AddEditOrderPresenter presenter;
        public AddEditOrderView() : this(-1)
        {
            InitializeComponent();
        }

        public AddEditOrderView(int id)
        {
            InitializeComponent();
            presenter = new AddEditOrderPresenter(this, 3);
        }

        private void AddEditOrderView_Load(object sender, EventArgs e)
        {
            BindingSource bindings = new BindingSource();
            bindings.DataSource = presenter;
            customerComboBoxEdit.DataBindings.Clear();
            //customerComboBoxEdit.DataBindings.Add("DataSource", bindings, "AllCustomers");
            customerComboBoxEdit.DataBindings.Add("EditValue", bindings, "CustomerToString");
            priceTextEdit.DataBindings.Clear();
            priceTextEdit.DataBindings.Add("Text", bindings, "TotalCost");
            //statusComboBoxEdit.DataBindings.Add("DataSource", bindings, "All statuses");
            //statusComboBoxEdit.DataBindings.Add("EditValue", bindings, "Status");

        }

        private void goodComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}