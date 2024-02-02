using AutoMapper;
using Common.Dtos;
using Repository.Entity;
using Repository.Interface;
using Repository.Repositories;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class PictureService : IService<PictureDto>
    {

        private readonly IRepository<Picture> _repository;
        private readonly IMapper mapper;
        public PictureService(IRepository<Picture> repository, IMapper map)
        {
            this._repository = repository;
            this.mapper = map;
        }
        public void Add(PictureDto service)
        {
            this._repository.Add(mapper.Map<Picture>(service));
        }

        public List<PictureDto> GetAll()
        {
            return mapper.Map<List<PictureDto>>(_repository.GetAll());
        }

        public PictureDto GetById(int id)
        {
            return mapper.Map<PictureDto>(_repository.GetById(id));
        }

        public void Remove(PictureDto service)
        {
            _repository.Delete(mapper.Map<Picture>(service));
        }

        public void Update(int id, PictureDto service)
        {
            _repository.Update(id, mapper.Map<Picture>(service));
        }
    }
}
