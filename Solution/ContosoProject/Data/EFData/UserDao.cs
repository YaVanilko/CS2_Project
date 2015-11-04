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
        readonly ProjectContext context;
        public UserDao()
        {
            this.context = dbContext;
        }
        public UserDao(ProjectContext context)
        {
            this.context = context;
        }
        public bool TryFindByLoginPassword(out User authUser, string login, string password)
        {
            bool isFind = false;
            authUser = context.Users.Where(x => x.Login==login&&x.Password==password)
                    .Include(x => x.Role)
                    .Include(x => x.PersonalInfo).FirstOrDefault();
            if (authUser !=null)
            {
                isFind = true;
            }
            return isFind;
        }

        public new void Add(User entity)
        {
            context.Users.Add(entity);
            context.SaveChanges();
        }
        public new IQueryable<User> GetAll()
        {
            IQueryable<User> collection =
                context.Users
                    .Include(x => x.Role)
                    .Include(x => x.PersonalInfo);
            return collection;
        }

        public new User GetById(int id)
        {
            return context.Users.Where(x => x.Id == id)
                    .Include(x => x.Role)
                    .Include(x => x.PersonalInfo).FirstOrDefault();
        }

        public new void Update(User entity)
        {
            context.Users.AddOrUpdate(entity);
            context.SaveChanges();
        }
    }
}
