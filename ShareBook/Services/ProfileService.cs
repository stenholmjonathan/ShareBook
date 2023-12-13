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
            return await _profileRepository.GetAllProfiles();
        }

        public async Task<IEnumerable<Profile>> GetProfileById(int profileId)
        {
            return await _profileRepository.GetProfileById(profileId);
        }
    }
}
