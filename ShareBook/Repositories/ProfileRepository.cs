using Microsoft.EntityFrameworkCore;
using ShareBook.Exceptions;
using ShareBook.Repositories.Interfaces;
using ShareBookApi.Context;
using ShareBookApi.Models;

namespace ShareBook.Repositories
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly ShareBookContext _context;

        public ProfileRepository(ShareBookContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Profile>> GetAllProfiles()
        {
            var result = await _context.Profiles.ToListAsync();

            if (!result.Any())
            {
                throw new ProfileNotFoundException("No profiles were found");
            }

            return result;
        }

        public async Task<IEnumerable<Profile>> GetProfileById(int profileId)
        {
            if (profileId < 0)
            {
                throw new ArgumentOutOfRangeException($"The param: {nameof(profileId)} is not valid. The invalid value is: {profileId}");
            }

            var result = await _context.Profiles.Where(x => x.Id == profileId).ToListAsync();

            if (!result.Any())
            {
                throw new ProfileNotFoundException("The profile was not found");
            }

            return result;
        }

        public async Task<string> GetProfilePasswordById(int profileId)
        {
            if (profileId < 0)
            {
                throw new ArgumentOutOfRangeException($"The param: {nameof(profileId)} is not valid. The invalid value is: {profileId}");
            }

            var profile = await _context.Profiles.FirstOrDefaultAsync(x => x.Id == profileId);
            string password = profile.Password;

            if (profile != null)
            {
                return profile.Password;
            } else
            {
                return null;
            }
        }
    }
}

