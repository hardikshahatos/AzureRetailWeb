using OrderService.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Business
{
    public class OrderComponent : IOrderComponent
    {
        IList<Order> orders = new List<Order>();
        Order _order = null;
        public OrderComponent()
        {
            _order = new Order
            {
                OrderId = 1,
                TotalAmount = 50,
                CustomerId = 1,
                TransactionDateTime = new DateTime(2020, 12, 18)

            };
            orders.Add(_order);
            _order = new Order
            {
                OrderId = 2,
                CustomerId = 2,
                TotalAmount = 450,
                TransactionDateTime = new DateTime(2020, 12, 18)

            };
            orders.Add(_order);
            _order = new Order
            {
                OrderId = 3,
                CustomerId = 2,
                TotalAmount = 200,
                TransactionDateTime = new DateTime(2020, 12, 18)

            };
            orders.Add(_order);
        }

        public Order GetOrderById(int orderId)
        {
            return orders.Where(x => x.OrderId == orderId).SingleOrDefault();
        }

        public IEnumerable<Order> GetOrders()
        {
            return orders;
        }
    }
}
