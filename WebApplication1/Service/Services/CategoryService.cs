using AutoMapper;
using Common.Dtos;
using Repository.Entity;
using Repository.Interface;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CategoryService : IService<CategoryDto>
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper mapper;
        public CategoryService(IRepository<Category> repository, IMapper map)
        {
            this._repository = repository;
            this.mapper = map;
        }

        public async Task Add(CategoryDto service)
        {
            await _repository.Add(mapper.Map<Category>(service));
        }

        public async Task< List<CategoryDto>> GetAll()
        {
            return mapper.Map<List<CategoryDto>>(await _repository.GetAll());
        }

        public async Task<CategoryDto> GetById(int id)
            
        {
            return mapper.Map<CategoryDto>(await _repository.GetById(id));
        }

        public async Task Remove(int id)
        {
           await _repository.Delete(id);
        }

        public async Task Update(int id, CategoryDto service)
        {
           await _repository.Update(id,mapper.Map<Category>(service));
        }
    }
}
