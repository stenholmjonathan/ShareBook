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
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(
            ILogger<UserController> logger,
            IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet]
        [Route("GetUserByEmail")]
        public async Task<IActionResult> GetUserByEmail(string email)
        {
            try
            {
                var result = await _userService.GetUserByEmail(email);
                return Ok(result);
            }
            catch (UserNotFoundException ex)
            {
                _logger.LogError(ex, "No user was found.");
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
