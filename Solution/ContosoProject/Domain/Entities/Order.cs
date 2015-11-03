using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order : BaseEntity
    {
        [Required]
        public Customer Customer { get; set; }

        public List<GoodsRow> GoodsList { get; set; }

        public double TotalCost { get; set; }

        public OrderStatus Status { get; set; }

        public List<Comment> Comments { get; set; }

        public Order()
        {
            Customer = new Customer();
            GoodsList = new List<GoodsRow>();
            Status = new OrderStatus();
            Comments = new List<Comment>();
        }
    }
}
