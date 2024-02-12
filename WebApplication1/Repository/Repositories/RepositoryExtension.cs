using Microsoft.Extensions.DependencyInjection;
using Repository.Entity;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public static class RepositoryExtension
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {

            services.AddScoped(typeof(IRepository<Category>), typeof(CategoryRepository));
            
            services.AddScoped(typeof(IRepository<Recipe>), typeof(RecipeRepository));
            services.AddScoped(typeof(IRepository<Response>), typeof(ResponseRepository));
            services.AddScoped(typeof(IRepository<User>), typeof(UserRepository));

            return services;
        }
    }
}
