using ShareBook.Models;
using ShareBook.Repositories;
using ShareBook.Repositories.Interfaces;
using ShareBook.Services.Interfaces;
using ShareBookApi.Models;

namespace ShareBook.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await _userRepository.GetUserByEmail(email);
        }
    }
}
