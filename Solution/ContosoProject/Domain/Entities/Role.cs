using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{

    public class Role : BaseEntity
    {
        public List<Permission> Permissions { get; set; }
        public string Name { get; set; }

        public Role() 
        { 
            Permissions = new List<Permission>(); 
        }
    }
}
