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
    public class UserRepository : IRepository<User>
    {
        private readonly IContext context;
        public UserRepository(IContext context)
        {
            this.context = context;
        }

        public async Task Add(User item)
        {
            await this.context.Users.AddAsync(item);
           await this.context.save();
        }

        public async Task Delete(int item)
        {
            this.context.Users.Remove(context.Users.FirstOrDefault(x => x.Id == item));

            await context.save();
        }

        public async Task<List<User>> GetAll()
        {
            return  await this.context.Users.ToListAsync();
        }

        public async Task<User> GetById(int id)
        {
           return await context.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Update(int id, User item)
        {
            var user = this.context.Users.FirstOrDefault(x => x.Id == id);
            user.Name = item.Name;
            this.context.save();
        }
    }
}
