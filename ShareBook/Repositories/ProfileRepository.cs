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
    }
}

