using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public PersonalInfo UserInfo { get; set; }
        public Role UserRole { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public User (PersonalInfo info, string login, string password, Role role)
        {
            UserInfo = info;
            Login = login;
            Password = password;
            UserRole = role;
        }
    }
}
