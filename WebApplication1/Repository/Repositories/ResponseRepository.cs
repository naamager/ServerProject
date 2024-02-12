
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
    public class ResponseRepository : IRepository<Response>
    {
        private readonly IContext context;
        public ResponseRepository(IContext context)
        {
            this.context = context;
        }
        public async Task Add(Response item)
        {
          await this.context.Responses.AddAsync(item);
           await this.context.save();
        }

        public async Task Delete(int item)
        {
            this.context.Responses.Remove(context.Responses.FirstOrDefault(x => x.Id == item));

            await context.save();
        }

        public async Task<List<Response>> GetAll()
        {
            return await this.context.Responses.ToListAsync();
        }

        public async Task<Response> GetById(int id)
        {
            return await context.Responses.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Update(int id, Response item)
        {
            var Response = this.context.Responses.FirstOrDefault(x => x.Id == id);
            Response.Name = item.Name;
            await this.context.save();
        }
    }
}
