using ShareBookApi.Models;

namespace ShareBook.Repositories.Interfaces
{
    public interface IProfileRepository
    {
        IEnumerable<Profile> GetAllProfiles();
    }
}
