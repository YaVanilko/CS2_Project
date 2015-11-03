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
        }

        private void ProductCategoryView_Load(object sender, EventArgs e)
        {
            productCategoryGridControl.DataSource = presenter.Categories;
        }

        private void categoriesGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;
            object categoryObj = view.GetRow(view.FocusedRowHandle);
            ProductCategory category = categoryObj as ProductCategory;
            if (e.Column.Caption != "Статус  (активировать / деактивировать)")
            {
                return;
            }
            else
            {
                if (category.IsActive != true)
                {
                    MessageBox.Show("Вы уверенны, что хотите деактивировать категорию товаров? После деактивации категория будет удалена из списка!");
                }    
            }
        }

    }
}
