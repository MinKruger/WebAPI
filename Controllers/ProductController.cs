using System;
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
            var products = await _repository.GetAll();
            return Ok(products);
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult> Post([FromBody]Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            if (!ModelState.IsValid)
                return BadRequest();

            await _repository.Add(product);

            return Ok();
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody]Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            if (!ModelState.IsValid)
                return BadRequest();

            await _repository.Update(product);
            
            return Ok();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<List<Product>>> Delete(int id)
        {
            var product = await _repository.GetById(id);

            if (product == null)
                return NotFound();

            await _repository.Remove(product);
            
            return Ok();
        }
    }
}