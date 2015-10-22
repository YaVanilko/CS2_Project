using Domain.Entities;
using Data.DumbData.tempDAO;
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
            get { return String.Format("{0} {1}", user.PersonalInfo.LastName, user.PersonalInfo.FirstName); }
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
            get
            {
                if (user.IsActive)
                {
                    return "Да";
                }
                else
                {
                    return "Нет";
                }
            }
        }
        //public string Operator
        //{
        //    get { return user.Operator.Login; }
        //}
        public int ID
        {
            get { return user.Id; }
        }
        public DateTime EditTime
        {
            get { return user.EditTime; }
        }
    }
}
