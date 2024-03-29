﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class OrderDetail
    {

        public int Id { get; set; }

        public int OrderID { get; set; }

        public int CarID { get; set; }

        public int Price { get; set; }

        public virtual Car Car { get; set; }

        public virtual Order Order { get; set; }

    }
}
