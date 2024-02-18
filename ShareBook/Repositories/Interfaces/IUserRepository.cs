using ShareBook.Models;
using ShareBookApi.Models;

namespace ShareBook.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByEmail(string email); 

    }
}
