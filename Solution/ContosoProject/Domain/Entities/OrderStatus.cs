using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrderStatus:BaseEntity
    {
        List<string> status;

        public List<string> Status
        {
            get
            {
                return status;
            }

            set
            { }
        }

        public void AddOrderStatus(string newStatus)
        {
            status.Add(newStatus);
        }

        public void EditOrderStatus(List<string> newOrderStatus)
        {
            status.Clear();
            status = newOrderStatus;
        }

       

    }
}
