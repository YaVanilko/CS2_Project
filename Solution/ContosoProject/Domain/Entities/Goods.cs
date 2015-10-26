using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Goods: BaseEntity
    {
        public string Name { get; set; }
        public string SKU { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public ProductCategory Category { get; set; }
        public List<Comment> Coments { get; set; }
        public Goods()
        {
            Coments = new List<Comment>();
            Category = new ProductCategory();
        }

    }
}
