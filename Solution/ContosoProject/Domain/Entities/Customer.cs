using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Customer: BaseEntity
    {
        public PersonalInfo PersonalInfo { get; set; }
        public ContactInfo Contacts { get; set; }
        public List<Order> Orders { get; set; }
        public List<Comment> Comments { get; set; }
        public Customer(User user, PersonalInfo personalInfo, ContactInfo contacts, Order order,
            string city, string adress, string telephone, string firstName, string middleName, string lastName)
            :base(user)
        {
            PersonalInfo = new PersonalInfo(user, firstName, middleName, lastName);
            Contacts = new ContactInfo(user, city, adress, telephone);
            Orders.Add(new Order());
            Comments = new List<Comment>();
        }
    }
}
