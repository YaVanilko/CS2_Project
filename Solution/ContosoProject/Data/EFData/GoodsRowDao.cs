using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using Domain.Entities;
using Domain.DAO;


namespace Data.EFData
{
    class GoodsRowDao : EfBaseDao<GoodsRow>, IGoodsRowRepository
    {
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
    }
}
