using _2_services;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace MyApp.CustomConfiguration
{
    public static class CustomAutoMapper
    {
        public static void AddCustomConfiguredAutoMapper(this IServiceCollection services)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            var mapper = config.CreateMapper();

            services.AddSingleton(mapper);
        }
    }
}