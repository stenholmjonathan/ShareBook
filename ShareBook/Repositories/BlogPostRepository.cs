using Microsoft.EntityFrameworkCore;
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
            var result = await _context.Posts.Where(x => x.ProfileId == profileId).ToListAsync();
            return result;
        }

    }
}
