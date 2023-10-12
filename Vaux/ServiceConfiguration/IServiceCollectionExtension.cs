using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Vaux.MapperProfiles;
using Vaux.Repositories;
using Vaux.Repositories.Interface;

namespace Vaux.ServiceConfiguration
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IAuthRepo, AuthRepo>();
            services.AddScoped<IUserRepo, UserRepo>();
            services.AddScoped<ISuperUserRepo, SuperUserRepo>();

            return services;
        }

        public static IServiceCollection AddMapperServices(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new DefaultProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
}
