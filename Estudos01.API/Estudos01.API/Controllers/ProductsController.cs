using Estudos01.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Estudos01.API.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product{ Id = 1, Name = "Xbox", Category =  "Gamer", Price = 500M},
            new Product{ Id = 2, Name = "Uno", Category =  "Brinquedo", Price = 3.7M},
            new Product{ Id = 3, Name = "Poco", Category =  "Celular", Price = 16.5M}

        };
        
        public IEnumerable<Product>GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);

        }
    }
}