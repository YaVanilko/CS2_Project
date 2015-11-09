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
using Domain.Entities;

namespace ContosoUI.Order
{
    public partial class AddEditOrderView : XtraForm
    {
        AddEditOrderPresenter presenter;

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

            goodsRowGridControl.DataBindings.Add("DataSource", bindings, "vm");
            goodsComboBox.DataBindings.Add("SelectedItem", bindings, "SelectedGood");

            countOfGoodTextEdit.DataBindings.Add("Text", bindings, "CountOfGood");

        }

        private void addCommentButton_Click(object sender, EventArgs e)
        {
            bindings.EndEdit();
            presenter.AddComment();
            //commentTextEdit.Text = "";

        }

        private void addGoodButton_Click(object sender, EventArgs e)
        {
            bindings.EndEdit();
            goodsRowBindingSource.EndEdit();

            if (ValidateCount())
            { 
                presenter.AddGoodRow();
                countOfGoodTextEdit.Text = "0";
                goodsRowGridControl.RefreshDataSource();
                priceEdit.Text = Convert.ToString(presenter.TotalCost);
            }
            else
            {
                MessageBox.Show("Некорректное кол-во товаров", buttons: MessageBoxButtons.OK, caption: "Уведомление");
            }
        }

        private void saveOrderButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            goodsRowBindingSource.EndEdit();
            bindings.EndEdit();
            presenter.Save();
        }

        private void saveAndNewOrderButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            goodsRowBindingSource.EndEdit();
            presenter.SaveAndNew();
            goodsRowGridControl.RefreshDataSource();
        }

        private void ordersGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = ordersGridView;
            object goodsRow = view.GetRow(view.FocusedRowHandle);
            DialogResult result;
            if (goodsRow is GoodsRow)
            {
                GoodsRow row = goodsRow as GoodsRow;

                if (e.Column.AbsoluteIndex != 5)
                {
                    return;
                }
                else
                {
                    if (!row.IsActive)
                    {
                        result = MessageBox.Show("Вы уверенны, что хотите удалить поле из заказа?", buttons: MessageBoxButtons.OKCancel, caption: "Деактивация поля");
                        if (result == DialogResult.OK)
                        {
                            presenter.SetIsActive(e.RowHandle);
                            priceEdit.Text = Convert.ToString(presenter.TotalCost);
                        }
                    }
                    else
                    { 
                        result = MessageBox.Show("Вы уверенны, что хотите вернуть поле в заказ?", buttons: MessageBoxButtons.OKCancel, caption: "Деактивация поля");
                        if (result == DialogResult.OK)
                        {
                            presenter.SetIsActive(e.RowHandle);
                            priceEdit.Text = Convert.ToString(presenter.TotalCost);
                        }
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

        private void AddEditOrderView_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}