using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IService<T> where T : class
    {
        public void Add(T service);
        public void Remove(T service);

        public T GetById(int id);
        public List<T> GetAll();

        public void Update(int id, T service);
    }
}
