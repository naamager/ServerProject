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
    public class ResponseService : IService<ResponseDto>
    {
        private readonly IRepository<Response> _repository;
        private readonly IMapper mapper;
        public ResponseService(IRepository<Response> repository, IMapper map)
        {
            this._repository = repository;
            this.mapper = map;
        }
        public void Add(ResponseDto service)
        {
            this._repository.Add(mapper.Map<Response>(service));
        }

        public List<ResponseDto> GetAll()
        {
            return mapper.Map<List<ResponseDto>>(_repository.GetAll());
        }

        public ResponseDto GetById(int id)
        {
            return mapper.Map<ResponseDto>(_repository.GetById(id));
        }

        public void Remove(ResponseDto service)
        {
            _repository.Delete(mapper.Map<Response>(service));
        }

        public void Update(int id, ResponseDto service)
        {
            _repository.Update(id, mapper.Map<Response>(service));
        }
    }
}
