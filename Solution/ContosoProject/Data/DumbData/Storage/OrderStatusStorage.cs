using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DumbData
{
    public static partial class Storage
    {
        public static List<OrderStatus> orderStatusCollection = new List<OrderStatus>()
        { 
            new OrderStatus(){ Status = "Открыт"},
            new OrderStatus(){ Status = "Оплачен"},
            new OrderStatus(){ Status = "Готов"},
            new OrderStatus(){ Status = "Отгружен"},
            new OrderStatus(){ Status = "Закрыт"}
        };

    }
}
