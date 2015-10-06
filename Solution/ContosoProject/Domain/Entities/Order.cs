using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order : BaseEntity
    {
        private Customer customer;
        private List<GoodsRow> goodsList = new List<GoodsRow>();
        private double totalCost;
        private OrderStatus currentStatus;
        private List<Comment> comments;

        public Order(Customer currentCustomer, List<GoodsRow> good) : this (currentCustomer, good, new Comment())
        {
        }

        public Order(Customer customer, List<GoodsRow> goods, Comment comment)
        {
            this.customer = customer;
            if (goods != null)
            {
                foreach (GoodsRow row in goods)
                {
                    goodsList.Add(row);
                    totalCost += row.Price;
                }
            }

            if (comment.Message.Lenght != 0)
            {
                comments.Add(comment);
            }
        }

        public void EditOrder()
        {
            throw new NotImplementedException();
        }

        public DeactivateOrder ()
        {
            if (IsActive)
                IsActive = false;
        }
    }
}
