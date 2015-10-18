using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DAO;
using Domain.Entities;


namespace Data.DumbData
{
    public class CustomerDao: BaseDao<Customer>, ICustomerRepository
    {
        public ICollection<Customer> GetCustomersByCity(string city)
        {
            return Storage.CustomerCollection.Where(x => x.Contacts.City == city).ToList(); 
        }
    }
}
