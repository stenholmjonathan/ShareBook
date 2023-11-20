using ShareBook.Repositories.Interfaces;
using ShareBookApi.Models;

namespace ShareBook.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IProfileRepository _profileRepository;
        public ProfileService(IProfileRepository profileRepository)
        {
            _profileRepository = profileRepository;        
        }

        public async Task<IEnumerable<Profile>> GetAllProfiles()
        {
            return _profileRepository.GetAllProfiles();
        }
    }
}
