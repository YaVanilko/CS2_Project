﻿using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DumbData
{
    public class UserDao : BaseDao<User>, IUserRepository
    {
        public bool FindByLoginPassword(out User authUser, string login, string password)
        {
            bool isFind = false;
            authUser = Storage.UserCollection.Find(x => x.Login == login && x.Password == password);
            if (authUser!=null)
            {
                isFind = true;
            }
            return isFind;
        }
    }
}
