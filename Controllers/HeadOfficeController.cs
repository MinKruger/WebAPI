using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Core.Entities;
using WebAPI.Core.Repositories;

namespace WebAPI.Controllers
{
    [Route("v1/HeadOffices")]
    public class HeadOfficeController : Controller
    {
        private readonly IAsyncRepository<HeadOffice> _repository;
        public HeadOfficeController(IAsyncRepository<HeadOffice> repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<HeadOffice>>> Get()
        {            
            var headOffices = await _repository.GetAll();
            return Ok(headOffices);
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult> Post([FromBody]HeadOffice headOffice)
        {
            if (headOffice == null)
                throw new ArgumentNullException(nameof(headOffice));

            if (!ModelState.IsValid)
                return BadRequest();

            await _repository.Add(headOffice);

            return Ok();
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody]HeadOffice headOffice)
        {
            if (headOffice == null)
                throw new ArgumentNullException(nameof(headOffice));

            if (!ModelState.IsValid)
                return BadRequest();

            await _repository.Update(headOffice);
            
            return Ok();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<List<HeadOffice>>> Delete(int id)
        {
            var headOffice = await _repository.GetById(id);

            if (headOffice == null)
                return NotFound();

            await _repository.Remove(headOffice);
            
            return Ok();
        }
    }
}