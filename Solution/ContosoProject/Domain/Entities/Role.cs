using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{

    public class Role : BaseEntity
    {
        private List<Permission> permissions = new List<Permission>();
        public List<Permission> Permissions { get { return permissions; } }
        
        public void AddRole(Role role)
        {
            throw new NotImplementedException();
        }

        public void EditRole(int id)
        {
            throw new NotImplementedException();
        }

        public void DeactivateRole(int id)
        {
            throw new NotImplementedException();
        }
    }
}
