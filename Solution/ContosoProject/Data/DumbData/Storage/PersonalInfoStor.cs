using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Data.DumbData
{
    public static partial class Storage
    {
        public static List<PersonalInfo> personalInfoCollection = new List<PersonalInfo>()
        {
            new PersonalInfo()
            {
                FirstName = "Татьяна",
                MiddleName = "Витальевна",
                LastName = "Петрова"
            },
            new PersonalInfo()
            {
                FirstName = "Олег",
                MiddleName = "Евгеньевич",
                LastName = "Таромский"
            },
            new PersonalInfo()
            {
                FirstName = "Григорий",
                MiddleName = "Вениаминович",
                LastName = "Крашенберг"
            },
            new PersonalInfo()
            {
                FirstName = "Зиновия",
                MiddleName = "Сидоровна",
                LastName = "Белугина"
            },
            new PersonalInfo()
            {
                FirstName = "Раиса",
                MiddleName = "Васильевна",
                LastName = "Райская"
            },
            new PersonalInfo()
            {
                FirstName = "Матвей",
                MiddleName = "Иванович",
                LastName = "Костромской"
            },
            new PersonalInfo()
            {
                FirstName = "Антон",
                MiddleName = "Денисович",
                LastName = "Бесстужев"
            },
            new PersonalInfo()
            {
                FirstName = "Иполит",
                MiddleName = "Петрович",
                LastName = "Легкопаров"
            },
            new PersonalInfo()
            {
                FirstName = "Маргарита",
                MiddleName = "Альбертовна",
                LastName = "Королева"
            },
            new PersonalInfo()
            {
                FirstName = "Наталья",
                MiddleName = "Александровна",
                LastName = "Ростова"
            }
        };
 
    }
}
