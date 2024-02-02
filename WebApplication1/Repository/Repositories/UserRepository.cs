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

        public void Add(User item)
        {
            this.context.Users.Add(item);
            this.context.save();
        }

        public void Delete(User item)
        {
            this.context.Users.Remove(item);
        }

        public List<User> GetAll()
        {
            return this.context.Users.ToList();
        }

        public User GetById(int id)
        {
           return this.context.Users.FirstOrDefault(x => x.Id == id);
        }

        public void Update(int id, User item)
        {
            var user = this.context.Users.FirstOrDefault(x => x.Id == id);
            user.Name = item.Name;
            this.context.save();
        }
    }
}
