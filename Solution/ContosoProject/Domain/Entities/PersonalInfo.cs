using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PersonalInfo: BaseEntity
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public PersonalInfo(User user, string firstName, string middleName, string lastName)
            :base(user)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }
    }
}
