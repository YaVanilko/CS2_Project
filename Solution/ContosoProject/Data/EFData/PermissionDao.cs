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
    public class PermissionDao : EfBaseDao<Permission>, IPermissionRepository
    {
        public PermissionDao(ProjectContext context = null)
            : base(context)
        {

        }
        public new IQueryable<Permission> GetAll()
        {
            return dbContext.Permissions.Where(x => x.IsActive).AsQueryable();
        }

        public new Permission GetById(int id)
        {
            return dbContext.Permissions.Where(x => x.Id == id)
                     .Include(x=>x.Roles).FirstOrDefault();
        }
    }
}
