using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

namespace Data.EFData
{
    public class RoleDao : EfBaseDao<Role>, IRoleRepository
    {
        public new IQueryable<Role> GetAll()
        {
            IQueryable<Role> collection = dbContext.Roles.Where(x => x.IsActive);
            return collection;
        }
        public new void Add(Role role)
        {
            dbContext.Set<Role>().Add(role);
            dbContext.SaveChanges();
        }

        public new void Update(Role role)
        {
            dbContext.Entry(role).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void AddOrUpdate(Role role)
        {
            dbContext.Roles.AddOrUpdate(x => x.Name, new Role[] { role });
        }
    }
}
