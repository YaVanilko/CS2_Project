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
            presenter = new RolesPresenter(this);
            InitializeComponent();
        }
        private void RolesView_Load(object sender, EventArgs e)
        {
            rolesGridControl.DataSource = presenter.Roles;
            permissionsCheckedListBoxControl.DataSource = presenter.Permissions;
            permissionsCheckedListBoxControl.DisplayMember = "Name";
            permissionsCheckedListBoxControl.ValueMember = "Id";
        }
        private void saveRoleButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void saveAndNewRoleButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void rolesGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }
    }
}
