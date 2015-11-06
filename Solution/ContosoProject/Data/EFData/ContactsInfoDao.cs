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
        public ContactsInfoDao(ProjectContext context = null)
            : base(context)
        {

        }
    }
}
