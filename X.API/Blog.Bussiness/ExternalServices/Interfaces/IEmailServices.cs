﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Bussiness.ExternalServices.Interfaces
{
    public interface IEmailServices
    {
        void Send(string toMail, string header, string body, bool isHtml = true);
    }
}
