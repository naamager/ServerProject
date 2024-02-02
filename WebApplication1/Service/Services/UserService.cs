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
        public void Add(UserDto service)
        {
            this._repository.Add(mapper.Map<User>(service));
        }

        public List<UserDto> GetAll()
        {
            return mapper.Map<List<UserDto>>(_repository.GetAll());
        }

        public UserDto GetById(int id)
        {
            return mapper.Map<UserDto>(_repository.GetById(id));
        }

        public void Remove(UserDto service)
        {
            _repository.Delete(mapper.Map<User>(service));
        }

        public void Update(int id, UserDto service)
        {
            _repository.Update(id, mapper.Map<User>(service));
        }
    }
}
