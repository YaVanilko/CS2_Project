﻿using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DumbData
{
    class UserDao : BaseDao<User>, IUserRepository
    {
    }
}
