using Blog.Bussiness.DTOs.PostDto;
using Blog.Bussiness.Repositories.Interfaces;
using Blog.Bussiness.Services.İnterfaces;
using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Bussiness.Services.İmplement
{
    public class PostService : IPostService
    {
        public PostService(IPostRepostory repo)
        {
            _repo = repo;
        }

        IPostRepostory _repo { get;}
        public Task CreateAsync(PostCreateDto Dto)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PostListItemDto> GetAll()
        => _repo.GetAll().Select(s=>new PostListItemDto
            {
                Id = s.Id,
                
                Text = s.Text
            });
       

        public Task<PostDetailsDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
