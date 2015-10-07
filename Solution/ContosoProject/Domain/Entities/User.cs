using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public PersonalInfo personalInfo;
        private string login;
        private string password;
        public Role role;

        public string Login
        {
            get { return login; }
            set
            {
                if (value.Length != 0 && value.Length >= 4)
                {
                    login = value;
                }
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length != 0 && value.Length >= 5)
                {
                    password = value;
                }
                else
                {
                    
                }
            }
        }

        public User (PersonalInfo info, string login, string password, Role role)
        {
            personalInfo = info;
            Login = login;
            Password = password;
            this.role = role;
        }

        public void DeactivateUser()
        {
            if (IsActive)
                IsActive = false;
        }
    }
}
