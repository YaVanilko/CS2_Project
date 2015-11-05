using Data.EFData;
using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.EditUserForm
{
    class UserReportPresenter
    {
        readonly UserReportForm view;
        readonly IUserRepository model = new UserDao();
        List<User> users = new List<User>();
        public List<UserReportViewModel> viewModels = new List<UserReportViewModel>(); 

        public UserReportPresenter(UserReportForm view)
        {
            this.view = view;
            users = model.GetAll().ToList();
            foreach (var user in users)
            {
                viewModels.Add(new UserReportViewModel(user));
            }
        }

        public List<UserReportViewModel> ViewModels { get { return viewModels; } }
    }
}
