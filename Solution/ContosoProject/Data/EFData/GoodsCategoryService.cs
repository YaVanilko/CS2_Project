using Domain.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EFData
{
   public class GoodsCategoryService
    {
        public IGoodsRepository GoodsDao { get;private set; }
        public IProductCategoryRepository CategoryDao { get; private set;}
        readonly ProjectContext context = new ProjectContext();

        public GoodsCategoryService()
        {
            GoodsDao = new GoodsDao(context);
            CategoryDao=new ProductCategoryDao(context);
        } 
    }
}
