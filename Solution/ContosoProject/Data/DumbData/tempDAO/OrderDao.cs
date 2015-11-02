using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DumbData
{
    public class OrderDao : BaseDao<Order>, IOrderRepository
    {
        public ICollection<Order> GetOrderByStatus(string status)
        {
            return Storage.OrderCollection.Where(x => x.Status.Status == status).ToList();
        }
    }
}
