using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.EntityModel
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public double TotalAmount { get; set; }
    }
}
