using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Data.EFData
{
    public class PermissionDao : EfBaseDao<Permission>, IPermissionRepository
    {
        public new IQueryable<Permission> GetAll()
        {
            return dbContext.Permissions.Where(x => x.IsActive).AsQueryable();
        }
    }
}
