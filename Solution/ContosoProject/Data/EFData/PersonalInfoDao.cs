using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Data.EFData
{
    public class PersonalInfoDao : EfBaseDao<PersonalInfo>, IPersonalInfoRepository
    {
        public PersonalInfoDao(ProjectContext context = null)
            : base(context)
        {

        }
        public new IQueryable<PersonalInfo> GetAll()
        {
            IQueryable<PersonalInfo> collection =
                dbContext.PersonalInfoes.Where(x => x.IsActive);
            return collection;
        }
    }
}
