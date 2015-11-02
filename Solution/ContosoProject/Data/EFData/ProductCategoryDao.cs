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
        public new IQueryable<ProductCategory> GetAll()
        {
            IQueryable<ProductCategory> collection =
                dbContext.Categories.Where(x => x.IsActive)
                .Include(x =>x.Goods);
            return collection;
        }

        public new ProductCategory GetById(int id)
        {
            return dbContext.Categories.Where(x => x.Id == id)
                .Include(x => x.Goods).FirstOrDefault();
        }

        public new void Update(ProductCategory entity)
        {
            dbContext.Categories.AddOrUpdate(entity);
            dbContext.SaveChanges();
        }
        public void AddOrUpdate(ProductCategory entity)
        {
            dbContext.Categories.AddOrUpdate(x => x.CategoryName, new ProductCategory[] { entity });
            dbContext.SaveChanges();
        }
    }
}
