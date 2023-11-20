using ShareBookApi.Models;

namespace ShareBook.Repositories.Interfaces
{
    public interface IProfileService
    {
        Task<IEnumerable<Profile>> GetAllProfiles();
    }
}
