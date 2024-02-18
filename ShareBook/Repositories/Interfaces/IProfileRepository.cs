using ShareBookApi.Models;

namespace ShareBook.Repositories.Interfaces
{
    public interface IProfileRepository
    {
        Task<IEnumerable<Profile>> GetAllProfiles();
        Task<IEnumerable<Profile>> GetProfileById(int profileId);
        Task <string> GetProfilePasswordById(int profileId);
    }
}
