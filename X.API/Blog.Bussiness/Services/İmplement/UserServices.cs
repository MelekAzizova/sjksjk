using AutoMapper;
using Blog.Bussiness.DTOs.AuthDTOs;
using Blog.Bussiness.Exceptions.User;
using Blog.Bussiness.ExternalServices.Interfaces;
using Blog.Bussiness.Services.İnterfaces;
using Blog.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Bussiness.Services.İmplement
{
    public class UserServices : IUserServices
    {
        public UserServices(UserManager<AppUser> userManager, IMapper mapper, ITokenServices tokenServices)
        {
            _userManager = userManager;
            _mapper = mapper;
            _tokenServices = tokenServices;
        }

        UserManager<AppUser> _userManager { get; }
        IMapper _mapper { get; }
        ITokenServices _tokenServices { get; }

        public async Task<TokenDto> LoginAsync(LoginDto dto)
        {
            var user = await _userManager.Users.SingleOrDefaultAsync(x => x.UserName == dto.UsernameOrEmail || x.Email == dto.UsernameOrEmail);
            if (user == null) throw new UsernameOrPasswordWrongException();
            var result = await _userManager.CheckPasswordAsync(user, dto.Password);
            if (!result) throw new UsernameOrPasswordWrongException();
            return _tokenServices.CreateToken(user);
        }

        public async Task RegisterAsync(RegisterDTO dto)
        {
            var user = _mapper.Map<AppUser>(dto);
            var result = await _userManager.CreateAsync(user, dto.Password);
            if (!result.Succeeded)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var item in result.Errors)
                {
                    sb.Append(item.Description + " ");
                }
                throw new NotImplementedException(sb.ToString().TrimEnd());
            }

        }
    }
}
