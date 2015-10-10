using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductCategory: BaseEntity
    {
        public string CategoryName { get; set; }
        public List<Goods> Goods { get; set; }
        public ProductCategory(User user, string categoryName)
            :base(user)
        {
            CategoryName = categoryName;
            Goods = new List<Goods>();
        }
    }
}
