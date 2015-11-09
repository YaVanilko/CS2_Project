using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.Order.Search
{
    public class SearchViewModel
    {
        public int Id { get; set; }
        public OrderStatus Status { get; set; }
        public Customer Customer { get; set; }
        public List<Goods> Goods { get; set; }
        public double TotalCost { get; set; }
    }
}
