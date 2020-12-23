using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductService.Business;
using ProductService.EntityModel;

namespace ProductService.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductComponent productComponent;
        public ProductController()
        {
            productComponent = new ProductComponent();
        }

        [HttpGet]
        [Route("api/product/{id:int}")]
        public ActionResult<Product> Get(int id)
        {
            var item = productComponent.GetProductById(id);

            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpGet]
        [Route("api/products")]
        public ActionResult<IEnumerable<Product>> Get()
        {
            var items = productComponent.GetProducts();

            if (items == null)
            {
                return NotFound();
            }
            return Ok(items);
        }

    }
}