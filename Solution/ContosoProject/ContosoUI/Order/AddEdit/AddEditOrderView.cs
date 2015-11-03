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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;

namespace ContosoUI.Order
{
    public partial class AddEditOrderView : XtraForm
    {
        AddEditOrderPresenter presenter;

        public AddEditOrderView(int id = -1)
        {
            InitializeComponent();
            presenter = new AddEditOrderPresenter(this, id);
        }

        private void AddEditOrderView_Load(object sender, EventArgs e)
        {
            BindingSource bindings = new BindingSource();
            bindings.DataSource = presenter;

            customerComboBox.DataBindings.Clear();
            customerComboBox.DataBindings.Add("DataSource", bindings, "Customers");
            customerComboBox.DataBindings.Add("SelectedItem", bindings, "Customer");

            priceEdit.Text = Convert.ToString(presenter.TotalCost);

            statusComboBox.DataBindings.Clear();
            statusComboBox.DataBindings.Add("DataSource", bindings, "Statuses");
            statusComboBox.DataBindings.Add("SelectedItem", bindings, "Status");

            goodsComboBox.DataBindings.Clear();
            goodsComboBox.DataBindings.Add("DataSource", bindings, "GoodsList");

            commentsListBox.DataBindings.Clear();
            commentsListBox.DataBindings.Add("DataSource", bindings, "Comments");

            commentTextEdit.DataBindings.Clear();
            commentTextEdit.DataBindings.Add("Text", bindings, "Message");

            addEditViewModelBindingSource.DataSource = presenter;
            goodsRowGridControl.DataBindings.Add("DataSource", addEditViewModelBindingSource, "vm");
            goodsComboBox.DataBindings.Add("SelectedItem", addEditViewModelBindingSource, "SelectedGood");
            countOfGoodTextEdit.DataBindings.Add("Text", addEditViewModelBindingSource, "CountOfGood");

        }

        private void addCommentButton_Click(object sender, EventArgs e)
        {
            presenter.AddNewComment(presenter.Comment);
            commentTextEdit.Text = "";
        }

        private void addGoodButton_Click(object sender, EventArgs e)
        {
            presenter.AddNewGoodRow();
            countOfGoodTextEdit.Text = "";
            goodsRowGridControl.RefreshDataSource();
        }

        private void deleteGoodButton_Click(object sender, EventArgs e)
        {
        }

        private void saveOrderButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addEditViewModelBindingSource.EndEdit();
            presenter.Save();
        }

        private void saveAndNewOrderButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addEditViewModelBindingSource.EndEdit();
            presenter.SaveAndNew();
        }
    }
}