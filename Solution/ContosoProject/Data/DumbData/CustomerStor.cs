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
        List<Customer> customerCollection = new List<Customer>()
        {
            new Customer()
            {
                PersonalInfo = personalInfoCollection[0],
                Contacts = contactInfoCollection[0],
                Orders = orderCollection[0],
                Comments = commentCollection[0]
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[1],
                Contacts = contactInfoCollection[1],
                Orders = orderCollection[1],
                Comments = commentCollection[1]
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[2],
                Contacts = contactInfoCollection[2],
                Orders = orderCollection[2],
                Comments = commentCollection[2]
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[3],
                Contacts = contactInfoCollection[3],
                Orders = orderCollection[3],
                Comments = commentCollection[3]
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[4],
                Contacts = contactInfoCollection[4],
                Orders = orderCollection[4],
                Comments = commentCollection[4]
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[5],
                Contacts = contactInfoCollection[5],
                Orders = orderCollection[5],
                Comments = commentCollection[5]
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[6],
                Contacts = contactInfoCollection[6],
                Orders = orderCollection[6],
                Comments = commentCollection[6]
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[7],
                Contacts = contactInfoCollection[7],
                Orders = orderCollection[7],
                Comments = commentCollection[7]
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[8],
                Contacts = contactInfoCollection[8],
                Orders = orderCollection[8],
                Comments = commentCollection[8]
            },
            new Customer()
            {
                PersonalInfo = personalInfoCollection[9],
                Contacts = contactInfoCollection[9],
                Orders = orderCollection[9],
                Comments = commentCollection[9]
            }
        };
    }
}
