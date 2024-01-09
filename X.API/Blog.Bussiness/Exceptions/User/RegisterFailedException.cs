using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Bussiness.Exceptions.User
{
    public class RegisterFailedException : Exception
    {
        public RegisterFailedException() : base("Register failed for some reasons")
        {
        }

        public RegisterFailedException(string? message) : base(message)
        {
        }
    }
}
