using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DAO;
using Domain.Entities;

namespace Domain.DAO
{
    public interface IRoleRepository : IRepository<Role>
    {
        void AddOrUpdate(Role role);
    }
}
