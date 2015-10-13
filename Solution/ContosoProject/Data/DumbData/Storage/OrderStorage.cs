using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Data.DumbData
{
    public static partial class Storage
    {
        public static List<Order> orderCollection = AddTenOrders();

        private static List<Order> AddTenOrders()
        {
 	        List<Order> orderCollection = new List<Order>();
            
            for (int i = 0; i < 9; i++)
			{
                Order order = new Order();
                order.Customer = customerCollection[i];
                order.comments.Add(new Comment() { Message = "commentfromOrder" + i, Type = CommentType.Order});
                order.Operator = userCollection[i];
                order.goodsList.Add(goodsRowCollection[i]);

                orderCollection.Add(order);
			}
            return orderCollection;
        }

    }
}
