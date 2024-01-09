﻿
using Blog.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Bussiness.Exceptions.Common
{
    public class NotFoundException<T> : Exception where T : class
    {
        public NotFoundException() : base(typeof(T).Name + " not found.")
        {
        }

        public NotFoundException(string? message) : base(message)
        {
        }
    }
}
