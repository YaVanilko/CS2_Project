using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class GoodsRow : BaseEntity
    {
        public Goods Goods { get; set; }
        public int Count { get; set; }

        public double TotalPrice
        {
            get
            {
                return Goods.Price * Count;
            }
        }

        public GoodsRow() 
        { 
            Goods = new Goods(); 
        }
    }
}
