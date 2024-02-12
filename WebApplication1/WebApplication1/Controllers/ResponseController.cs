using Common.Dtos;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Recipe_site.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponseController : ControllerBase
    {
        private readonly IService<ResponseDto> service;

        public ResponseController(IService<ResponseDto> service)
        {
            this.service = service;
        }

        // GET: api/<ResponseController>
        [HttpGet]
        public async Task<List<ResponseDto>> Get()
        {
            return await service.GetAll();
        }

        // GET api/<ResponseController>/5
        [HttpGet("{id}")]
        public async Task<ResponseDto> Get(int id)
        {
            return await service.GetById(id);
        }

        // POST api/<ResponseController>
        [HttpPost]
        public async Task Post([FromBody] ResponseDto value)
        {
            await service.Add(value);
        }

        // PUT api/<ResponseController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] ResponseDto value)
        {
            await service.Update(id, value);
        }

        // DELETE api/<ResponseController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await service.Remove(id);
        }
    }
}
