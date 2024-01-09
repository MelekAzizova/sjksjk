using Blog.Bussiness.DTOs.AuthDTOs;
using Blog.Bussiness.Exceptions.Common;
using Blog.Bussiness.Exceptions.User;
using Blog.Bussiness.Services.İnterfaces;
using Blog.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Bussiness.Services.İmplement
{
    public class AuthService : IAuthServices
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
        //    AppUser? user = null;
        //    if (dto.UsernameOrEmail.Contains("@"))
        //    {
        //        user = await _userManager.FindByEmailAsync(dto.UsernameOrEmail);
        //    }
        //    else
        //    {
        //        user = await _userManager.FindByNameAsync(dto.UsernameOrEmail);
        //    }
        //    if (user == null) throw new UsernameOrPasswordWrongException();
        //    var result=await _userManager.CheckPasswordAsync(user,dto.Password);
        //    if (!result) 
        //    {
        //        throw new UsernameOrPasswordWrongException();
        //    }
        //    List<Claim> claims = new List<Claim>();
        //    claims.Add(new Claim(ClaimTypes.Name,user.UserName));
        //    claims.Add(new Claim(ClaimTypes.NameIdentifier,user.Id));
        //    claims.Add(new Claim("Test", user.Birthday.ToString()));
        //    SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("51485d7b-bc9b-4a83-ba21-25d285cc9236"));
        //    SigningCredentials cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
        //    JwtSecurityToken jwt = new JwtSecurityToken("https://localhost:7033/",
        //        "https://localhost:7033/api",
        //        claims,
        //        DateTime.UtcNow,
        //        DateTime.UtcNow.AddHours(24)
        //        ); 
        //    JwtSecurityTokenHandler jwtHandler= new JwtSecurityTokenHandler();
        //    var token=jwtHandler.WriteToken(jwt);




        //}
    }
}
