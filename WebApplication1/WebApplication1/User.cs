using Microsoft.AspNetCore.Http;

namespace Recipe_site
{
    public class UserDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<IFormFile> files { get; set; }
    }
}
