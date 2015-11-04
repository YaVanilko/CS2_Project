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
using System.Windows.Forms;

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
            if (roles.Any(x => x.IsActive == false))
            {
                DialogResult result;
                result = MessageBox.Show("Вы уверенны, что хотите деактивировать роль пользователя? После деактивации роль будет удалена из списка!", buttons: MessageBoxButtons.OKCancel, caption: "Деактивация роли");
                if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            if (roles.Any(x => x.Name == null))
            {
                   MessageBox.Show("Запрещено создавать роль без названия", caption: "Предупреждение" );
                   return;
            }
            foreach (var role in roles)
            {
                if (role.Permissions.Count == 0)
                {
                    string roleName = role.Name;
                    MessageBox.Show("Роль " + roleName + " не содержит разрешений. Запрещено создавать роль без назначения разрешений", caption: "Предупреждение" );
                    return;
                }
                modelProxy.RoleDao.AddOrUpdate(role);
            }
        }   
    }
}
