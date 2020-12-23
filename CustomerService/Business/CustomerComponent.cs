using CustomerService.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerService.Business
{
    public class CustomerComponent : ICustomerComponent
    {
        IList<Customer> customers = new List<Customer>();
        Customer _customer = null;
        public CustomerComponent()
        {
            _customer = new Customer
            {
                CustomerId = 1,
                Email = "hardik.shah@atos.net",
                IsActive = true,
                Name = "Hardik Shah",
                Passwd = "hardikshah"
            };
            customers.Add(_customer);
        }
        public Customer GetCustomer(int customerId)
        {
            return customers.Where(x=>x.CustomerId == customerId).SingleOrDefault();
        }

        public bool IsAuthenticated(Customer customer)
        {
            if (customers.Where(x=>x.Passwd == customer.Passwd && x.Email == customer.Email).SingleOrDefault() != null)
                return true;
            return false;
        }
    }
}
