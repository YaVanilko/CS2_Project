using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DAO;
using Domain.Entities;

namespace Data.DumbData
{
    public class ProductCategoryDao : BaseDao<ProductCategory>, IProductCategoryRepository
    {
    }
}
