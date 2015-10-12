using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Data.DumbData
{
    public static partial class Storage
    {

        public static List<GoodsRow> goodsRowCollection = AddTenRows();

        private static List<GoodsRow> AddTenRows()
        {
            List<GoodsRow> goodsRowCollection = new List<GoodsRow>();
            for (int i = 0; i < 9; i++)
            {
                GoodsRow row = new GoodsRow();
                row.Count = i;
                row.Goods = goodsCollection[i];
                row.Operator = userCollection[i];
                row.Price = i * 1.1;
            }
            return goodsRowCollection;
        }

    }  
}
