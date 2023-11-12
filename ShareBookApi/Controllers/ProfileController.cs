using Microsoft.AspNetCore.Mvc;
using ShareBookApi.Context;
using ShareBookApi.Models;

namespace ShareBookApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly ILogger<ProfileController> _logger;

        public ProfileController(ILogger<ProfileController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IActionResult> Get()
        {
            using (var ctx = new ShareBookContext())
            {
                var post = new Post()
                {
                    Message = "test",
                    Subject = "test"
                };

                var profile = new Profile()
                {
                    Description = "test",
                    Name = "Johan"
                };

                profile.Posts.Add(post);
                post.Profile = profile;

                ctx.Profiles.Add(profile);
                ctx.Posts.Add(post);
                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}