using Domain.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EFData
{
    public class UserRoleService
    {
        public IRoleRepository RoleDao { get; set; }
        public IUserRepository UserDao { get; set; }
        readonly ProjectContext context = new ProjectContext();
        public UserRoleService()
        {
            RoleDao = new RoleDao(context);
            UserDao = new UserDao(context);
        }
    }
}
