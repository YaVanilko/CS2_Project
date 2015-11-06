using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Data.EFData
{
    public class OrderStatusDao : EfBaseDao<OrderStatus>, IOrderStatusRepository
    {
        public OrderStatusDao(ProjectContext context = null)
            : base(context)
        {

        }
        public new IQueryable<OrderStatus> GetAll()
        {
            IQueryable<OrderStatus> collection =
                 dbContext.OrderStatus.Where(x => x.IsActive);
            return collection;
        }
    }
}
