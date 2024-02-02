using Repository.Entity;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class RecipeRepository : IRepository<Recipe>
    {

        private readonly IContext context;
        public RecipeRepository(IContext context)
        {
            this.context = context;
        }
        public void Add(Recipe item)
        {
            this.context.Recipes.Add(item);
            this.context.save();
        }

        public void Delete(Recipe item)
        {
            this.context.Recipes.Remove(item);
        }

        public List<Recipe> GetAll()
        {
            return this.context.Recipes.ToList();
        }

        public Recipe GetById(int id)
        {
            return this.context.Recipes.FirstOrDefault(x => x.Id == id);

        }

        public void Update(int id, Recipe item)
        {
            var Recipe = this.context.Recipes.FirstOrDefault(x => x.Id == id);
            Recipe.Name = item.Name;
            this.context.save();
        }
    }
}
