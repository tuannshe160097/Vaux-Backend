using AutoMapper;
using Vaux.DTO;
using Vaux.Models;

namespace Vaux.MapperProfiles
{
    public class DefaultProfile : Profile
    {
        public DefaultProfile() 
        {
            CreateMap<AdminCreateDTO, SuperUser>();
        }
    }
}
