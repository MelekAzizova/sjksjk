
using Microsoft.AspNetCore.Identity;


namespace Blog.Core.Entities
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public ICollection<Post>? Post { get; set; }

    }
}
