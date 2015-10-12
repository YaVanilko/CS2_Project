using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Data.DumbData
{
    public static partial class Storage
    {
        List<Permission> permissionCollection = AddTenPermission();

        private static List<Permission> AddTenPermission()
        {
            List<Permission> permissionCollection = new List<Permission>()
            for (int i = 0; i < 9; i++)
			{
			    Permission permission = new Permission();
                permissionCollection.Add(permission);
			}
            return permissionCollection;
        }
    }
}
