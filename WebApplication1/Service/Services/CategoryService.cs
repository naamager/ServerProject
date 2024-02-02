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

        public void Add(CategoryDto service)
        {
            this._repository.Add(mapper.Map<Category>(service));
        }

        public List<CategoryDto> GetAll()
        {
            return mapper.Map<List<CategoryDto>>(_repository.GetAll());
        }

        public CategoryDto GetById(int id)
        {
            return mapper.Map<CategoryDto>(_repository.GetById(id));
        }

        public void Remove(CategoryDto service)
        {
            _repository.Delete(mapper.Map<Category>(service));
        }

        public void Update(int id, CategoryDto service)
        {
            _repository.Update(id,mapper.Map<Category>(service));
        }
    }
}
