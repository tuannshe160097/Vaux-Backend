﻿using AutoMapper;
using Vaux.DTO;
using Vaux.Models;

namespace Vaux.MapperProfiles
{
    public class DefaultProfile : Profile
    {
        public DefaultProfile() 
        {
            CreateMap<AdminCreateDTO, SuperUser>();
            CreateMap<ProfileUpdateDTO, User>()
                .ForMember(dest => dest.IsVerified,
                opt => opt.Ignore())
                .ForMember(dest => dest.Role,
                opt => opt.Ignore())
                .ForMember(dest => dest.RoleId,
                opt => opt.Ignore());
        }
    }
}
