using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ContosoUI.Customers.Search;
using ContosoUI.Customers.Add;
using ContosoUI.Users.Edit;
using ContosoUI.Order;
using ContosoUI.ProductCategoryList;

namespace ContosoUI
{
    public partial class MainView : DevExpress.XtraEditors.XtraForm
    {
        public MainView()
        {
            InitializeComponent();
            if (!Program.AuthUser.Role.Permissions.Any(x => x.Type == Domain.PermissionType.NewUser))
            {
                this.addNewUserBtn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Program.AuthUser.Role.Permissions.Any(x => x.Type == Domain.PermissionType.ListUser))
            {
                this.usersMenuBtn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Program.AuthUser.Role.Permissions.Any(x => x.Type == Domain.PermissionType.NewClient))
            {
                this.addNewCustomerBtn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Program.AuthUser.Role.Permissions.Any(x => x.Type == Domain.PermissionType.ListClient))
            {
                this.customersMenuBtn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Program.AuthUser.Role.Permissions.Any(x => x.Type == Domain.PermissionType.ListRoles))
            {
                this.RolesButton.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Program.AuthUser.Role.Permissions.Any(x => x.Type == Domain.PermissionType.ListOrder))
            {
                this.ordersMenuBtn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Program.AuthUser.Role.Permissions.Any(x => x.Type == Domain.PermissionType.NewOrder))
            {
                this.addNewOrderBtn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Program.AuthUser.Role.Permissions.Any(x => x.Type == Domain.PermissionType.ListGoods))
            {
                this.goodsMenuBtn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Program.AuthUser.Role.Permissions.Any(x => x.Type == Domain.PermissionType.NewGoods))
            {
                this.addGoodsBarButton.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Program.AuthUser.Role.Permissions.Any(x => x.Type == Domain.PermissionType.EditProductCategory))
            {
                this.productCategoryButton.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void customersMenuBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new CustomersListView();
            form.MdiParent = this;
            form.Show();
        }

        private void ordersMenuBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new Order.Search.SearchView();
            form.MdiParent = this;
            form.Show();
        }

        private void usersMenuBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new EditUserForm.UserReportForm();
            form.MdiParent = this;
            form.Show();
        }

        private void addNewCustomerBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new CustomerDetailsViev();
            form.MdiParent = this;
            form.Show();
        }

        private void addNewUserBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new UserEditForm();
            form.MdiParent = this;
            form.Show();
        }

        private void RolesButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new Roles.RolesView();
            form.MdiParent = this;
            form.Show();
        }

        private void logoutBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Restart();
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new UserEditForm(Program.AuthUser.Id);
            form.MdiParent = this;
            form.AsPasswordChange();
            form.Show();
        }

        private void addNewOrderBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new AddEditOrderView();
            form.MdiParent = this;
            form.Show();
        }

        private void goodsMenuBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new GoodsAll.GoodsF.GoodsForm();
            form.MdiParent = this;
            form.Show();
        }

        private void addGoodsBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new GoodsAll.AddGoods.AddGoods();
            form.MdiParent = this;
            form.Show();
        }

        private void productCategoryButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new ProductCategoryView();
            form.MdiParent = this;
            form.Show();
        }
    }
}