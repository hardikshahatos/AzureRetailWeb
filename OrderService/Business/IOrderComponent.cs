using OrderService.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Business
{
    interface IOrderComponent
    {
        Order GetOrderById(int orderId);
        IEnumerable<Order> GetOrders();
    }
}
