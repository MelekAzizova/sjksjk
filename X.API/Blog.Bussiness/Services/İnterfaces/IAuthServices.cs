using Blog.Bussiness.DTOs.AuthDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Bussiness.Services.İnterfaces
{
    public interface AuthServices
    {
        Task Login(LoginDto dto);
    }
}
