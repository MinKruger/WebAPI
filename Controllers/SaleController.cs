using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Core.Entities;
using WebAPI.Core.Repositories;

namespace WebAPI.Controllers
{
    [Route("v1/Sales")]
    public class SaleController : Controller
    {
        private readonly IAsyncRepository<Sale> _repository;
        public SaleController(IAsyncRepository<Sale> repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Sale>>> Get()
        {            
            var items = await _repository.GetAll();
            return Ok(items);
        }
    }
}