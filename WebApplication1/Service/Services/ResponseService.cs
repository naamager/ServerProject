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
        public async Task Add(ResponseDto service)
        {
            await _repository.Add(mapper.Map<Response>(service));
        }

        public async Task<List<ResponseDto>> GetAll()
        {
            return mapper.Map<List<ResponseDto>>(await _repository.GetAll());
        }

        public async Task<ResponseDto> GetById(int id)
        {
            return mapper.Map<ResponseDto>( await _repository.GetById(id));
        }

        public async Task Remove(int id)
        {
            await _repository.Delete(id);
        }

        public async Task Update(int id, ResponseDto service)
        {
            await _repository.Update(id, mapper.Map<Response>(service));
        }
    }
}
