using Blog.Bussiness.DTOs.PostDto;
using Blog.Bussiness.Repositories.Interfaces;
using Blog.Bussiness.Services.İnterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        public PostController(IPostService service)
        {
            _service = service;
        }

        IPostService _service { get; }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Post(PostCreateDto dto)
        {
            await _service.CreateAsync(dto);
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
