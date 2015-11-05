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
            GoodsComboBoxCategory.Properties.Items.Add("Все");
            GoodsComboBoxCategory.Properties.Items.AddRange(presenter.productCategoryList.ToArray());
            // GoodsComboBoxCategory.SelectedIndex = 0;

            this.GoodsComboBoxCategory.SelectedIndexChanged += new EventHandler(GoodsComboBoxCategory_SelectedIndexChanged);


        }
        public void SetGoodsCategory(List<Domain.Entities.ProductCategory> categoryList)
        {
            foreach (ProductCategory productCategory in categoryList)
            {
                GoodsComboBoxCategory.Properties.Items.Add("Все");
                GoodsComboBoxCategory.Properties.Items.Add(productCategory.CategoryName);
            }
        }

        private void IsActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.goodsBindingSource.DataSource = presenter.SearchGoodsOnActivity(IsActiveCheckBox.Checked);
            GoodsGridControl.RefreshDataSource();
        }

        private void GoodsComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.goodsBindingSource.Clear();
            this.goodsBindingSource.DataSource = presenter.SearchGoodsOnCategory(GoodsComboBoxCategory.SelectedItem.ToString());
            GoodsGridControl.RefreshDataSource();
        }

        private void GoodsGridControl_Click(object sender, EventArgs e)
        {
           

        }

        private void GoodsButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "xls files (*.xls)|*.xls|All files(*.*)|*.*";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveDialog.FileName;
                GoodsGridControl.ExportToXls(fileName);

            }
        }

        private void GoodsPrintButton_Click(object sender, EventArgs e)
        {
            GoodsGridControl.ShowPrintPreview();
            GoodsGridControl.Print();
        }

        private void GoodsPrintBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GoodsGridControl.ShowPrintPreview();
            GoodsGridControl.Print();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "xls files (*.xls)|*.xls|All files(*.*)|*.*";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveDialog.FileName;
                GoodsGridControl.ExportToXls(fileName);

            }
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void GoodsComboBoxCategory_TextChanged(object sender, EventArgs e)
        {
            presenter.productCategoryList.Add(GoodsComboBoxCategory.Text);
            //GoodsComboBoxCategory.Text
        }

        private void goodsGreedView_DoubleClick(object sender, EventArgs e)
        {
            GridHitInfo hitInfo = goodsGreedView.CalcHitInfo(GoodsGridControl.PointToClient(MousePosition));
            if (hitInfo.InRow || hitInfo.InRowCell)
            //  if (hitInfo.InRowCell)
            {
                GridView gv = (GridView)sender;
                GridHitInfo gridInfo = gv.CalcHitInfo(gv.GridControl.PointToClient(Control.MousePosition));
                goodsID = (int)gv.GetRowCellValue(gridInfo.RowHandle, "Id");

                AddGoods.AddGoods frm = new AddGoods.AddGoods(goodsID);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }


    }
}
