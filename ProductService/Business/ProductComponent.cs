using ProductService.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.Business
{
    public class ProductComponent : IProductComponent
    {
        IList<Product> products = new List<Product>();
        Product _product = null;
        public ProductComponent()
        {
            _product = new Product
            {
                ProductId = 1,
                IsActive = true,
                Name = "Product1",
                Quantity = 100,
                Price = 550
            };
            products.Add(_product);
            _product = new Product
            {
                ProductId = 2,
                IsActive = true,
                Name = "Product2",
                Quantity = 90,
                Price = 650
            };
            products.Add(_product);
        }
        public Product GetProductById(int productId)
        {
            return products.Where(x=>x.ProductId == productId).SingleOrDefault();
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }

        
    }
}
