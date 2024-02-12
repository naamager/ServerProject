using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IService<T> where T : class
    {
        public Task Add(T service);
        public Task Remove(int id);

        public Task<T> GetById(int id);
        public Task<List<T>> GetAll();

        public Task Update(int id, T service);
    }
}
