using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Bussiness.Exceptions.User
{
    public class UsernameOrPasswordWrongException : Exception
    {
        public UsernameOrPasswordWrongException() :base("Username or Password wrong!")
        {
        }

        public UsernameOrPasswordWrongException(string? message) : base(message)
        {
        }
    }
}
