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
    public class CategoryRepository : IRepository<Category>
    {
        private readonly IContext context;
        public CategoryRepository(IContext context)
        {
            this.context = context;
        }
        public async Task<Category> Add(Category item)
        {
            Category c = item;
            await this.context.Categories.AddAsync(c);
            await this.context.save();
            return c;
        }

        public async Task Delete(int id)
        {
             this.context.Categories.Remove(context.Categories.FirstOrDefault(x => x.Id == id));
            await context.save();

        }

        public async Task <List<Category>> GetAll()
        {
            return await this.context.Categories.ToListAsync();
        }

        public async Task <Category> GetById(int id)
        {
            return await context.Categories.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Update(int id, Category item)
        {
            var category = await context.Categories.FirstOrDefaultAsync(x => x.Id == id);
            category.Name = item.Name;
            category.Id = item.Id;
            
            await this.context.save();
        }

       
    }
}
