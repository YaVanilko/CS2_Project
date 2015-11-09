using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Data.EFData
{
    public class GoodsDao : IGoodsRepository
    {
        public GoodsDao(ProjectContext context = null)
            : base(context)
        {

        }

        public ICollection<Goods> GetGoodsByCategory(string category)
        {
            return dbContext.Products.Where(x => x.Category.CategoryName == category).
                                      Include(x => x.Category).ToList();
        }

        public new ICollection<Goods> GetAll()
        {
            return dbContext.Products.Include(x => x.Coments).
                                      Include(x=>x.Category).ToList();
        }

        public ICollection<Goods> GetAllIsActive()
        {
            return dbContext.Products.Where(x => x.IsActive == true).
                                      Include(x => x.Coments). 
                                      Include(x=>x.Category).ToList();
        }

        public void Delete(Goods entity)
        {
            throw new NotImplementedException();
        }

        public new Goods GetById(int Id)
        {
            return dbContext.Products.Where(x => x.Id == Id). 
                                      Include(x=>x.Category).FirstOrDefault();
        }

        IQueryable<Goods> IRepository<Goods>.GetAll()
        {
            return dbContext.Products;
        }

        public IQueryable<Goods> FindBy(System.Linq.Expressions.Expression<Func<Goods, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}

