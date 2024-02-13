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
    public class UserService : IService<UserDto>
    {
        private readonly IRepository<User> _repository;
        private readonly IMapper mapper;
        public UserService(IRepository<User> repository, IMapper map)
        {
            this._repository = repository;
            this.mapper = map;
        }
        public async Task<UserDto> Add(UserDto service)
        {
         return mapper.Map<UserDto>(   await _repository.Add(mapper.Map<User>(service)));
        }

        public async Task< List<UserDto>> GetAll()
        {
            return mapper.Map<List<UserDto>>(await _repository.GetAll());
        }

        public async Task<UserDto >GetById(int id)
        {
            return mapper.Map<UserDto>(await _repository.GetById(id));
        }

        public async Task Remove(int id)
        {
            await _repository.Delete(id);
        }

        public async Task Update(int id, UserDto service)
        {
            await _repository.Update(id, mapper.Map<User>(service));
        }
    }
}
