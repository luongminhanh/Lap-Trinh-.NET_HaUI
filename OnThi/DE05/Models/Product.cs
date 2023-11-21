﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DE05.Models
{
    public partial class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int? UnitPrice { get; set; }
        public int? Quantity { get; set; }
        public string CatId { get; set; }

        public virtual Category Cat { get; set; }
    }
}
