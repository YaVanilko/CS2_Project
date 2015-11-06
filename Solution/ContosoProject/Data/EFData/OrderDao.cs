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
    public class OrderDao : EfBaseDao<Order>, IOrderRepository
    {
        public OrderDao(ProjectContext context = null)
            : base(context)
        {

        }
        public new IQueryable<Order> GetAll()
        {
            IQueryable<Order> collection =
                dbContext.Orders.Where(x => x.IsActive)
                .Include(x=>x.Customer)
                .Include(x => x.GoodsList)
                .Include(x => x.Status)
                .Include(x => x.Comments);
            return collection;
        }

        public new Order GetById(int id)
        {
            return dbContext.Orders.Where(x => x.Id == id)
                .Include(x => x.Customer)
                .Include(x => x.GoodsList)
                .Include(x => x.Status)
                .Include(x => x.Comments).FirstOrDefault();
        }

        public ICollection<Order> GetOrderByStatus(OrderStatus status)
        {
            return dbContext.Orders.Where(x => x.Status == status)
                .Include(x => x.Comments)
                .Include(x => x.Customer)
                .Include(x => x.GoodsList)
                .Include(x => x.Status)
                .Include(x => x.TotalCost)
                .ToList();
        }
    }
}
