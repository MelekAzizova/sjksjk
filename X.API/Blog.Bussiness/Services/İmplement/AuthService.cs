using Blog.Bussiness.DTOs.AuthDTOs;
using Blog.Bussiness.Services.İnterfaces;
using Blog.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Bussiness.Services.İmplement
{
    public class AuthService : AuthServices
    {
        UserManager<AppUser> _userManager;

        public AuthService(UserManager<AppUser> userManager)
        {
            this._userManager = userManager;
        }

        public Task Login(LoginDto dto)
        {
            throw new NotImplementedException();
        }

        //public async Task Login(LoginDto dto)
        //{
        //    AppUser user = null;
        //    if (dto.UsernameOrEmail.Contains("@"))
        //    {
        //        user=await _userManager.FindByEmailAsync(dto.UsernameOrEmail);  
        //    }
        //    else
        //    {
        //        user=await _userManager.FindByNameAsync(dto.UsernameOrEmail);
        //    }

        //}
    }
}
