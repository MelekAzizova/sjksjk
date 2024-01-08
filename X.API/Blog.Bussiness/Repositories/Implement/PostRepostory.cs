using Blog.Bussiness.Repositories.Interfaces;
using Blog.Core.Entities;
using Blog.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Bussiness.Repositories.Implement
{
    public class PostRepostory : GenericRepostory<Post>, IPostRepostory
    {
        public PostRepostory(BlogContext db) : base(db)
        {
        }
    }
}
