using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DAO
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        ICollection<Customer> GetCustomersByCity(string city);
    }
}
