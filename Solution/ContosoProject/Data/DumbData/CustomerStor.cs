using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Data.DumbData
{
    public static partial class Storage
    {
        public static List<Customer> customerCollection = new List<Customer>()
        {
            new Customer()
            {
                PersonalInfo = personalInfoCollection[0],
                Contacts = contactInfoCollection[0],
                Orders = new List<Order>(){orderCollection[0]},
                Comments = commentCollection[0]
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[1],
                Contacts = contactInfoCollection[1],
                Orders = new List<Order>(){orderCollection[1]},
                Comments = commentCollection[1]
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[2],
                Contacts = contactInfoCollection[2],
                Orders = new List<Order>(){orderCollection[2]},
                Comments = commentCollection[2]
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[3],
                Contacts = contactInfoCollection[3],
                Orders = new List<Order>(){orderCollection[3]},
                Comments = commentCollection[3]
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[4],
                Contacts = contactInfoCollection[4],
                Orders = new List<Order>(){orderCollection[4]},
                Comments = commentCollection[4]
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[5],
                Contacts = contactInfoCollection[5],
                Orders = new List<Order>(){orderCollection[5]},
                Comments = commentCollection[5]
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[6],
                Contacts = contactInfoCollection[6],
                Orders = new List<Order>(){orderCollection[6]},
                Comments = commentCollection[6]
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[7],
                Contacts = contactInfoCollection[7],
                Orders = new List<Order>(){orderCollection[7]},
                Comments = commentCollection[7]
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[8],
                Contacts = contactInfoCollection[8],
                Orders = new List<Order>(){orderCollection[8]},
                Comments = commentCollection[8]
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[9],
                Contacts = contactInfoCollection[9],
                Orders = new List<Order>(){orderCollection[9]},
                Comments = commentCollection[9]
            }
        };
    }
}
