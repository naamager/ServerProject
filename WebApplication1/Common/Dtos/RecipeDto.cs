using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Common.Dtos
{
    public class RecipeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<IFormFile> files { get; set; }

        //  public virtual ICollection<Category> Categories { get; set; }

        public int NumOfViews { get; set; }

        public DateTime UploadDate { get; set; }
        //  public virtual ICollection<Response> Responses { get; set; }
        public string RecipeDescription { get; set; }
        public string Preparation { get; set; }
        public string Ingredients { get; set; }


    }
}
