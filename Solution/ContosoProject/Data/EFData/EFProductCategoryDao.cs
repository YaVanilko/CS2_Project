using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using Domain.DAO;

namespace Data.EFData
{
    public class EFProductCategoryDao : EfBaseDao<ProductCategory>, IProductCategoryRepository
    {
     
        public ICollection<ProductCategory> GetAll()
        {
            return dbContext.Categories.Where(x => x.IsActive== true).ToList();
        }

        public void AddCategory(string categoryNew)
        {
            ProductCategory productCategory = new ProductCategory();
            productCategory.CategoryName = categoryNew;
            productCategory.IsActive = true;
            dbContext.Set<ProductCategory>().Add(productCategory);
            dbContext.SaveChanges();
        }
       
    }
}
