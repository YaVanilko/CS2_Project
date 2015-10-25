using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Data.EFData
{
    public class CustomerDao : EfBaseDao<Customer>, ICustomerRepository
    {
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
        public Customer GetById(int id)
        {
            return dbContext.Customers.Where(x => x.Id == id)
                    .Include(x => x.Contacts)
                    .Include(x => x.PersonalInfo)
                    .Include(x => x.Comments).FirstOrDefault();
        }
    }
}
