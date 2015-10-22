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

namespace ContosoUI.EditUserForm
{
    public partial class UserReportForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        UserReportPresenter presenter;
        public UserReportForm()
        {
            InitializeComponent();
            presenter = new UserReportPresenter(this);
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

   

    }
}