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
    }
}