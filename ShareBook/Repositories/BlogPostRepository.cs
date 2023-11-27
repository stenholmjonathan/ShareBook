using Microsoft.EntityFrameworkCore;
using ShareBook.Repositories.Interfaces;
using ShareBookApi.Context;
using ShareBookApi.Models;

namespace ShareBook.Repositories
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly ShareBookContext _dbContext;
        public BlogPostRepository(ShareBookContext dbContext)
        {
            _dbContext = dbContext;
            
        }

        public async Task<IEnumerable<BlogPost>> GetAllBlogPosts()
        {
            return await _dbContext.Posts.ToListAsync();
        }
    }
}
