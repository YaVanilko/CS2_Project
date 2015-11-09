using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.GoodsAll.GoodsF
{
    public class GoodsListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SKU { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public string Category { get; set; }
        public string Coment { get; set; }
        public bool isActive { get; set; }
        public string User { get; set; }

    }
}
