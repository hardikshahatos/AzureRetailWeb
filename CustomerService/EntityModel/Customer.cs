using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerService.EntityModel
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Passwd { get; set; }
        public bool IsActive { get; set; }

    }
}
