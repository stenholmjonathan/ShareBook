using Microsoft.AspNetCore.Mvc;
using ShareBook.Repositories.Interfaces;

namespace ShareBook.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogPostController : ControllerBase
    {
        private readonly ILogger<BlogPostController> _logger;
        private readonly IBlogPostService _blogPostService;

        public BlogPostController
            (ILogger<BlogPostController> logger,
            IBlogPostService blogPostService)
        {
            _logger = logger;
            _blogPostService = blogPostService;
        }

        [HttpGet]
        [Route("GetAllBlogPosts")]
        public async Task<IActionResult> GetAllBlogPosts()
        {
            var posts = await _blogPostService.GetAllBlogPosts();
            return Ok(posts);
        }
    }
}
