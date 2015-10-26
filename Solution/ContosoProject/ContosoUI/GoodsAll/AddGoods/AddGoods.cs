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


        public AddGoods()
        {
            InitializeComponent();
            presenter = new AddGoodsPresenter(this, -1);
           // this.Text = "Новый товар";
        }

        public AddGoods(int id)
        {
            InitializeComponent();
            AddGoodsPresenter presenter = new AddGoodsPresenter(this, id);
            this.Text = "Редактировать товар";

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void AddGoodsSaveButton_Click(object sender, EventArgs e)
        {
            if (AddGoodsTextBoxName.Text == "" || AddGoodsTextBoxSKU.Text == "" || AddGoodsTextBoxPrice.Text==""||
                AddGoodsTextBoxCount.Text=="")
            {MessageBox.Show("Вы заполнили не все поля");}
            double price;
            Int16 count;
           
            AddGoodsPresenter vm = new AddGoodsPresenter(this, -1);
             Goods goods=new Goods();
            goods.Name=AddGoodsTextBoxName.Text ;
            goods.SKU=AddGoodsTextBoxSKU.Text ;
           while (!Double.TryParse(AddGoodsTextBoxPrice.Text, out price)) 
            {MessageBox.Show("Вы заполнили поле Цена неправильно");};
             goods.Price= price;

             while (!Int16.TryParse(AddGoodsTextBoxCount.Text, out count))
             { MessageBox.Show("Вы заполнили поле Количество неправильно"); };
             goods.Count=count;

             if (AddGoodsCheckBoxIsActive.Checked)
             {
                 goods.IsActive = true;
             }
             else goods.IsActive = false;
            
            goods.Category.CategoryName = AddGoodsComboBoxEditCategory.SelectedText;
            vm.Save(goods);
            
           
        }
    }
}
