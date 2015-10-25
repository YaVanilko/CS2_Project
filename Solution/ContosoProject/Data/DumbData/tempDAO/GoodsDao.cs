using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.DAO;

namespace Data.DumbData
{
    public class GoodsDao: BaseDao<Goods>, IGoodsRepository
    {
        public ICollection<Goods> GetGoodsByCategory(string category)
        {
            return Storage.goodsCollection.Where(x => x.Category.CategoryName == category).ToList();
        }
    }
}
