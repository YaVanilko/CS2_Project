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
        readonly ProjectContext context;
        public PermissionDao(ProjectContext context)
        {
            this.context = context;
        }
        public new IQueryable<Permission> GetAll()
        {
            return context.Permissions.Where(x => x.IsActive).AsQueryable();
        }
    }
}
