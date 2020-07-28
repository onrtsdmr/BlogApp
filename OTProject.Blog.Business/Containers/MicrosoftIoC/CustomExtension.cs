using Microsoft.Extensions.DependencyInjection;
using OTProject.Blog.Business.Concrete;
using OTProject.Blog.Business.Interfaces;
using OTProject.Blog.DataAccess.Concrete.EfCore.Repositories;
using OTProject.Blog.DataAccess.Interfaces;

namespace OTProject.Blog.Business.Containers.MicrosoftIoC
{
    public static class CustomExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));

            services.AddScoped<ICategoryService, CategoryManager>();
        }
    }
}