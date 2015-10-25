using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EFData
{
    public class CustomerDao : EfBaseDao<Customer>, ICustomerRepository
    {
        public ICollection<Customer> GetCustomersByCity(string city)
        {
            return dbContext.Customers.Where(x => x.Contacts.City == city).ToList();
        }
        //public IQueryable<Customer> GetAll()
        //{
        //    IQueryable<Customer> collection = dbContext.Customers.Include(x => x)
        //}
    }
}
