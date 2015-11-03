using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class GoodsRow : BaseEntity
    {
        [Required]
        public Goods Goods { get; set; }
        public int Count { get; set; }
        [Required]
        public double Price { get; set; }
        double totalPrise;
        public double TotalPrice
        {
            get
            {
                return totalPrise;
            }
            set
            {
                totalPrise = Price * Count;
            }
        }

        public GoodsRow() { Goods = new Goods(); }


    }
}
