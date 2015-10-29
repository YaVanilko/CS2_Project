using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EFData
{
    public class RoleDao : EfBaseDao<Role>, IRoleRepository
    {
        public new IQueryable<Role> GetAll()
        {
            IQueryable<Role> collection = dbContext.Roles.Where(x => x.IsActive);
            return collection;
        }
    }
}
