using AutoMapper;
using Blog.Bussiness.DTOs.AuthDTOs;
using Blog.Core.Entities;

namespace Blog.Bussiness.Profiles
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<RegisterDTO, AppUser>();
        }
    }
}
