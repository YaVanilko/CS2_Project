﻿using System;
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

namespace ContosoUI
{
    public partial class MainView : DevExpress.XtraEditors.XtraForm
    {
        public MainView()
        {
            InitializeComponent();
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
            var form = new Test.OrderListView();
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

        private void RolesButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new Roles.RolesView();
            form.MdiParent = this;
            form.Show();
        }
    }
}