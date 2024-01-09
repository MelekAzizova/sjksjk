using Blog.Bussiness.DTOs.AuthDTOs;
using Blog.Bussiness.ExternalServices.Interfaces;
using Blog.Bussiness.Services.İnterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthsController : ControllerBase
    {
        public AuthsController(IUserServices userServices, IEmailServices emailServices)
        {
            _userServices = userServices;
            _emailServices = emailServices;
        }

        IUserServices _userServices { get; }
        IEmailServices _emailServices { get; }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterDTO dto)
        {
            await _userServices.RegisterAsync(dto);
            _emailServices.Send(dto.Email, "Twitt", "Welcome to Twitt");
            return Ok();
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            return Ok(await _userServices.LoginAsync(dto));
        }

    }
}
