using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI
{
    interface IGoodsView
    {
        void SetGoodsData(List<Goods> goodsList);

        void SetGoodsCategory(List<ProductCategory> categoryList);

        event EventHandler<EventArgs> loadGoodsForm;

        event EventHandler<EventArgs> searchButtonClick;
    }
}
