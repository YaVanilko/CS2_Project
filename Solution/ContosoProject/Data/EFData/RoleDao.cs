using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Data.EFData
{
    public class RoleDao : EfBaseDao<Role>, IRoleRepository
    {
        public RoleDao(ProjectContext context = null) : base(context)
        {

        }

        public void AddOrUpdate(Role role)
        {
            dbContext.Roles.AddOrUpdate(role);
            dbContext.SaveChanges();
        }
    }
}
