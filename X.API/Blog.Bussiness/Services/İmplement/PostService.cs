using AutoMapper;
using Blog.Bussiness.DTOs.PostDto;
using Blog.Bussiness.Exceptions.Common;
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

        public async Task<PostDetailsDto> GetByIdAsync(int id)
        {
            if (id <= 0) throw new ArgumentException();
            var data = await _repo.GetByIdAsync(id);
            if (data == null) throw new NotFoundException<Post>();
            return _mapper.Map<PostDetailsDto>(data);
        }

        public async Task RemoveAsync(int id)
        {
            if (id <= 0) throw new ArgumentException();
            var data = await _repo.GetByIdAsync(id, false);
            if (data == null) throw new NotFoundException<Post>();

            _repo.Remove(data);
            await _repo.SaveAscyn();
        }

    }
}
