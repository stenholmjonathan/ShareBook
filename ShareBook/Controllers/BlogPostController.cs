using Microsoft.AspNetCore.Mvc;
using ShareBook.Exceptions;
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

        public BlogPostController
            (ILogger<BlogPostController> logger,
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
            catch (BlogPostNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occured while processing the request");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet]
        [Route("GetAllBlogPosts")]
        public async Task<IActionResult> GetAllBlogPosts()
        {
            try
            {
                var posts = await _blogPostService.GetAllBlogPosts();
                return Ok(posts);
            }
            catch (BlogPostNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occured while processing the request");
                throw new NullReferenceException("No data", ex);
            }
        }
    }
}