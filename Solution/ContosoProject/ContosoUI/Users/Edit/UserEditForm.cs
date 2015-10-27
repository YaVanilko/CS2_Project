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

namespace ContosoUI.Users.Edit
{
    public partial class UserEditForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        UserEditPresenter presenter;
        public UserEditForm()
        {
            InitializeComponent();
            presenter = new UserEditPresenter();
        }
        public UserEditForm(int id)
        {
            InitializeComponent();
            presenter = new UserEditPresenter(id);
        }
    }
}