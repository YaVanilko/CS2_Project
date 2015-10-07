using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PersonalInfo : BaseEntity
    {
        private string firstName;
        private string middleName;
        private string lastName;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value.Length != 0)
                {
                    firstName = value;
                }
            }
        }

        public string MiddleName
        {
            get { return middleName; }
            set
            {
                if (value.Length != 0)
                {
                    middleName = value;
                }
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value.Length != 0)
                {
                    lastName = value;
                }
            }
        }

        public PersonalInfo (string name, string middleName, string surname)
        {
            FirstName = name;
            MiddleName = middleName;
            LastName = surname;
        }
    }
}
