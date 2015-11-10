using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order : BaseEntity
    {
        public Customer Customer { get; set; }

        public virtual ICollection<GoodsRow> GoodsList { get; set; }

        [NotMapped]
        public double TotalCost
        {
            get
            {
                double result = 0;

                foreach (GoodsRow row in GoodsList)
                {
                    if (row.IsActive)
                    {
                        result += row.TotalPrice;
                    }
                }

                return result;
            }
        }

        public OrderStatus Status { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public Order()
        {
            Customer = new Customer();
            GoodsList = new List<GoodsRow>();
            Status = new OrderStatus();
            Comments = new List<Comment>();
        }
    }
}
