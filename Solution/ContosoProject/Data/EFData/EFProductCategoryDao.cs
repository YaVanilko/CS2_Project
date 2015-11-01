using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

namespace Data.EFData
{
    public class EFProductCategoryDao : EfBaseDao<ProductCategory>
    {
        ProjectContext context;
        public EFProductCategoryDao(ProjectContext context)
        {
            this.context=context;
        }

        public ICollection<ProductCategory> GetAll()
        {
            ICollection<ProductCategory> collection;
            collection = from p in context.Categories
                         where p.IsActive=true
                         select p;

            return collection;
        }
    }
}
