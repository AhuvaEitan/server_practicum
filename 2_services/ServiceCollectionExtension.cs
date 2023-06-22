using _2_services.Interfaces;
using _2_services.Models;
using _2_services.ServiceClassas;
using _3_repositories;
using _3_repositories.Entities;
using _3_repositories.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace _2_services
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddScoped<IService<PersonModel>, PersonService>();
            services.AddSingleton<IDataSource, Context>();
            services.AddAutoMapper(typeof(MappingProfile));
            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<Person, PersonModel>();
            //    cfg.CreateMap<Child, ChildModel>();
            //    cfg.CreateMap<PersonModel, Person>();
            //    cfg.CreateMap<ChildModel, Child>();
            //});

            //IMapper mapper = config.CreateMapper();

            //services.AddSingleton(mapper);

            return services;
        }
    }
}