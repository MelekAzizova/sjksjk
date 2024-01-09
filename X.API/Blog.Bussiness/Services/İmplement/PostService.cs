using AutoMapper;
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
        public PostService(IPostRepostory repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        IMapper _mapper { get; }
        IPostRepostory _repo { get;}
        public async Task CreateAsync(PostCreateDto dto)
        {
            await _repo.CreateAscyn(_mapper.Map<Post>(dto));
            await _repo.SaveAscyn();
        }

        public IQueryable<PostListItemDto> GetAll()
        {
            return _mapper.Map<IQueryable<PostListItemDto>>(_repo.GetAll());
        }

        public Task<PostDetailsDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveAsync(int id)
        {
            if (id <= 0) throw new ArgumentException();
            var data = await _repo.GetByIdAsync(id, false);
            if (data == null) throw new ArgumentNullException();
            _repo.Remove(data);
            await _repo.SaveAscyn();
        }
    }
}
