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
        BindingSource bs;

        public AddGoods(int id = -1)
        {
            InitializeComponent();
            presenter = new AddGoodsPresenter(this, id);
            bs = new BindingSource();
            bs.DataSource = presenter;
            this.Text = "Редактировать товар";
           // addGoodsCheckBoxIsActive.Checked = true;
            if (presenter.Categories.Count < 1)
            {
                MessageBox.Show("Нет категорий товаров. Невозможно добавить новый товар");
                //return;
            }

            else
            {
                addGoodsTextBoxName.DataBindings.Add("EditValue", bs, "Name");
                addGoodsTextBoxSKU.DataBindings.Add("EditValue", bs, "SKU");
                addGoodsTextBoxCount.DataBindings.Add("EditValue", bs, "Count");
                addGoodsTextBoxPrice.DataBindings.Add("EditValue", bs, "Price");

                addGoodsLookUpEditCategory.Properties.DataSource = presenter.Categories;
                addGoodsLookUpEditCategory.DataBindings.Add("EditValue", bs, "Category");

                addGoodsTextBoxComent.DataBindings.Add("EditValue", bs, "CurentComment");
       
                addGoodsCheckBoxIsActive.DataBindings.Add("EditValue", bs, "IsActive");

            }
            
        }


        private void saveGoodsButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

           
        }

        private void addGoodsCheckBoxIsActive_CheckedChanged(object sender, EventArgs e)
        {
            bs.EndEdit();
        }

        private void saveGoodsButton1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (addGoodsTextBoxName.Text == "" || addGoodsTextBoxSKU.Text == "" || addGoodsTextBoxPrice.Text == "" ||
               addGoodsTextBoxCount.Text == "")
            { MessageBox.Show("Вы заполнили не все поля"); }
            if (addGoodsTextBoxName.Text.Length > 255)
            { MessageBox.Show("Значие поля Название слишком длинное"); }

            if (addGoodsTextBoxSKU.Text.Length > 50)
            { MessageBox.Show("Значение поля Артикул слишком длинное"); }
            double price;
            Int16 count;
            Goods goods = new Goods();
            goods.Name = addGoodsTextBoxName.Text;
            goods.SKU = addGoodsTextBoxSKU.Text;
            if (!Double.TryParse(addGoodsTextBoxPrice.Text, out price))
            { MessageBox.Show("Вы заполнили поле Цена неправильно"); };
            goods.Price = price;
            Comment newComment = new Comment();
            newComment.Message = addGoodsTextBoxComent.Text;
            goods.Coments.Add(newComment);
            if (!Int16.TryParse(addGoodsTextBoxCount.Text, out count))
            { MessageBox.Show("Вы заполнили поле Количество неправильно"); };
            goods.Count = count;

            if (addGoodsCheckBoxIsActive.Checked)
            {
                goods.IsActive = true;
            }
            else goods.IsActive = false;


            var categorySt = addGoodsLookUpEditCategory.GetColumnValue("Id");
            //goods.Category=categorySt;
            bs.EndEdit();
            presenter.Save();

        }

       
    }
}
