using ShareBookApi.Models;

namespace ShareBook.Repositories.Interfaces
{
    public interface IBlogPostRepository
    {
        Task<IEnumerable<BlogPost>> GetBlogPostByProfileId(int profileId);
    }
}
