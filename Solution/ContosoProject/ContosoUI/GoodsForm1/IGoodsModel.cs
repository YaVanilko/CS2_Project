using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ContosoUI
{
    interface IGoodsModel
    {
        List<ProductCategory> GetListCategory();
        List<Goods> GetListGoods(string category);
        List<Goods> GetListGoods();
    }
}
