using ShareBook.Repositories.Interfaces;
using ShareBookApi.Context;
using ShareBookApi.Models;

namespace ShareBook.Repositories
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly ShareBookContext _context;
        public IEnumerable<Profile> GetAllProfiles()
        {
            return _context.Profiles;
        }
    }
}
