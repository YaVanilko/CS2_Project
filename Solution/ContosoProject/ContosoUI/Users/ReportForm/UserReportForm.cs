using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ContosoUI.Users.Edit;

namespace ContosoUI.EditUserForm
{
    public partial class UserReportForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        UserReportPresenter presenter;
        public UserReportForm()
        {
            InitializeComponent();
            presenter = new UserReportPresenter(this);
            if (!Program.AuthUser.Role.Permissions.Any(x => x.Type == Domain.PermissionType.SaveListUsers))
            {
                this.userReportSaveBtn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Program.AuthUser.Role.Permissions.Any(x => x.Type == Domain.PermissionType.PrintReportUsers))
            {
                this.userReportPrintBtn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }

        public override void Refresh()
        {
            UserReportGridControl.DataSource = presenter.ViewModels;
            UserReportGridControl.Refresh();
        }

        private void userReportViewModelBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void UserReportGridView_DoubleClick(object sender, EventArgs e)
        {
            if (Program.AuthUser.Role.Permissions.Any(x=> x.Type == Domain.PermissionType.EditUser))
            {
                var grid = (GridView)sender;
                GridHitInfo info = grid.CalcHitInfo(grid.GridControl.PointToClient(Control.MousePosition));

                var id = grid.GetRowCellValue(info.RowHandle, "Id");
                if (id != null)
                {
                    var form = new UserEditForm((int)id);
                    form.MdiParent = this.MdiParent;
                    form.Show();
                }
            }
        }

        private void UserReportSaveBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string FileName = saveFileDialog1.FileName;
                userReportGridWiew.ExportToXls(FileName);
            }
        }

        private void UserReportPrintBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            userReportGridWiew.PrintDialog();
            userReportGridWiew.Print();
        }
    }
}