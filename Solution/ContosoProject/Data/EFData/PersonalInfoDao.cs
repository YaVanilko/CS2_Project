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
        public new IQueryable<PersonalInfo> GetAll()
        {
            IQueryable<PersonalInfo> collection =
                dbContext.PersonalInfoes.Where(x => x.IsActive);
            return collection;
        }

        public new PersonalInfo GetById(int id)
        {
            return dbContext.PersonalInfoes.Where(x => x.Id == id).FirstOrDefault();
        }

        public new void Update(PersonalInfo entity)
        {
            dbContext.PersonalInfoes.AddOrUpdate(entity);
            dbContext.SaveChanges();
        }
    }
}
