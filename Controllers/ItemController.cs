using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Core.Entities;
using WebAPI.Core.Repositories;

namespace WebAPI.Controllers
{
    [Route("v1/Items")]
    public class ItemController : Controller
    {
        private readonly IAsyncRepository<Item> _repository;
        public ItemController(IAsyncRepository<Item> repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Item>>> Get()
        {            
            var items = await _repository.GetAll();
            return Ok(items);
        }
    }
}