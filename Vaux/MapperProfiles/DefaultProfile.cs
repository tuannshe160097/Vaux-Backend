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
            CreateMap<UserStrictDTO, User>()
                .ForMember(dest => dest.Role, opt => opt.Ignore())
                .ForMember(dest => dest.RoleId, opt => opt.Ignore());

            CreateMap<CategoryDTO, Category>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Items, opt => opt.Ignore());

            CreateMap<ItemApplicationDTO, Item>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
            CreateMap<ItemPropertyDTO, ItemProperty>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<Category, CategoryDTO>();
        }
    }
}
