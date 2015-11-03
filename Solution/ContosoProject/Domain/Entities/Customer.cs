using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Customer : BaseEntity
    {
        [Required]
        public PersonalInfo PersonalInfo { get; set; }

        [Required]
        public ContactInfo Contacts { get; set; }

        public List<Order> Orders { get; set; }

        public List<Comment> Comments { get; set; }

        public Customer()
        {
            Orders = new List<Order>();
            Comments = new List<Comment>();
            PersonalInfo = new PersonalInfo();
            Contacts = new ContactInfo();
        }
    }
}
