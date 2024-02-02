using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class RecipeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
      //  public virtual ICollection<Category> Categories { get; set; }

        public int NumOfViews { get; set; }

    //    public virtual ICollection<Picture> Pictures { get; set; }
      //  public virtual ICollection<Response> Responses { get; set; }
        public string TheRecipe { get; set; }
        
       
    }
}
