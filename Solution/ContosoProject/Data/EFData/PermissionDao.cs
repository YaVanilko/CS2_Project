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
        public new IQueryable<Permission> GetAll()
        {
            IQueryable<Permission> collection =
                dbContext.Permissions.Where(x => x.IsActive)
                .Include(x=>x.Roles);               
            return collection;
        }

        public new Permission GetById(int id)
        {
            return dbContext.Permissions.Where(x => x.Id == id)
                     .Include(x=>x.Roles).FirstOrDefault();
        }

        public new void Update(Permission entity)
        {
            dbContext.Permissions.AddOrUpdate(entity);
            dbContext.SaveChanges();
        }
    }
}
