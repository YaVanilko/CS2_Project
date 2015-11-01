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
    public class UserDao : EfBaseDao<User>, IUserRepository
    {

        public bool TryFindByLoginPassword(out User authUser, string login, string password)
        {
            bool isFind = false;
            authUser = dbContext.Users.Where(x => x.Login==login&&x.Password==password)
                    .Include(x => x.Role)
                    .Include(x => x.PersonalInfo).FirstOrDefault();
            if (authUser !=null)
            {
                isFind = true;
            }
            return isFind;
        }

        public new IQueryable<User> GetAll()
        {
            IQueryable<User> collection =
                dbContext.Users
                    .Include(x => x.Role)
                    .Include(x => x.PersonalInfo);
            return collection;
        }
        public User GetById(int id)
        {
            return dbContext.Users.Where(x => x.Id == id)
                    .Include(x => x.Role)
                    .Include(x => x.PersonalInfo).FirstOrDefault();
        }
        public new void Update(User entity)
        {
            dbContext.Users.AddOrUpdate(entity);
            dbContext.SaveChanges();
        }
    }
}
