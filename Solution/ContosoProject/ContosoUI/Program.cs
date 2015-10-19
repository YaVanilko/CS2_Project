﻿using ContosoUI.Customers.Search;
using ContosoUI.Customers.Add;
using ContosoUI.Customers.Report;
using Data.DumbData;
using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContosoUI.Customers.Report;
using ContosoUI.Test;

namespace ContosoUI
{
    static class Program
    {
        public static User AuthUser { get; private set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GetAuthUser();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CustomersListView());
        }

        private static void GetAuthUser()
        {
            IUserRepository repo = new UserDao();
            AuthUser = repo.GetById(0);
        }
    }
}
