﻿using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EFData
{
    public class UserDao : EfBaseDao<User>, IUserRepository
    {
    }
}
