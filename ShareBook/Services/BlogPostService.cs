using ShareBook.Repositories.Interfaces;
using ShareBookApi.Models;

namespace ShareBook.Services
{
    public class BlogPostService : IBlogPostService
    {
        private readonly IBlogPostRepository _blogPostRepository;
        public BlogPostService(IBlogPostRepository blogPostRepository)
        {
            _blogPostRepository = blogPostRepository;    
        }

        public async Task<IEnumerable<BlogPost>> GetBlogPostByProfileId(int profileId)
        {
            return await _blogPostRepository.GetBlogPostByProfileId(profileId);
        }
    }
}
