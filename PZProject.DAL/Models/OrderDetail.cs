﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PZProject.DAL.Models
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int? Quantity { get; set; }
        public double? TotalSum { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
