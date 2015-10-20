using Data.DumbData;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI
{
    class GoodsModel:IGoodsModel
    {

        public List<Domain.Entities.ProductCategory> GetListCategory()
        {
            return Storage.categoryCollection;
        }


        public List<Goods> GetListGoods(string category)
        {
            List<Goods> newListGoods = new List<Goods>();
            foreach (Goods g in Storage.goodsCollection)
            {
                if (g.Category.CategoryName == category)
                {
                    newListGoods.Add(g);
                }
            }

            return newListGoods;
        }

        public List<Goods> GetListGoods()
        {
           return Storage.goodsCollection;
        }

       
    }
}
