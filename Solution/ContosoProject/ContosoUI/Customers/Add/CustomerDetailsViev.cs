using ContosoUI.Order;
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
            isActiveCustomerCheckEdit.DataBindings.Add("EditValue", customerBindingSource, "IsActive");
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
        public bool ShowValidationDialog(string caption, string message)
        {
            bool isOk = false;
            DialogResult result = MessageBox.Show(caption, message, buttons: MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                isOk = true;
            }
            return isOk;
        }

        private void customerOrderGridView_DoubleClick(object sender, EventArgs e)
        {
            GridHitInfo hi = customerOrderGridView.CalcHitInfo(ordersGridControl.PointToClient(MousePosition));
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
