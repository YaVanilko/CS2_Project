﻿using Domain.Entities;
using Domain.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DumbData
{
    public class RoleDao : BaseDao<Role>, IRoleRepository
    {
        public void AddOrUpdate(Role role)
        {
            //TODO: Add impltmentation of Add method
        }
    }
}
