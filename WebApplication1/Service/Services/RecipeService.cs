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
        public async Task Add(RecipeDto service)
        {
           await _repository.Add(mapper.Map<Recipe>(service));
        }

        public async Task<List<RecipeDto>> GetAll()
        {
            return mapper.Map<List<RecipeDto>>(await _repository.GetAll());
        }

        public async Task<RecipeDto> GetById(int id)
        {
            return mapper.Map<RecipeDto>(await _repository.GetById(id));
        }

        public async Task Remove(int id)
        {
            await _repository.Delete(id);
        }

        public async Task Update(int id, RecipeDto service)
        {
          await  _repository.Update(id, mapper.Map<Recipe>(service));
        }
    }
}
