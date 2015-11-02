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
    public class EFGoodsDao : EfBaseDao<Goods>, IGoodsRepository
    {
        public ICollection<Goods> GetGoodsByCategory(string category)
        {
            return dbContext.Products.Where(x => x.Category.CategoryName == category).ToList();
        }

        public new ICollection<Goods> GetAll()
        {

            return dbContext.Products.Where(x => x.IsActive)
                                .Include(x => x.Category)
                                .Include(x=>x.Coments).ToList();
        }

        public ICollection<Goods> GetAllIsActive()
        {
            return dbContext.Products.Where(x => x.IsActive)
                                .Include(x => x.Category)
                                .Include(x => x.Coments).ToList();
        }
    }
}

