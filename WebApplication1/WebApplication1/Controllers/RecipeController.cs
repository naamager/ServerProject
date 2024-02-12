using Common.Dtos;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Recipe_site.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IService<RecipeDto> service;

        public RecipeController(IService<RecipeDto> service)
        {
            this.service = service;
        }

        // GET: api/<RecipeController>
        [HttpGet]
        public async Task<List<RecipeDto>> Get()
        {
            return await service.GetAll();
        }

        // GET api/<RecipeController>/5
        [HttpGet("{id}")]
        public async Task<RecipeDto> Get(int id)
        {
            return await service.GetById(id);
        }

        // POST api/<RecipeController>
        [HttpPost]
        public async Task Post([FromBody] RecipeDto value)
        {
            await service.Add(value);
        }

        // PUT api/<RecipeController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] RecipeDto value)
        {
            await service.Update(id, value);
        }

        // DELETE api/<RecipeController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await service.Remove(id);
        }
    }
}
