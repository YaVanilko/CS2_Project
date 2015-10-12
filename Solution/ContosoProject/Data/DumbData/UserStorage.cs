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
        public static List<User> userCollection=AddTenUsers();

        private static List<User> AddTenUsers()
        {
            List<User> userCollection = new List<User>();

            for (int i = 0; i < 9; i++)
            {
                User user = new User(new PersonalInfo(null, "firstName" + i, "middleName" + i, "lastName" + i), "user" + i, "user" + i, new Role());
                user.Operator = user;
            }
            return userCollection;
        }
    }
}
