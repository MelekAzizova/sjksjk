using Blog.Bussiness.DTOs.AuthDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Bussiness.Services.İnterfaces
{
    public interface IUserServices
    {

        public Task RegisterAsync(RegisterDTO dto);
    }
}
