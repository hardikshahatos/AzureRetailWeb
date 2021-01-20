using OrderService.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Business
{
    interface IOrderDetailComponent
    {
        OrderDetail GetOrderDetailsById(int orderDetailId);
        IEnumerable<OrderDetail> GetOrderDetails(int orderId);
    }
}
