using Common.Dtos;
using Microsoft.Extensions.DependencyInjection;
using Repository.Entity;
using Repository.Interface;
using Repository.Repositories;
using Service.Interfaces;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepository();
            services.AddScoped(typeof(IService<CategoryDto>), typeof(CategoryService));
            
            services.AddScoped(typeof(IService<RecipeDto>), typeof(RecipeService));
            services.AddScoped(typeof(IService<ResponseDto>), typeof(ResponseService));
            services.AddScoped(typeof(IService<UserDto>), typeof(UserService));
            services.AddAutoMapper(typeof(MapperProfile));
            return services;
        }
    }
}
