using Blog.Bussiness.DTOs.AuthDTOs;
using Blog.Bussiness.ExternalServices.Interfaces;
using Blog.Core.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Bussiness.ExternalServices.Implements
{
    public class TokenService : ITokenServices
    {
        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        IConfiguration _configuration { get; }
        public TokenDto CreateToken(AppUser user)
        {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, user.UserName));

            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:SigningKey"]));
            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            DateTime expires = DateTime.UtcNow.AddMinutes(Convert.ToInt32(_configuration.GetSection("Jwt")?["ExpireMin"]));
            JwtSecurityToken jwtSecurity = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                claims,
                DateTime.UtcNow,
                expires,
                credentials);
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();
            string token = jwtHandler.WriteToken(jwtSecurity);
            return new TokenDto
            {
                Expires = expires,
                Token = token
            };
        }
    }
}
