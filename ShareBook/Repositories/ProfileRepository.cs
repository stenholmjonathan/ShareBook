using Microsoft.EntityFrameworkCore;
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
            return _context.Profiles;
        }

        public async Task<IEnumerable<Profile>> GetProfileById(int profileId)
        {
            return await _context.Profiles.Where(x => x.Id == profileId).ToListAsync();
        }
    }
}

