using ContosoUI.Customers.Search;
using ContosoUI.Customers.Add;
using Data.DumbData;
using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContosoUI.Authentication;

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
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GetAuthUser();
            Application.Run(new MainView());
        }

        private static void GetAuthUser()
        {
            var auth = new AuthenticationForm();
            auth.ShowDialog();
            if (auth.DialogResult==DialogResult.OK)
            {
                AuthUser = auth.presenter.user;
            }
            else
            {
                System.Environment.Exit(0);
            }
            
        }
    }
}
