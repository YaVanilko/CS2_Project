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
    public class CustomerDao : EfBaseDao<Customer>, ICustomerRepository
    {
        public CustomerDao()
        {

        }
        public ICollection<Customer> GetCustomersByCity(string city)
        {
            return dbContext.Customers.Where(x => x.Contacts.City == city)
                    .Include(x => x.Contacts)
                    .Include(x => x.PersonalInfo)
                    .Include(x => x.Comments)
                    .ToList();
        }

        public new IQueryable<Customer> GetAll()
        {
            IQueryable<Customer> collection =
                dbContext.Customers.Where(x => x.IsActive)
                    .Include(x => x.Contacts)
                    .Include(x => x.PersonalInfo)
                    .Include(x => x.Comments);
            return collection;
        }

        public new Customer GetById(int id)
        {
            return dbContext.Customers.Where(x => x.Id == id)
                    .Include(x => x.Contacts)
                    .Include(x => x.PersonalInfo)
                    .Include(x => x.Comments).FirstOrDefault();
        }

        public new void Update(Customer entity)
        {
            dbContext.Customers.AddOrUpdate(entity);
            dbContext.SaveChanges();
        }

        public CustomerDao(ProjectContext context)
        {

        }
    }
}
