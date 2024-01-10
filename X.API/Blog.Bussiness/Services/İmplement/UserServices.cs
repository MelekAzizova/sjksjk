using AutoMapper;
using Blog.Bussiness.DTOs.AuthDTOs;
using Blog.Bussiness.Exceptions.User;
using Blog.Bussiness.ExternalServices.Interfaces;
using Blog.Bussiness.Services.İnterfaces;
using Blog.Core.Entities;
using Blog.Core.Enums;
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
        public UserServices(UserManager<AppUser> userManager, IMapper mapper, ITokenServices tokenServices, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _mapper = mapper;
            _tokenServices = tokenServices;
            _roleManager = roleManager;
        }

        UserManager<AppUser> _userManager { get; }
        IMapper _mapper { get; }
        ITokenServices _tokenServices { get; }
        RoleManager<IdentityRole> _roleManager { get; }


        public async Task<TokenDto> LoginAsync(LoginDto dto)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(x => x.UserName == dto.UsernameOrEmail || x.Email == dto.UsernameOrEmail);
            if (user == null) throw new UsernameOrPasswordWrongException();
            var result = await _userManager.CheckPasswordAsync(user, dto.Password);
            if (!result) throw new UsernameOrPasswordWrongException();
            string role = (await _userManager.GetRolesAsync(user)).First();
            return _tokenServices.CreateToken(new TokenParamsDto
            {
                Role=role,
                User=user
            });
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
            var roleResult= await _userManager.AddToRoleAsync(user, nameof(Roles.Member));
            if (!roleResult.Succeeded)
            {
                StringBuilder sb = new();
                foreach (var item in result.Errors)
                {
                    sb.Append(item.Description + " ");
                }
                throw new NotImplementedException(sb.ToString().TrimEnd());
            }
        }
    }
}
