using AutoMapper;
using Common.Dtos;
using Repository.Entity;

namespace Service.Services
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Recipe, RecipeDto>().ReverseMap();
            CreateMap<Response, ResponseDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}