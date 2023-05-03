using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpApi.Base;
using SimpApi.Business.ValidationRules;
using SimpApi.Models;

namespace SimpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> list;
        public ProductController()
        {
            list = GetList();
        }
        private List<Product> GetList()
        {
            List<Product> products = new();
            products.Add(new Product(1, "pencil", 10, 20));
            products.Add(new Product(2, "pencil", 10, 20));
            products.Add(new Product(3, "pencil", 10, 20));
            products.Add(new Product(4, "pencil", 10, 20));
            products.Add(new Product(5, "pencil", 10, 20));
          
            return products;
        }
        [HttpGet]
        public List<Product> Get()
        {
            return new List<Product>(list);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var product = list.Where(x => x.Id == id).FirstOrDefault();

            if (product is null)
            {
                return BadRequest("Record not found");
            }
            return Ok(product);
        }
        [HttpPost]
        public ActionResult Post([FromBody] Product request)
        {
            var validator = new ProductValidator();
            var result = validator.Validate(request);
            if (!result.IsValid)
            {
                return BadRequest(result.Errors);
            }
            list.Add(request);
            return Ok();
        }

    }
}
