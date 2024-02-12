using Common.Dtos;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Recipe_site.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IService<UserDto> service;

        public UserController(IService<UserDto> service)
        {
            this.service = service;
        }


        // GET: api/<UserController>
        [HttpGet]
        public async Task<List<UserDto>> Get()
        {
            return await service.GetAll();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<UserDto> Get(int id)
        {
            return await service.GetById(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task Post([FromForm] UserDto user)
        {
            //foreach (var item in user.files)
            //{
            //    var myPath = Path.Combine(Environment.CurrentDirectory + "/Images/" + item.FileName);
            //    using (FileStream fs = new FileStream(myPath, FileMode.Create)) { 
                
            //    item.CopyTo(fs);
            //        fs.Close();
            //    }
            //}
            await service.Add(user);

            //add database
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] UserDto value)
        {
            await service.Update(id, value);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await service.Remove(id);
        }
    }
}
