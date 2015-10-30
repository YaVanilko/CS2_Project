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
    class OrderStatusDao : EfBaseDao<OrderStatus>, IOrderStstusRepository
    {
        public new IQueryable<OrderStatus> GetAll()
        {
            IQueryable<OrderStatus> collection =
                dbContext.OrderStatus.Where(x => x.IsActive);
            return collection;
        }

        public new OrderStatus GetById(int id)
        {
            return dbContext.OrderStatus.Where(x => x.Id == id)
                    .FirstOrDefault();
        }

        public new void Update(OrderStatus entity)
        {
            dbContext.OrderStatus.AddOrUpdate(entity);
            dbContext.SaveChanges();
        }
    }
}
