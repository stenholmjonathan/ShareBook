using ShareBook.Models;
using ShareBook.Repositories.Interfaces;
using ShareBook.Services.Interfaces;

namespace ShareBook.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> GetUser(string userName)
        {
            return await _userRepository.GetUser(userName);
        }
    }
}