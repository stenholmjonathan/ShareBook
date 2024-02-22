using Microsoft.AspNetCore.Mvc;
using ShareBook.Models;

namespace ShareBook.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUser(string userName);
    }
}
