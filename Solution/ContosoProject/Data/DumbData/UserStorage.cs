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
                User user = new User();
                user.Login = "user" + i;
                user.Password = "user" + i;
                user.UserInfo = infoCollection[i];
                user.UserRole = roleCollection[i];
                user.Operator = user;

                userCollection.Add(user);
            }
            return userCollection;
        }
    }
}
