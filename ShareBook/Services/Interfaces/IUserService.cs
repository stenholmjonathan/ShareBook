using ShareBook.Models;
using ShareBookApi.Models;

namespace ShareBook.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUserByEmail(string email);
    }
}
