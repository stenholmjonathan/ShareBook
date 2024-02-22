using Microsoft.EntityFrameworkCore;
using ShareBook.Models;
using ShareBookApi.Models;

namespace ShareBookApi.Context
{
    public class ShareBookContext : DbContext
    {
        public ShareBookContext(DbContextOptions<ShareBookContext> options) : base(options) { }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<BlogPost> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    UserName = "Jony",
                    Password = "1234",
                }
            );

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
                    Message = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    Subject = "The standard Lorem Ipsum passage, used since the 1500s",
                    ProfileId = 1
                },
                new BlogPost
                {
                    Id = 2,
                    Message = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",
                    Subject = "Section 1.10.32 of \"de Finibus Bonorum et Malorum\"",
                    ProfileId = 1
                },
                new BlogPost
                {
                    Id = 3,
                    Message = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet.",
                    Subject = "1914 translation by H. Rackham",
                    ProfileId = 1
                },
                new BlogPost
                {
                    Id = 4,
                    Message = "The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form,",
                    Subject = "Section 1.10.33 of \"de Finibus Bonorum et Malorum\"",
                    ProfileId = 1
                },
                new BlogPost
                {
                    Id = 5,
                    Message = "There are many variations of passages of Lorem Ipsum available.",
                    Subject = "1914 translation by H. Rackham",
                    ProfileId = 1
                },
                new BlogPost
                {
                    Id = 6,
                    Message = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old.",
                    Subject = "Donate",
                    ProfileId = 1
                },
                new BlogPost
                {
                    Id = 7,
                    Message = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary,",
                    Subject = "1500s",
                    ProfileId = 1
                },
                new BlogPost
                {
                    Id = 8,
                    Message = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.",
                    Subject = "Written by Cicero in 45 BC",
                    ProfileId = 1
                },
                new BlogPost
                {
                    Id = 9,
                    Message = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself.",
                    Subject = "There is a set of mock banners available",
                    ProfileId = 1
                },
                new BlogPost
                {
                    Id = 10,
                    Message = "hej hej",
                    Subject = "min allra första post",
                    ProfileId = 2
                },
                new BlogPost
                {
                    Id = 11,
                    Message = "hej svej",
                    Subject = "min trökiga andra post",
                    ProfileId = 2
                }
            );
        }
    }
}
