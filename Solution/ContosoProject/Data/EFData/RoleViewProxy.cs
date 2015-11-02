using Domain.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EFData
{
    public class RoleViewProxy
    {
        public IRoleRepository RoleDao { get; set; }
        public IPermissionRepository PermissionDao { get; set; }
        readonly ProjectContext context = new ProjectContext();
        public RoleViewProxy()
        {
            RoleDao = new RoleDao(context);
            PermissionDao = new PermissionDao(context);
        }
    }
}
