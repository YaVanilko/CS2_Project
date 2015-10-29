using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public PersonalInfo PersonalInfo { get; set; }
        public Role Role { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public User()
        {
            PersonalInfo = new PersonalInfo();
            Role = new Role();
        }
    }
}
