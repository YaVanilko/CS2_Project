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
        public new IQueryable<Role> GetAll()
        {
            IQueryable<Role> collection = dbContext.Roles.Where(x => x.IsActive)
                .Include(x=> x.Permissions);
            return collection;
        }

        public new Role GetById(int id)
        {
            return dbContext.Roles.Where(x => x.Id == id)
                .Include(x => x.Permissions).FirstOrDefault();
        }

        public new void Update(Permission entity)
        {
            dbContext.Permissions.AddOrUpdate(entity);
            dbContext.SaveChanges();
        
        }
    }
}
