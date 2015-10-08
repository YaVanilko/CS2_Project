using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ContactInfo: BaseEntity
    {
        public string City { get; set; }
        public string Adress { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public ContactInfo(User user, string city, string adress, string telephone)
            :base (user)
        {
            City = city;
            Adress = adress;
            Telephone = telephone;
        }
        public ContactInfo(User user, string city, string adress, string telephone, string email)
            :this(user, city, adress, telephone)
        {
            Email = email;
        }

    }
}
