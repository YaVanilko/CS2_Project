﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrderStatus : BaseEntity
    {
        public string Status { get; set; }

        public OrderStatus()
        {
        }

        public override string ToString()
        {
            return String.Format(Status);
        }
    }
}
