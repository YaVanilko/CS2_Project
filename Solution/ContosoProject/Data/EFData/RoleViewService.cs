using Domain.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EFData
{
    public class RoleViewService
    {
        public IRoleRepository RoleDao { get; set; }
        public IPermissionRepository PermissionDao { get; set; }
        readonly ProjectContext context = new ProjectContext();
        public RoleViewService()
        {
            RoleDao = new RoleDao(context);
            PermissionDao = new PermissionDao(context);
        }
    }
}
