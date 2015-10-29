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
        }

        public AddEditOrderView(int id)
        {
            InitializeComponent();
            presenter = new AddEditOrderPresenter(this, id);
        }

        private void AddEditOrderView_Load(object sender, EventArgs e)
        {
            BindingSource bindings = new BindingSource();

            bindings.DataSource = presenter;

        }
    }
}