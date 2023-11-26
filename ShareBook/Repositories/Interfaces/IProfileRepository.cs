using ShareBookApi.Models;

namespace ShareBook.Repositories.Interfaces
{
    public interface IProfileRepository
    {
        Task<IEnumerable<Profile>> GetAllProfiles();
    }
}
