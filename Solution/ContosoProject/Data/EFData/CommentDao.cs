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
    public class CommentDao : ICommentRepository
    {
        ProjectContext dbContext;
        public CommentDao(ProjectContext context = null)
        {
            dbContext = context ?? new ProjectContext();
        }

        public new IQueryable<Comment> GetAll()
        {
            IQueryable<Comment> collection =
                dbContext.Comments.Where(x => x.IsActive)
                    .Include(x => x.Type);
            return collection;
        }

        public new Comment GetById(int id)
        {
            return dbContext.Comments.Where(x => x.Id == id)
                    .Include(x => x.Type).FirstOrDefault();
        }

        public new void Update(Comment entity)
        {
            dbContext.Comments.AddOrUpdate(entity);
            dbContext.SaveChanges();
        }

        public void Add(Comment entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Comment entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Comment> FindBy(System.Linq.Expressions.Expression<Func<Comment, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
