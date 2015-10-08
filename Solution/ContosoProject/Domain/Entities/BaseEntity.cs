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
        public bool IsActive { get; protected set; }
        public User Operator { get; protected set; }
        public DateTime EditTime { get; protected set; }

        public BaseEntity(User user)
        {
            IsActive = true;
            Operator = user;
            EditTime = DateTime.Now;
        }
    }
}
