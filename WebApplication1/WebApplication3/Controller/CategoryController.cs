using Common.Dtos;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecipeSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IService<CategoryDto> service;

        public CategoryController(IService<CategoryDto> service)
        {
            this.service = service;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public async Task<List<CategoryDto>> Get()
        {
            return await service.GetAll();
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public async Task<CategoryDto> Get(int id)
        {
            return await service.GetById(id);
        }
    

    // POST api/<CategoryController>
    [HttpPost]
    public async Task Post([FromBody] CategoryDto value)
    {
        await service.Add(value);
    }

    // PUT api/<CategoryController>/5
    [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] CategoryDto value)
        {
        await service.Update(id, value);
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
        await service.Remove(id);
    }
    }
}
