using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContosoUI.Roles
{
    public partial class RolesView : DevExpress.XtraEditors.XtraForm
    {
        readonly RolesPresenter presenter;
        public RolesView()
        {
            InitializeComponent();
            if (!Program.AuthUser.Role.Permissions.Any(x => x.Type == Domain.PermissionType.NewRole))
            {
                this.addNewRoleButton.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Program.AuthUser.Role.Permissions.Any(x => x.Type == Domain.PermissionType.EditRole))
            {
                this.saveRoleButton.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            presenter = new RolesPresenter(this);
            List<CheckedListBoxItem> items = new List<CheckedListBoxItem>();
            foreach (var perm in presenter.Permissions)
            {
                items.Add(new CheckedListBoxItem(perm, perm.Name, false));
            }
            permissionsCheckedListBoxControl.Items.AddRange(items.ToArray());
        }
        private void RolesView_Load(object sender, EventArgs e)
        {
            rolesGridControl.DataSource = presenter.Roles;
        }
        private void rolesGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView view = sender as GridView;
            object roleObj = view.GetRow(view.FocusedRowHandle);
            Role role = roleObj as Role;

            if (role != null || roleObj != null)
            {
                SetCheckedPermissions(role.Permissions);
            }
        }
        private void SetCheckedPermissions(ICollection<Permission> permissions)
        {
            permissionsCheckedListBoxControl.UnCheckAll();
            foreach (var permission in permissions)
            {
                var permissionIndex = permissionsCheckedListBoxControl.FindString(permission.Name);
                permissionsCheckedListBoxControl.SetItemChecked(permissionIndex, true);
            }

        }

        private void addNewRoleButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            presenter.Roles.Add(new Role());
            rolesGridControl.RefreshDataSource();
        }
        private void saveRoleButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rolesGridView.CloseEditor();
            rolesGridView.UpdateCurrentRow();
            GridView view = rolesGridView;
            object roleObj = view.GetRow(view.FocusedRowHandle);
            Role role = roleObj as Role;
            SavePermissions();
            if (role.Permissions.Count == 0)
            {
                MessageBox.Show("Запрещено создавать роль без назначения разрешений");
            }
            else
            {
                presenter.Save();
            }

        }

        private void rolesGridView_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            SavePermissions();
        }
        void SavePermissions()
        {
            GridView view = rolesGridView;
            object roleObj = view.GetRow(view.FocusedRowHandle);
            Role role = roleObj as Role;

            var permissions = permissionsCheckedListBoxControl.CheckedItems;
            role.Permissions.Clear();
            foreach (var p in permissions)
            {
                var checkedListItem = p as CheckedListBoxItem;
                role.Permissions.Add(checkedListItem.Value as Permission);
            }
        }

        private void rolesGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = rolesGridView;
            object roleObj = view.GetRow(view.FocusedRowHandle);
            Role role = roleObj as Role;
            if (e.Column.Caption != "Статус (активировать/ деактивировать)")
            {
                return;
            }
            else
            {
                if (role.IsActive != true)
                {
                    DialogResult result;
                    result = MessageBox.Show("Вы уверенны, что хотите деактивировать роль пользователя? После деактивации роль будет удалена из списка!", buttons: MessageBoxButtons.OKCancel, caption: "Деактивация роли");
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        presenter.Save();
                    }
                    else
                    {
                        role.IsActive = true;
                        presenter.Save();
                    }
                }
            }
        }
    }
}
