using Microsoft.AspNetCore.Mvc;
using ShareBook.Repositories.Interfaces;
using ShareBookApi.Models;

namespace ShareBook.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogPostController : ControllerBase
    {
        private readonly ILogger<BlogPostController> _logger;
        private readonly IBlogPostService _blogPostService;

        public BlogPostController(
            ILogger<BlogPostController> logger,
            IBlogPostService blogPostService)
        {
            _logger = logger;
            _blogPostService = blogPostService;
        }

        [HttpGet]
        [Route("GetBlogPostById")]
        public async Task<IActionResult> GetBlogPostByProfileId(int profileId)
        {
            try
            {
                var result = await _blogPostService.GetBlogPostByProfileId(profileId);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }



        }
    }
}
