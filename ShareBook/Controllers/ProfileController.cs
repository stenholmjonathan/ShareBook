using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using ShareBook.Exceptions;
using ShareBook.Repositories.Interfaces;

namespace ShareBook.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly ILogger<ProfileController> _logger;
        private readonly IProfileService _profileService;

        public ProfileController(
            ILogger<ProfileController> logger,
            IProfileService profileService)
        {
            _logger = logger;
            _profileService = profileService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllProfiles()
        {
            try
            {
                var profiles = await _profileService.GetAllProfiles();
                return Ok(profiles);
            }
            catch (ProfileNotFoundException ex)
            {
                _logger.LogError(ex, "No profile was found");
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
        [Route("GetProfileById")]
        public async Task<IActionResult> GetProfileById(int profileId)
        {
            try
            {
                var profiles = await _profileService.GetProfileById(profileId);
                return Ok(profiles);
            }
            catch (ProfileNotFoundException ex)
            {
                _logger.LogError(ex, "No profile was found.");
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
                _logger.LogError(ex, "An error occured while processing the request");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
