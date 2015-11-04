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
        readonly ProjectContext context;

        public RoleDao(ProjectContext context)
        {
            this.context = context;
        }
        public new IQueryable<Role> GetAll()
        {
            IQueryable<Role> collection = context.Roles.Where(x => x.IsActive);
            return collection;
        }
        public new void Add(Role role)
        {
            context.Set<Role>().Add(role);
            context.SaveChanges();
        }

        public new void Update(Role role)
        {
            context.Entry(role).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public void AddOrUpdate(Role role)
        {
            context.Roles.AddOrUpdate(x => x.Name, new Role[] { role });
            context.SaveChanges();
        }
    }
}
