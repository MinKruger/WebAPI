using System;
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

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<List<Item>>> GetBySale(int id)
        {            
            var items = await _repository.FindBy(x => x.SaleId == id);
            return Ok(items);
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult> Post([FromBody]Item item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            if (!ModelState.IsValid)
                return BadRequest();

            await _repository.Add(item);

            return Ok();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<List<Item>>> Delete(int id)
        {
            var item = await _repository.GetById(id);

            if (item == null)
                throw new ArgumentNullException(nameof(item));

            await _repository.Remove(item);
            return Ok();
        }
    }
}