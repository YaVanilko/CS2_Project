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
        double totalPrise;
        public double TotalPrice
        {
            get
            {
                return totalPrise;
            }
            set
            {
                totalPrise = Price * Count;
            }
        }
        public GoodsRow(User user, Goods goods, int count, double price)
            : base(user)
        {
            Goods = goods;
            Count = count;
            Price = price;
            this.totalPrise = price * count;
        }
    }
}
