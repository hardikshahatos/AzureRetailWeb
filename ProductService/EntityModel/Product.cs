﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.EntityModel
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }

    }
}
