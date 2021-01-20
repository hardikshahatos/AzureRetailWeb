using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.Business;
using OrderService.EntityModel;

namespace OrderService.Controllers
{
    
    public class OrderDetailController : ControllerBase
    {
        private readonly IOrderDetailComponent orderDetailComponent;

        public OrderDetailController()
        {
            orderDetailComponent = new OrderDetailComponent();
        }

        [HttpGet]
        [Route("api/orderdetails/{id:int}")]
        public ActionResult<OrderDetail> Get(int id)
        {
            var item = orderDetailComponent.GetOrderDetailsById(id);

            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpGet]
        [Route("api/orderdetailsbyorder/{id:int}")]
        public ActionResult<IEnumerable<Order>> GetByOrderId(int id)
        {

            var orders = orderDetailComponent.GetOrderDetails(id);
            if (orders == null || orders.Count() == 0)
            {
                return NotFound();
            }
            return Ok(orders);

        }
    }
}