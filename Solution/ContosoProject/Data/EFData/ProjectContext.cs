using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EFData
{
    public class ProjectContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<ProductCategory> Categories { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }        
        
        public DbSet<Comment> Comments { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public ProjectContext() : base("ContosoProject")
        {

        }
    }
}
