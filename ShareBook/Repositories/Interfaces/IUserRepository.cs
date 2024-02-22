using ShareBook.Models;
using ShareBookApi.Models;

namespace ShareBook.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUser(string userName);
    }
}
