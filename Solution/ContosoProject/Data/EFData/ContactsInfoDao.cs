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
    public class ContactsInfoDao : EfBaseDao<ContactInfo>, IContactInfoRepository
    {
        public new IQueryable<ContactInfo> GetAll()
        {
            IQueryable<ContactInfo> collection =
                dbContext.ContactInfoes.Where(x => x.IsActive);
            return collection;
        }

        public new ContactInfo GetById(int id)
        {
            return dbContext.ContactInfoes.Where(x => x.Id == id).FirstOrDefault();
        }

        public new void Update(ContactInfo entity)
        {
            dbContext.ContactInfoes.AddOrUpdate(entity);
            dbContext.SaveChanges();
        }
    }
}
