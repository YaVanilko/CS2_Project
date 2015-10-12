using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; protected set; }
        public bool IsActive { get; set; }
        public User Operator { get; set; }
        public DateTime EditTime { get; set; }

        public BaseEntity()
        {
            ////TODO: Add Autorized user
            IsActive = true;
            EditTime = DateTime.Now;
        }
    }
}
