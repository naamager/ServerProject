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
        public async Task Add(Category item)
        {
            await this.context.Categories.Add(item);
            await this.context.save();
        }

        public async Task Delete(Category item)
        {
             this.context.Categories.Remove(item);
            
        }

        public async Task <List<Category>> GetAll()
        {
            return await this.context.Categories.ToListAsync();
        }

        public async Task <Category> GetById(int id)
        {
            return await context.Categories.FirstOrDefault(x => x.Id == id);
        }

        public async Task Update(int id, Category item)
        {
            var category = this.context.Categories.FirstOrDefault(x => x.Id == id);
            category.Name = item.Name;
            await this.context.save();
        }
    }
}
