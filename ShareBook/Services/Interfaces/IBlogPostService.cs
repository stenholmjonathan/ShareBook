using Microsoft.AspNetCore.Mvc;
using ShareBookApi.Models;

namespace ShareBook.Repositories.Interfaces
{
    public interface IBlogPostService
    {
        Task<IEnumerable<BlogPost>> GetAllBlogPosts();
    }
}
