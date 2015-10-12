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
			    orderCollection.Add(new Order(customerCollection(i), new List<GoodsRow>(), new Comment("message"+i, CommentType.Order)));
                orderCollection[i].goodsList.Add(goodsRowCollection[i]);
			}
            return orderCollection;
        }

    }
}
