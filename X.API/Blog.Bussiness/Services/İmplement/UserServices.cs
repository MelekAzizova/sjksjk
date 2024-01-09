using AutoMapper;
using Blog.Bussiness.DTOs.AuthDTOs;
using Blog.Bussiness.Services.İnterfaces;
using Blog.Core.Entities;
using Microsoft.AspNetCore.Identity;
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
        public UserServices(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        UserManager<AppUser> _userManager { get; }
        IMapper _mapper { get; }

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
