using Microsoft.AspNetCore.Mvc;
using ShareBook.Exceptions;
using ShareBook.Repositories.Interfaces;
using ShareBook.Services;

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
                return NotFound(ex.Message);
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
                return NotFound(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occured while processing the request");
                throw new NullReferenceException("No data", ex);
            }
        }
    }
}
