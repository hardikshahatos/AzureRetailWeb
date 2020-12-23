using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerService.Business;
using CustomerService.EntityModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerService.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerComponent authenticateCustomerComponent;

        public CustomerController()
        {
            authenticateCustomerComponent = new CustomerComponent();
        }
        [HttpGet]
        [Route("api/customer/{id:int}")]
        public ActionResult<Customer> Get(int id)
        {
            var item = authenticateCustomerComponent.GetCustomer(id);

            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpGet]
        [Route ("api/customer/authenticate")]
        public ActionResult<bool> Get(Customer customer)
        {

            var isAuthenticated = authenticateCustomerComponent.IsAuthenticated(customer);
            if (isAuthenticated)
                return true;
            return false;

        }
    }
}