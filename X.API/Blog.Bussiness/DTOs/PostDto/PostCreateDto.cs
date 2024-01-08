using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Bussiness.DTOs.PostDto
{
    public class PostCreateDto
    {
        public string Text { get; set; }
        public int? UserId { get; set; }

    }
}
