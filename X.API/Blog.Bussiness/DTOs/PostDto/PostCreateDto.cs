using FluentValidation;
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
       

    }
    public class PostCreateDTOValidator : AbstractValidator<PostCreateDto>
    {
        public PostCreateDTOValidator()
        {
            RuleFor(x => x.Text).NotEmpty().MaximumLength(1014);
        }
    }
}
