using DevExpress.XtraEditors;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContosoUI.GoodsAll.AddGoods
{
    public partial class AddGoods : XtraForm
    {
        private readonly AddGoodsPresenter presenter;
        int idGoods;

        public AddGoods()
        {
            InitializeComponent();
            presenter = new AddGoodsPresenter(this, -1);
            idGoods = -1;
            AddGoodsComboBoxEditCategory.Properties.Items.AddRange(presenter.productCategoryList.ToArray());

        }

        public AddGoods(int id)
        {
            idGoods = id;
            InitializeComponent();
            AddGoodsPresenter presenter = new AddGoodsPresenter(this, id);
            AddGoodsComboBoxEditCategory.Properties.Items.AddRange(presenter.productCategoryList.ToArray());
            this.Text = "Редактировать товар";
            AddGoodsTextBoxName.DataBindings.Add("EditValue", presenter, "Name");
            AddGoodsTextBoxSKU.DataBindings.Add("EditValue", presenter, "SKU");
            AddGoodsTextBoxCount.DataBindings.Add("EditValue", presenter, "Count");
            AddGoodsTextBoxPrice.DataBindings.Add("EditValue", presenter, "Price");
            AddGoodsComboBoxEditCategory.SelectedItem = presenter.Category;
            // AddGoodsTextBoxComent.DataBindings.Add("EditValue", presenter, "");
        }


        private void SaveGoodsButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


        }

        private void Со_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (AddGoodsTextBoxName.Text == "" || AddGoodsTextBoxSKU.Text == "" || AddGoodsTextBoxPrice.Text == "" ||
                AddGoodsTextBoxCount.Text == "")
            { MessageBox.Show("Вы заполнили не все поля"); }
            double price;
            Int16 count;

            if (idGoods < 0)
            {
                AddGoodsPresenter vm = new AddGoodsPresenter(this, -1);
                Goods goods = new Goods();
                goods.Name = AddGoodsTextBoxName.Text;
                goods.SKU = AddGoodsTextBoxSKU.Text;
                while (!Double.TryParse(AddGoodsTextBoxPrice.Text, out price))
                { MessageBox.Show("Вы заполнили поле Цена неправильно"); };
                goods.Price = price;

                while (!Int16.TryParse(AddGoodsTextBoxCount.Text, out count))
                { MessageBox.Show("Вы заполнили поле Количество неправильно"); };
                goods.Count = count;

                if (AddGoodsCheckBoxIsActive.Checked)
                {
                    goods.IsActive = true;
                }
                else goods.IsActive = false;

                goods.Category.CategoryName = AddGoodsComboBoxEditCategory.SelectedText;
                vm.Save(goods);
            }

            else
            {
                AddGoodsPresenter vm = new AddGoodsPresenter(this, idGoods);
                Goods goods = new Goods();
                goods.Name = AddGoodsTextBoxName.Text;
                goods.SKU = AddGoodsTextBoxSKU.Text;
                while (!Double.TryParse(AddGoodsTextBoxPrice.Text, out price))
                { MessageBox.Show("Вы заполнили поле Цена неправильно"); };
                goods.Price = price;

                while (!Int16.TryParse(AddGoodsTextBoxCount.Text, out count))
                { MessageBox.Show("Вы заполнили поле Количество неправильно"); };
                goods.Count = count;

                if (AddGoodsCheckBoxIsActive.Checked)
                {
                    goods.IsActive = true;
                }
                else goods.IsActive = false;

                goods.Category.CategoryName = AddGoodsComboBoxEditCategory.SelectedText;
                vm.Update(goods);
            }

        }

        private void AddGoodsComboBoxEditCategory_TextChanged(object sender, EventArgs e)
        {
            presenter.productCategoryList.Add(AddGoodsComboBoxEditCategory.Text);
        }


    }
}
