﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DAO;
using Domain.Entities;

namespace Domain.DAO

{
    public interface IUserRepository : IRepository<User>
    {
        bool FindByLoginPassword(out User authUser, string login, string password);
    }
}
