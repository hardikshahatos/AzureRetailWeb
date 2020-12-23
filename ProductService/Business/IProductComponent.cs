using ProductService.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.Business
{
    public interface IProductComponent
    {
        Product GetProductById(int productId);
        IEnumerable<Product> GetProducts();
    }
}
