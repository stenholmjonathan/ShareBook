using ShareBookApi.Models;

namespace ShareBook.Repositories.Interfaces
{
    public interface IBlogPostService
    {
        Task<IEnumerable<BlogPost>> GetAllBlogPosts();
        Task<IEnumerable<BlogPost>> GetBlogPostByProfileId(int profileId);
    }
}
