using ContosoUI.Presenter;
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
    public class ProductCategoryPresenter : BasePresenter
    {
        readonly ProductCategoryView view;
        readonly IProductCategoryRepository model = new ProductCategoryDao();
        IUserNotify notifyManager = Program.MainWiewInstance;
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

        public void Save()
        {
            if (Validation())
            {
                foreach (var category in categories)
                {
                    model.AddOrUpdate(category);
                }
                notifyManager.ShowInfo("Изменения сохранены", "Информация");
            }
            Categories.RemoveAll(x => !x.IsActive);
            NotifyPropertyChanged("Save");
        }
        bool Validation()
        {
            bool isValid = true;
            if (categories.Any(x => x.IsActive == false))
            {
                bool result  = notifyManager.ShowYesNo("Вы уверенны, что хотите деактивировать категорию товаров? После деактивации категория будет удалена из списка!", "Деактивация категории");
                if (!result)
                {
                    isValid = false;
                }
            }
            if (categories.Any(x => string.IsNullOrWhiteSpace (x.CategoryName)))
            {

                notifyManager.ShowWarning("Название категории не заполнено или поле содержит менее 2 или более 50 знаков. Проверьте правильность заполнения поля", "Предупреждение");
                isValid = false;
            }
            return isValid;
        }
    }
}
