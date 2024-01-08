using Blog.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.Context
{
    public class BlogContext:DbContext

    {
        public BlogContext(DbContextOptions opt) :base(opt)
        {
            
        }
        public DbSet<Post> Posts { get; set; }
       
    }
}
