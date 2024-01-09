using Blog.Bussiness.DTOs.AuthDTOs;
using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Bussiness.ExternalServices.Interfaces
{
    public interface ITokenServices
    {
        TokenDto CreateToken(AppUser user);
    }
}
