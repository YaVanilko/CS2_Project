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
        public static List<Role> roleCollection = AddTenRoles();

        private static List<Role> AddTenRoles()
        {
            List<Role> roleCollection = new List<Role>();
            for (int i = 0; i < 9; i++)
            {
                Role role = new Role();
                roleCollection.Add(role);
            }
            return roleCollection;
        }
    }
}
