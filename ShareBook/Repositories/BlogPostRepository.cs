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
                //throw new ArgumentOutOfRangeException(profileId.ToString());
                throw new ArgumentOutOfRangeException("The param: " + nameof(profileId) + " is not valid. The invalid value is: " + profileId.ToString()); // format string
            }

            var result = await _context.Posts.Where(x => x.ProfileId == profileId).ToListAsync();

            if (!result.Any())
            {
                throw new BlogPostNotFoundException("The blog post was not found");
            }
            
            return result;
        }

        public async Task<IEnumerable<BlogPost>> GetAllBlogPosts()
        {
            var result = await _context.Posts.ToListAsync();

            if (!result.Any())
            {
                throw new BlogPostNotFoundException("No blog posts were found");
            }

            return result;
        }
    }
}
