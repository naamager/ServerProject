
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
        public void Add(Response item)
        {
            this.context.Responses.Add(item);
            this.context.save();
        }

        public void Delete(Response item)
        {
            this.context.Responses.Remove(item);
        }

        public List<Response> GetAll()
        {
            return this.context.Responses.ToList();
        }

        public Response GetById(int id)
        {
            return this.context.Responses.FirstOrDefault(x => x.Id == id);
        }

        public void Update(int id, Response item)
        {
            var Response = this.context.Responses.FirstOrDefault(x => x.Id == id);
            Response.Name = item.Name;
            this.context.save();
        }
    }
}
