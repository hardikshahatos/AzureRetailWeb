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
    
    public class OrderController : ControllerBase
    {
        private readonly IOrderComponent orderComponent;

        public OrderController()
        {
            orderComponent = new OrderComponent();
        }

        [HttpGet]
        [Route("api/orders/{id:int}")]
        public ActionResult<Order> Get(int id)
        {
            var item = orderComponent.GetOrderById(id);

            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpGet]
        [Route("api/orders")]
        public ActionResult<IEnumerable<Order>> Get()
        {

            var orders = orderComponent.GetOrders();
            if (orders == null || orders.Count() == 0)
            {
                return NotFound();
            }
            return Ok(orders);

        }
    }
}