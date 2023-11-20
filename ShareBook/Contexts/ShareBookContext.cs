using Microsoft.EntityFrameworkCore;
using ShareBookApi.Models;

namespace ShareBookApi.Context
{
    public class ShareBookContext : DbContext
    {
        public ShareBookContext(DbContextOptions<ShareBookContext> options) : base(options) { }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<BlogPost> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profile>().HasData(
                new Profile
                {
                    Id = 1,
                    Description = "Mitt namn är Jonathan",
                    Name = "Jonathan",
                },
                new Profile
                {
                    Id = 2,
                    Description = "Mitt namn är Johan",
                    Name = "Johan",
                }
            );

            modelBuilder.Entity<BlogPost>().HasData(
                new BlogPost
                {
                    Id = 1,
                    Message = "hej",
                    Subject = "min första post",
                    ProfileId = 1
                },
                new BlogPost
                {
                    Id = 2,
                    Message = "hej",
                    Subject = "min andra post",
                    ProfileId = 1
                },
                new BlogPost
                {
                    Id = 3,
                    Message = "hej",
                    Subject = "min tredje post",
                    ProfileId = 1
                },
                new BlogPost
                {
                    Id = 4,
                    Message = "hej hej",
                    Subject = "min allra första post",
                    ProfileId = 2
                },
                new BlogPost
                {
                    Id = 5,
                    Message = "hej svej",
                    Subject = "min trökiga andra post",
                    ProfileId = 2
                }
            );
        }
    }
}
