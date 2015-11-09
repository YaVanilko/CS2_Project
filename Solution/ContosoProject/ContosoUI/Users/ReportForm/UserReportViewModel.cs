using Domain.Entities;
using Domain.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DumbData;

namespace ContosoUI.EditUserForm
{
    class UserReportViewModel
    {
        User user;

        public UserReportViewModel(User user)
        {
            this.user = user;
        }

        public string Name
        {
            get { return string.Format("{0} {1} {2}", user.PersonalInfo.LastName, user.PersonalInfo.FirstName, user.PersonalInfo.MiddleName); }
        }
        public string Login
        {
            get { return user.Login; }
        }
        public string Role
        {
            get { return user.Role.Name; }
        }
        public string IsActive
        {
            get { return string.Format(user.IsActive ? "Да" : "Нет");}
        }
        public int Id
        {
            get { return user.Id; }
        }
        public DateTime EditTime
        {
            get { return user.EditTime; }
        }
    }
}
