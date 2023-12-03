using Microsoft.EntityFrameworkCore;
using ShareBook.Exceptions;
using ShareBook.Repositories.Interfaces;
using ShareBookApi.Context;
using ShareBookApi.Models;

namespace ShareBook.Repositories
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly ShareBookContext _context;
        public BlogPostRepository(ShareBookContext context)
        {
            _context = context;      
        }
    
        public async Task<IEnumerable<BlogPost>> GetBlogPostByProfileId(int profileId)
        {
            if (profileId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(profileId));
            }

            var result = await _context.Posts.Where(x => x.ProfileId == profileId).ToListAsync();

            if (!result.Any())
            {
                throw new BlogPostNotFoundException("No blogposts were found");
            }
            

            return result;
        }

        public async Task<IEnumerable<BlogPost>> GetAllBlogPosts()
        {
            return await _context.Posts.ToListAsync();
        }
    }
}
