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

        public new void Update(Order entity)
        {
            dbContext.Orders.AddOrUpdate(entity);
            dbContext.SaveChanges();
        }

        public new void Add(Order entity)
        {
            dbContext.Orders.Add(entity);
            dbContext.SaveChanges();
        }

        public void Delete(Order entity)
        {
            dbContext.Orders.Remove(entity);
        }

        public IQueryable<Order> FindBy(System.Linq.Expressions.Expression<Func<Order, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
