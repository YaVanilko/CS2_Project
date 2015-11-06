using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Migrations;
namespace Data.EFData
{
    public class ProductCategoryDao : EfBaseDao<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryDao(ProjectContext context = null)
            : base(context)
        {

        }

        public new IQueryable<ProductCategory> GetAll()
        {
            IQueryable<ProductCategory> collection =
                dbContext.Categories.Where(x => x.IsActive)
                .Include(x =>x.Goods);
            return collection;
        }
        public ProductCategory GetByName(string  name)
        {
            return dbContext.Categories.Where(x => x.CategoryName == name)
                .Include(x => x.Goods).FirstOrDefault();
        }

        public void AddOrUpdate(ProductCategory entity)
        {
            dbContext.Categories.AddOrUpdate(entity);
            dbContext.SaveChanges();
        }
    }
}
