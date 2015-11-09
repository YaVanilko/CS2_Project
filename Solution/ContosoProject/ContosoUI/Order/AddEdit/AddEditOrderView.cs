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

            goodsComboBox.DataBindings.Clear();
            goodsComboBox.DataBindings.Add("DataSource", bindings, "Goods");

            commentsListBox.DataBindings.Clear();
            commentsListBox.DataBindings.Add("DataSource", bindings, "Comments");

            commentTextEdit.DataBindings.Clear();
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
            if (ValidateCount())
            {
                bindings.EndEdit();
                presenter.AddGoodRow();
                goodsRowGridControl.RefreshDataSource();
                priceEdit.Text = Convert.ToString(presenter.TotalCost);
            }
            else
            {
                bindings.EndEdit();
                goodsRowGridControl.RefreshDataSource();
                notifyManager.ShowInfo("Некорректное кол-во товаров", "Сообщение");
            }
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
            GridView view = ordersGridView;
            object goodsRow = view.GetRow(view.FocusedRowHandle);
            bool result;
            GoodsRow row = goodsRow as GoodsRow;

            if (!row.IsActive)
            {
                result = notifyManager.ShowYesNo("Вы уверенны, что хотите удалить поле из заказа?", "Сообщение");

                if (result)
                {
                    priceEdit.Text = Convert.ToString(presenter.TotalCost);
                }
                 else
                 { 
                    result = notifyManager.ShowYesNo("Вы уверенны, что хотите вернуть поле в заказ?", "Сообщение");
               
                    if (result)
                    {
                        priceEdit.Text = Convert.ToString(presenter.TotalCost);
                    }
                 }
             }
         }

        private bool ValidateCount()
        {
            bool result = false;
            int minValue = 0;
            int maxValue = int.MaxValue;
            int temp;
            int.TryParse(countOfGoodTextEdit.Text, out temp);

            if (temp > minValue && temp < maxValue)
            {
                result = true;
            }

            return result;
        }
    }
}