using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Bussiness.DTOs.AuthDTOs
{
    public class TokenParamsDto
    {
        public AppUser User { get; set; }
        public string Role { get; set; }
    }
}
