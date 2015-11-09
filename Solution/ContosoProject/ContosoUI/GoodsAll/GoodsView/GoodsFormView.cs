using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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

namespace ContosoUI.GoodsAll.GoodsF
{
    public partial class GoodsForm : Form
    {
        int goodsID;
        private GoodsPresenter presenter;

        public GoodsForm()
        {
            List<Domain.Entities.ProductCategory> categoryList = new List<ProductCategory>();
            InitializeComponent();
            presenter = new GoodsPresenter(this);
            goodsComboBoxCategory.Properties.Items.Add("Все");
            goodsComboBoxCategory.Properties.Items.AddRange(presenter.productCategoryList.ToArray());
            goodsComboBoxCategory.SelectedIndex = 0;

            this.goodsComboBoxCategory.SelectedIndexChanged += new EventHandler(GoodsComboBoxCategory_SelectedIndexChanged);


        }
        public void SetGoodsCategory(List<Domain.Entities.ProductCategory> categoryList)
        {
            foreach (ProductCategory productCategory in categoryList)
            {
                goodsComboBoxCategory.Properties.Items.Add("Все");
                goodsComboBoxCategory.Properties.Items.Add(productCategory.CategoryName);
            }
        }

        private void IsActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.goodsBindingSource.DataSource = presenter.SearchGoodsOnActivity(isActiveCheckBox.Checked);
            goodsGridControl.RefreshDataSource();
        }

        private void GoodsComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.goodsBindingSource.DataSource = presenter.SearchGoodsOnCategory(goodsComboBoxCategory.SelectedItem.ToString());
            goodsGridControl.RefreshDataSource();
        }

        private void GoodsPrintBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            goodsGridControl.ShowPrintPreview();
            goodsGridControl.Print();
        }

    
        private void GoodsComboBoxCategory_TextChanged(object sender, EventArgs e)
        {
            presenter.productCategoryList.Add(goodsComboBoxCategory.Text);
        }

        private void goodsGreedView_DoubleClick(object sender, EventArgs e)
        {
            GridHitInfo hitInfo = goodsGreedView.CalcHitInfo(goodsGridControl.PointToClient(MousePosition));
            if (hitInfo.InRow || hitInfo.InRowCell)
            {
                GridView gv = (GridView)sender;
                GridHitInfo gridInfo = gv.CalcHitInfo(gv.GridControl.PointToClient(Control.MousePosition));
                goodsID = (int)gv.GetRowCellValue(gridInfo.RowHandle, "Id");

                AddGoods.AddGoods frm = new AddGoods.AddGoods(goodsID);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }

        private void SearchbarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.goodsBindingSource.DataSource = presenter.SearchGoodsOnCategory(goodsComboBoxCategory.SelectedItem.ToString());
            goodsGridControl.RefreshDataSource();
        }

        private void exportBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "xls files (*.xls)|*.xls|All files(*.*)|*.*";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveDialog.FileName;
                goodsGridControl.ExportToXls(fileName);

            }
        }



    }
}
