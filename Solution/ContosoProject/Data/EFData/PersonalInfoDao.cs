using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DAO;
using Domain.Entities;

namespace Data.EFData
{
    public class PersonalInfoDao : EfBaseDao<PersonalInfo>, IPersonalInfoRepository
    {
    }
}
