using Microsoft.EntityFrameworkCore;
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
        public async Task Add(Recipe item)
        {
            await this.context.Recipes.AddAsync(item);
            await this.context.save();
        }

        public async Task Delete(int item)
        {
            this.context.Recipes.Remove(context.Recipes.FirstOrDefault(x => x.Id == item));
            await context.save();
        }

        public async Task<List<Recipe>> GetAll()
        {
            return await this.context.Recipes.ToListAsync();
        }

        public async Task<Recipe> GetById(int id)
        {
            return await context.Recipes.FirstOrDefaultAsync(x => x.Id == id);

        }

        public async Task Update(int id, Recipe item)
        {
            var Recipe = await context.Recipes.FirstOrDefaultAsync(x => x.Id == id);
            Recipe.Name = item.Name;
            Recipe.Id = item.Id;
            Recipe.Categories = item.Categories;
            Recipe.NumOfViews = item.NumOfViews;
            Recipe.Responses = item.Responses;
            Recipe.Pictures = item.Pictures;
            Recipe.RecipeDescription = item.RecipeDescription;
            Recipe.Ingredients = item.Ingredients;
            Recipe.Preparation = item.Preparation;
            await this.context.save();
        }
    }
}
