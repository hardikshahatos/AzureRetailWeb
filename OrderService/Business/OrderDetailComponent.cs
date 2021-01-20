using OrderService.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Business
{
    public class OrderDetailComponent : IOrderDetailComponent
    {
        IList<OrderDetail> orderDetails = new List<OrderDetail>();
        OrderDetail _orderDetail = null;
        public OrderDetailComponent()
        {
            _orderDetail = new OrderDetail
            {
                OrderDetailId = 1,
                OrderId = 1,
                OrderStatus = 1,
                ProductId = 1,
                Quantity = 1,
                SellingPrice = 50,
                TotalAmount = 50,
                TransactionDateTime = new DateTime(2020,12,18)
                
            };
            orderDetails.Add(_orderDetail);
            _orderDetail = new OrderDetail
            {
                OrderDetailId = 2,
                OrderId = 1,
                OrderStatus = 1,
                ProductId = 1,
                Quantity = 3,
                SellingPrice = 150,
                TotalAmount = 450,
                TransactionDateTime = new DateTime(2020, 12, 18)

            };
            orderDetails.Add(_orderDetail);
            _orderDetail = new OrderDetail
            {
                OrderDetailId = 3,
                OrderId = 2,
                OrderStatus = 1,
                ProductId = 2,
                Quantity = 2,
                SellingPrice = 100,
                TotalAmount = 200,
                TransactionDateTime = new DateTime(2020, 12, 18)

            };
            orderDetails.Add(_orderDetail);
        }

        public IEnumerable<OrderDetail> GetOrderDetails(int orderId)
        {
            return orderDetails.Where(x=>x.OrderId == orderId).ToList();
        }

        public OrderDetail GetOrderDetailsById(int orderDetailId)
        {
            return orderDetails.Where(x => x.OrderDetailId == orderDetailId).SingleOrDefault();
        }
    }
}
