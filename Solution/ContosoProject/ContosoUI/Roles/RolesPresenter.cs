using ContosoUI.Presenter;
using Data.EFData;
using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.Roles
{
    public class RolesPresenter : BasePresenter
    {
        readonly RolesView view;
        readonly RoleViewService modelProxy = new RoleViewService();
        Role role;
        public RolesPresenter(RolesView view)
        {
            this.view = view;
            Roles = modelProxy.RoleDao.GetAll().ToList();
            Permissions = modelProxy.PermissionDao.GetAll().ToList();
            foreach (var role in Roles)
            {
                List<Permission> listPermissions = new List<Permission>();
                foreach (var permission in role.Permissions)
                {   
                    listPermissions.Add(Permissions.First(x => x.Id == permission.Id));
                }
                role.Permissions = listPermissions;
            }
        }
        List<Role> roles = new List<Role>();
        public List<Role> Roles
        {
            get { return roles; }
            set
            {
                if (value != roles)
                {
                    roles = value;
                    NotifyPropertyChanged("Roles");
                }
            }
        }

        List<Permission> permissions = new List<Permission>();
        public List<Permission> Permissions
        {
            get { return permissions; }
            set
            {
                if (value != permissions)
                {
                    permissions = value;
                    NotifyPropertyChanged("Permissions");
                }
            }
        }

        public void Save()
        {
            foreach (var role in roles)
            {
                modelProxy.RoleDao.AddOrUpdate(role);
            }
        }
    }
}
