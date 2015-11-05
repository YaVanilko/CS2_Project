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
            DataTable tableCategory = new DataTable();
            tableCategory.Columns.Add("Name");
            tableCategory.Columns.Add("Id");
            
            foreach(ProductCategory pc in presenter.productCategoryList)
            {
               tableCategory.Rows.Add(pc.CategoryName, pc.Id);
            }
            AddGoodsLookUpEditCategory.Properties.DataSource = tableCategory;
            AddGoodsLookUpEditCategory.Properties.DisplayMember = "Name";
            AddGoodsLookUpEditCategory.Properties.ValueMember = "Id";
           // AddGoodsComboBoxEditCategory.Properties.Items.AddRange(presenter.productCategoryList.ToArray());

        }

        public AddGoods(int id)
        {
            idGoods = id;
            InitializeComponent();
            DataSet ds = new DataSet();
            BindingSource dsCategory = new BindingSource(ds, "Category");
            AddGoodsPresenter presenter = new AddGoodsPresenter(this, id);
            //AddGoodsComboBoxEditCategory.Properties.Items.AddRange(presenter.productCategoryList.ToArray());
            this.Text = "Редактировать товар";
            AddGoodsTextBoxName.DataBindings.Add("EditValue", presenter, "Name");
            AddGoodsTextBoxSKU.DataBindings.Add("EditValue", presenter, "SKU");
            AddGoodsTextBoxCount.DataBindings.Add("EditValue", presenter, "Count");
            AddGoodsTextBoxPrice.DataBindings.Add("EditValue", presenter, "Price");
           // int CategoryId = presenter.service.CategoryDao.GetByName(AddGoodsComboBoxEditCategory.SelectedItem);
            //AddGoodsComboBoxEditCategory.SelectedItem = presenter.Category;
            AddGoodsLookUpEditCategory.DataBindings.Add("EditValue",dsCategory, "Id");
            AddGoodsTextBoxComent.DataBindings.Add("DataSource", presenter, "Coments");
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
            Goods goods = new Goods();
            goods.Name = AddGoodsTextBoxName.Text;
            goods.SKU = AddGoodsTextBoxSKU.Text;
            if (!Double.TryParse(AddGoodsTextBoxPrice.Text, out price))
            { MessageBox.Show("Вы заполнили поле Цена неправильно"); };
            goods.Price = price;
            Comment newComment = new Comment();
            newComment.Message = AddGoodsTextBoxComent.Text;
            goods.Coments.Add(newComment);
            if (!Int16.TryParse(AddGoodsTextBoxCount.Text, out count))
            { MessageBox.Show("Вы заполнили поле Количество неправильно"); };
            goods.Count = count;

            if (AddGoodsCheckBoxIsActive.Checked)
            {
                goods.IsActive = true;
            }
            else goods.IsActive = false;


            var categorySt = AddGoodsLookUpEditCategory.GetColumnValue("Id");
             goods.Category.Id=Convert.ToInt16(categorySt);
            if (idGoods < 0)
            {
                AddGoodsPresenter vm = new AddGoodsPresenter(this, -1);
               
                vm.Save(goods);
            }

            else
            {
                AddGoodsPresenter vm = new AddGoodsPresenter(this, idGoods);
               
                vm.Save(goods);
            }

        }

        //private void AddGoodsComboBoxEditCategory_TextChanged(object sender, EventArgs e)
        //{
        //    presenter.productCategoryList.Add(AddGoodsComboBoxEditCategory.Text);
        //}


    }
}
