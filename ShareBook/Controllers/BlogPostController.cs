using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using ShareBook.Exceptions;
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
            try
            {
                var posts = await _blogPostService.GetAllBlogPosts();
                return Ok(posts);
            }
            catch (BlogPostNotFoundException ex)
            {
                _logger.LogError(ex, "No blog post was found");
                return NotFound(ex.Message);
            }
            catch (SqlException ex)
            {
                _logger.LogError(ex, "SQL Server, the server was not found or accessible");
                return StatusCode(500, ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occured while processing the request");
                return StatusCode(500, "Internal server error");
            }
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
                _logger.LogError(ex, "No blog post was found.");
                return NotFound(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                _logger.LogError(ex, "Input out of range.");
                return BadRequest(ex.Message);
            }
            catch (SqlException ex)
            {
                _logger.LogError(ex, "SQL Server, the server was not found or accessible");
                return StatusCode(500, ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occured while processing the request.");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}