using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Vaux.MapperProfiles;
using Vaux.Repositories;
using Vaux.Repositories.Interface;

namespace Vaux.ServiceConfiguration
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepo<>), typeof(BaseRepo<>));

            services.AddScoped<IAuthRepo, AuthRepo>();
            services.AddScoped<IUserRepo, UserRepo>();
            services.AddScoped<IItemRepo, ItemRepo>();
            services.AddScoped<IChatRepo, ChatRepo>();
            services.AddScoped<ISellerApplicationRepo, SellerApplicationRepo>();
            services.AddScoped<IPhotoRepo, PhotoRepo>();
            services.AddScoped<IAuctionSessionRepo, AuctionSessionRepo>();

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
