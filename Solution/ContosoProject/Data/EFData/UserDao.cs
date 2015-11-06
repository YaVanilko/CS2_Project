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
        public UserDao(ProjectContext context = null)
            : base(context)
        {

        }

        public bool TryFindByLoginPassword(out User authUser, string login, string password)
        {
            bool isFind = false;
            using (ProjectContext ctx = new ProjectContext())
            {
                authUser = ctx.Users.Where(x => x.Login == login && x.Password == password)
                            .Include(x => x.Role)
                            .Include(x => x.PersonalInfo).FirstOrDefault();
                if (authUser != null)
                {
                    isFind = true;
                }
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

        public new User GetById(int id)
        {
            return dbContext.Users.Where(x => x.Id == id)
                    .Include(x => x.Role)
                    .Include(x => x.PersonalInfo).FirstOrDefault();
        }
    }
}
