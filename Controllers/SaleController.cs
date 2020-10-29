using System;
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
            var sales = await _repository.GetAll();
            return Ok(sales);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<List<Sale>>> GetByHeadOffice(int id)
        {            
            var sales = await _repository.FindBy(x => x.HeadOfficeId == id);
            return Ok(sales);
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult> Post([FromBody]Sale sale)
        {
            if (sale == null)
                throw new ArgumentNullException(nameof(sale));

            if (!ModelState.IsValid)
                return BadRequest();

            await _repository.Add(sale);

            return Ok();
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody]Sale sale)
        {
            if (sale == null)
                throw new ArgumentNullException(nameof(sale));

            if (!ModelState.IsValid)
                return BadRequest();

            await _repository.Update(sale);
            
            return Ok();
        }
    }
}