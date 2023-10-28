using AutoMapper;
using Vaux.DTO;
using Vaux.Models;

namespace Vaux.MapperProfiles
{
    public class DefaultProfile : Profile
    {
        public DefaultProfile() 
        {
            CreateMap<UserMinimalDTO, User>()
                .ForMember(dest => dest.IsVerified, opt => opt.Ignore())
                .ForMember(dest => dest.Role, opt => opt.Ignore())
                .ForMember(dest => dest.RoleId, opt => opt.Ignore());

            CreateMap<UserMinimalNonOptionalDTO, User>()
                .ForMember(dest => dest.IsVerified, opt => opt.Ignore())
                .ForMember(dest => dest.Role, opt => opt.Ignore())
                .ForMember(dest => dest.RoleId, opt => opt.Ignore());

            CreateMap<User, UserMinimalDTO>();

            CreateMap<UserStrictDTO, User>()
                .ForMember(dest => dest.Role, opt => opt.Ignore())
                .ForMember(dest => dest.RoleId, opt => opt.Ignore());

            CreateMap<CategoryDTO, Category>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Items, opt => opt.Ignore());

            CreateMap<ItemApplicationDTO, Item>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<ItemPropertiesDTO, Item>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<ItemPropertyDTO, ItemProperty>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<ItemProperty, ItemPropertyDTO>();

            CreateMap<Item, ItemDTO>()
                .ForMember(dest => dest.StatusString, opt => opt.MapFrom(src => src.Status.ToString()))
                .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images != null ? src.Images.Select(e => e.Id) : null));

            CreateMap<Category, CategoryDTO>();

            CreateMap<SellerApplicationDTO, SellerApplication>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
            CreateMap<SellerApplication, SellerApplicationDTO>();
            CreateMap<SellerApplication, User>();
        }
    }
}
