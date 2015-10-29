﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{

    public class Role : BaseEntity
    {
        public virtual ICollection<Permission> Permissions { get; set; }
        public string Name { get; set; }

        public Role() 
        { 
            Permissions = new List<Permission>(); 
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
