using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Permission : BaseEntity
    {
        List<Role> roles = new List<Role>();
        List<Role> Roles { get { return roles; } }
    
        public void AddPermission(Permission permission)
        {
     	    throw new NotImplementedException();
        }

        public void EditPermission(int id)
        {
     	    throw new NotImplementedException();
        }
    
        public void DeactivatePermission(int id)
        {
     	    throw new NotImplementedException();
        }
    }
}
