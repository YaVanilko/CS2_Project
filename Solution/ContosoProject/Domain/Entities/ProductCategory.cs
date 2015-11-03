using Domain.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductCategory : BaseEntity
    {
        [Required]
        [MinLength(2), MaxLength(50)]
        public string CategoryName { get; set; }

        public List<Goods> Goods { get; set; }

        public ProductCategory()
        {
            Goods = new List<Goods>();
        }
    }
}
