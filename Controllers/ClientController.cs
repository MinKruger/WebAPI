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
    }
}