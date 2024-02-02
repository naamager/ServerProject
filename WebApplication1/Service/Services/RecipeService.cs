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
    public class RecipeService : IService<RecipeDto>
    {

        private readonly IRepository<Recipe> _repository;
        private readonly IMapper mapper;
        public RecipeService(IRepository<Recipe> repository, IMapper map)
        {
            this._repository = repository;
            this.mapper = map;
        }
        public void Add(RecipeDto service)
        {
            this._repository.Add(mapper.Map<Recipe>(service));
        }

        public List<RecipeDto> GetAll()
        {
            return mapper.Map<List<RecipeDto>>(_repository.GetAll());
        }

        public RecipeDto GetById(int id)
        {
            return mapper.Map<RecipeDto>(_repository.GetById(id));
        }

        public void Remove(RecipeDto service)
        {
            _repository.Delete(mapper.Map<Recipe>(service));
        }

        public void Update(int id, RecipeDto service)
        {
            _repository.Update(id, mapper.Map<Recipe>(service));
        }
    }
}
