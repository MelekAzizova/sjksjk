using AutoMapper;
using Blog.Bussiness.DTOs.PostDto;
using Blog.Core.Entities;


namespace Blog.Bussiness.Profiles
{
    public class PostMappingProfile : Profile
    {
        public PostMappingProfile()
        {
            CreateMap<PostCreateDto, Post>();
            CreateMap<PostUpdateDto, Post>();
            CreateMap<Post, PostListItemDto>();
            CreateMap<Post, PostDetailsDto>();
        }
    }
}
