﻿using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Data.EFData
{
    public class GoodsDao : EfBaseDao<Goods>, IGoodsRepository
    {
        public GoodsDao(ProjectContext context = null)
            : base(context)
        {

        }

        public ICollection<Goods> GetGoodsByCategory(string category)
        {
            return dbContext.Products.Where(x => x.Category.CategoryName == category).ToList();
        }

        public new IQueryable<Goods> GetAll()
        {
            return dbContext.Products
                .Include(x => x.Coments)
                .Include(x => x.Category)
                ;
        }

        public ICollection<Goods> GetAllIsActive()
        {
            return dbContext.Products.Where(x => x.IsActive == true).Include(x => x.Coments).ToList();
        }

        public new void Update(Goods goods)
        {
            dbContext.Products.AddOrUpdate(goods);
            dbContext.SaveChanges();
        }

        public void AddOrUpdate(Goods goods)
        {
            dbContext.Products.AddOrUpdate(x => x.Name, new Goods[] { goods });
            dbContext.SaveChanges();
        }

        public new void Add(Goods goods)
        {
            dbContext.Set<Goods>().Add(goods);
            dbContext.SaveChanges();
        }
    }
}

