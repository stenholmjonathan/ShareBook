using Microsoft.EntityFrameworkCore;
using ShareBookApi.Models;

namespace ShareBookApi.Context
{
    public class ShareBookContext : DbContext
    {
        public ShareBookContext()
        {
                
        }

        public ShareBookContext(DbContextOptions<ShareBookContext> options) : base(options) { }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
