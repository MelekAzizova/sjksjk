using Blog.Bussiness.DTOs.PostDto;
using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Bussiness.Services.İnterfaces
{
    public interface IPostService
    {
        public IQueryable<PostListItemDto> GetAll();
        public Task<PostDetailsDto> GetByIdAsync(int id);
        public Task CreateAsync(PostCreateDto Dto);
        public Task RemoveAsync(int id);
    }
}
