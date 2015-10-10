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
        public Goods(User user, string name, string sku, double price, int count,
            ProductCategory category)
            :base(user)
        {
            Name = name;
            SKU = sku;
            Price = price;
            Count = count;
            Category = category;
            Coments = new List<Comment>();
        }
    }
}
