using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order : BaseEntity
    {
        public Customer Customer { get; set; }
        public List<GoodsRow> goodsList { get; set; }
        public double TotalCost { get; set; }
        public OrderStatus Status { get; set; }
        public List<Comment> comments { get; set; }

        public Order(Customer customer, List<GoodsRow> goods, Comment comment)
        {
            Customer = customer;
            goodsList = new List<GoodsRow>();
            comments = new List<Comment>();

            foreach (GoodsRow row in goods)
            {
                 goodsList.Add(row);
                 TotalCost += row.Price;
            }

            comments.Add(comment);
        }
    }
}
