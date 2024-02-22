using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using ShareBook.Exceptions;
using ShareBook.Repositories.Interfaces;
using ShareBook.Services;
using ShareBook.Services.Interfaces;

namespace ShareBook.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController
            (ILogger<UserController> logger,
            IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet]
        [Route("GetUser")]
        public async Task<IActionResult> GetUser(string userName)
        {
            try
            {
                var user = await _userService.GetUser(userName);
                return Ok(user);
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
    }
}
