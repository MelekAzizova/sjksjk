using Blog.Bussiness.DTOs.AuthDTOs;
using Blog.Core.Entities;

namespace Blog.Bussiness.ExternalServices.Interfaces
{
    public interface ITokenServices
    {
        TokenDto CreateToken(TokenParamsDto dto);
    }
}
