using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using Domain.Entities;
using Domain.DAO;


namespace Data.EFData
{
    public class GoodsRowDao : IGoodsRowRepository
    {
        ProjectContext dbContext;
        public GoodsRowDao(ProjectContext context = null)
        {
            dbContext = context ?? new ProjectContext();
        }

        public new IQueryable<GoodsRow> GetAll()
        {
            IQueryable<GoodsRow> collection =
                 dbContext.GoodsRows.Where(x => x.IsActive)
                .Include(x=>x.Goods);
            return collection;
        }

        public new GoodsRow GetById(int id)
        {
            return dbContext.GoodsRows.Where(x => x.Id == id)
                   .Include(x=>x.Goods).FirstOrDefault();
        }

        public new void Update(GoodsRow entity)
        {
            dbContext.GoodsRows.AddOrUpdate(entity);
            dbContext.SaveChanges();
        }

        public void Add(GoodsRow entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(GoodsRow entity)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<GoodsRow> FindBy(System.Linq.Expressions.Expression<System.Func<GoodsRow, bool>> predicate)
        {
            throw new System.NotImplementedException();
        }
    }
}
