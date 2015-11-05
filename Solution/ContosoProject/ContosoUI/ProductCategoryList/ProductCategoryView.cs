using DevExpress.XtraGrid.Views.Grid;
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

namespace ContosoUI.ProductCategoryList
{
    public partial class ProductCategoryView : DevExpress.XtraEditors.XtraForm
    {
        readonly ProductCategoryPresenter presenter;
        public ProductCategoryView()
        {
            InitializeComponent();
            presenter = new ProductCategoryPresenter(this);
        }

        private void saveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            presenter.Categories.Add(new ProductCategory());
            productCategoryGridControl.RefreshDataSource();

        }

        private void saveButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            categoriesGridView.CloseEditor();
            categoriesGridView.UpdateCurrentRow();
            presenter.Save();
            productCategoryGridControl.RefreshDataSource();
        }

        private void ProductCategoryView_Load(object sender, EventArgs e)
        {
            productCategoryGridControl.DataSource = presenter.Categories;
        }
        public bool ShowValidationDialog(string caption, string message)
        {
            bool isOk = false;
            DialogResult result = MessageBox.Show(caption, message, buttons: MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                isOk = true;
            }
            return isOk;
        }

    }
}
