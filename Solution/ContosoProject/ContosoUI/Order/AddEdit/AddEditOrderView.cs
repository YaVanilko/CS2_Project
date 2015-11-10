using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ContosoUI.Order.AddEdit;
using DevExpress.XtraGrid.Views.Grid;
using Domain.Entities;

namespace ContosoUI.Order
{
    public partial class AddEditOrderView : XtraForm
    {
        AddEditOrderPresenter presenter;
        IUserNotify notifyManager = Program.MainWiewInstance;
        BindingSource bindings;

        public AddEditOrderView(int id = -1)
        {
            InitializeComponent();
            presenter = new AddEditOrderPresenter(this, id);
        }

        private void AddEditOrderView_Load(object sender, EventArgs e)
        {
            bindings = new BindingSource();
            bindings.DataSource = presenter;

            customerComboBox.DataBindings.Clear();
            customerComboBox.DataBindings.Add("DataSource", bindings, "Customers");
            customerComboBox.DataBindings.Add("SelectedItem", bindings, "Customer");

            priceEdit.DataBindings.Add("EditValue", bindings, "TotalCost");

            statusComboBox.DataBindings.Clear();
            statusComboBox.DataBindings.Add("DataSource", bindings, "Statuses");
            statusComboBox.DataBindings.Add("SelectedItem", bindings, "Status");

            goodsComboBox.DataBindings.Add("DataSource", bindings, "Goods");

            commentsListBox.DataBindings.Add("DataSource", bindings, "Comments");

            commentTextEdit.DataBindings.Add("EditValue", bindings, "Message");

            goodsRowGridControl.DataBindings.Add("DataSource", bindings, "GoodsListSource");
            goodsComboBox.DataBindings.Add("SelectedItem", bindings, "SelectedGood");

            countOfGoodTextEdit.DataBindings.Add("EditValue", bindings, "CountOfGood");

        }

        private void addCommentButton_Click(object sender, EventArgs e)
        {
            bindings.EndEdit();
            presenter.AddComment();
        }

        private void addGoodButton_Click(object sender, EventArgs e)
        {
            bindings.EndEdit();

            if (ValidateCount())
            {
                presenter.AddGoodRow();
                priceEdit.Text = Convert.ToString(presenter.TotalCost);
            }
            else
            {
                notifyManager.ShowInfo("Некорректное кол-во товаров", "Сообщение");
            }

            goodsRowGridControl.RefreshDataSource();
        }

        private void saveOrderButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindings.EndEdit();
            presenter.Save();
        }

        private void saveAndNewOrderButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindings.EndEdit();
            presenter.SaveAndNew();
            goodsRowGridControl.RefreshDataSource();
        }

        private void ordersGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            priceEdit.Text = Convert.ToString(presenter.TotalCost);
        }

        private bool ValidateCount()
        {
            int temp;
            int.TryParse(countOfGoodTextEdit.Text, out temp);

            return temp > 0 && temp < int.MaxValue;
        }
    }
}