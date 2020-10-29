using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Core.Entities;
using WebAPI.Core.Repositories;

namespace WebAPI.Controllers
{
    [Route("v1/Products")]
    public class ProductController : Controller
    {
        private readonly IAsyncRepository<Product> _repository;
        public ProductController(IAsyncRepository<Product> repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Product>>> Get()
        {            
            var items = await _repository.GetAll();
            return Ok(items);
        }
    }
}