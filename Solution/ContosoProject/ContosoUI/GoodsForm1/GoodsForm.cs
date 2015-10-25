using Data.DumbData;
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

namespace ContosoUI.GoodsForm1
{
    public partial class GoodsForm : Form, IGoodsView
    {
        int goodsID;
        private GoodsPresenter presenter;

        public GoodsForm()
        {
            InitializeComponent();
            presenter = new GoodsPresenter(this, new GoodsModel());//тут ругается на this
        }

        private void GoodsButtonSearch_Click(object sender, EventArgs e)
        {
            
       
        }

        private void GoodsButtonReport_Click(object sender, EventArgs e)
        {

        }

        private void GoodsButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetGoodsData(List<Domain.Entities.Goods> goodsList)
        {
            throw new NotImplementedException();
        }

        public void SetGoodsCategory(List<Domain.Entities.ProductCategory> categoryList)
        {
            foreach (ProductCategory productCategory in categoryList)
            {
                GoodsCategoryComboBoxDE.Properties.Items.Add(productCategory.CategoryName);
            }
        }


        public event EventHandler<EventArgs> loadGoodsForm;

        public event EventHandler<EventArgs> searchButtonClick;
    }
}
