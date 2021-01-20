using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.EntityModel
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public int Quantity { get; set; }
        public double SellingPrice { get; set; }
        public int OrderStatus { get; set; }
        public double TotalAmount { get; set; }

    }
}
