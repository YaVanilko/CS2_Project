using Data.EFData;
using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.ProductCategoryList
{
    public class ProductCategoryPresenter : INotifyPropertyChanged
    {
        readonly ProductCategoryView view;
        readonly IProductCategoryRepository model = new ProductCategoryDao();
        public ProductCategoryPresenter(ProductCategoryView view)
        {
            this.view = view;
            categories = model.GetAll().ToList();
        }
        List<ProductCategory> categories = new List<ProductCategory>();
        public List<ProductCategory> Categories
        {
            get { return categories; }
            set
            {
                if (value != categories)
                {
                    categories = value;
                    NotifyPropertyChanged("Categories");
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public void Save()
        {
            foreach (var category in categories)
            {
                model.AddOrUpdate(category);
            }
        }
    }
}
