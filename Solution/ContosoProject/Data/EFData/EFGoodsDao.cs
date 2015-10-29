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
   public  class EFGoodsDao:EfBaseDao<Goods>,IGoodsRepository
   {
        public ICollection<Goods> GetGoodsByCategory(string category)
        { 
            return dbContext.Goods.Where(x => x.Category.CategoryName == category).ToList();  
        }

        public ICollection<Goods> GetAll()
        {
           
            return dbContext.Goods.Where(x => x.IsActive)
                                .Include(x => x.Category).ToList();
        }

        public ICollection<Goods> GetAllIsActive()
        {
            return dbContext.Goods.Where(x => x.IsActive)
                                .Include(x => x.Category).ToList();
        }

      
   }
}
