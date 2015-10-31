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
    public class RolesPresenter : INotifyPropertyChanged
    {
        readonly RolesView view;
        readonly IRoleRepository model = new RoleDao();
        readonly IPermissionRepository modelPermission = new PermissionDao();
        Role role;
        public RolesPresenter(RolesView view)
        {
            this.view = view;
            Roles = model.GetAll().ToList();
            Permissions = modelPermission.GetAll().ToList();
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
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        public void Save()
        {
            foreach (var role in roles)
            {
                model.AddOrUpdate(role);
            }
        }
    }
}
