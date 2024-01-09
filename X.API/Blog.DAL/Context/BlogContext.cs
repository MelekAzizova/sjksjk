using Blog.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Blog.DAL.Context
{
    public class BlogContext : IdentityDbContext
    {
        public BlogContext(DbContextOptions opt) :base(opt)
        {
            
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
      

    }
}
