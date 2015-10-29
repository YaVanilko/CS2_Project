using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class GoodsRow : BaseEntity
    {
        public Goods Goods { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public double TotalPrice
        {
            get
            {
                return Price * Count;
            }
        }

        public GoodsRow() { Goods = new Goods(); }
    }
}
