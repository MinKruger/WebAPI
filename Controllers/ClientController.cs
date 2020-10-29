using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Core.Entities;
using WebAPI.Core.Repositories;

namespace WebAPI.Controllers
{
    [Route("v1/Clients")]
    public class ClientController : Controller
    {
        private readonly IAsyncRepository<Client> _repository;
        public ClientController(IAsyncRepository<Client> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Client>>> Get()
        {            
            var clients = await _repository.GetAll();
            return Ok(clients);
        }

        [HttpGet]
        [Route("Section/{id:int}")]
        public async Task<ActionResult<List<Client>>> GetBySection(int id)
        {            
            var clients = await _repository.FindBy(x => x.HeadOfficeId == id);
            return Ok(clients);
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult> Post([FromBody]Client client)
        {
            if (client == null)
                throw new ArgumentNullException(nameof(client));

            if (!ModelState.IsValid)
                return BadRequest();

            await _repository.Add(client);

            return Ok();
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody]Client client)
        {
            if (client == null)
                throw new ArgumentNullException(nameof(client));

            if (!ModelState.IsValid)
                return BadRequest();

            await _repository.Update(client);
            
            return Ok();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<List<Client>>> Delete(int id)
        {
            var client = await _repository.GetById(id);

            if (client == null)
                return NotFound();

            await _repository.Remove(client);
            
            return Ok();
        }
    }
}