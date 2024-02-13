using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IRepository <T> 
    {
        public Task  Add(T item);
        public Task  Update(int id, T item);
        public Task  Delete(int id);
        public Task <T> GetById(int id);
        public Task <List<T>> GetAll();
        //void Delete(Category category);
    }
}
