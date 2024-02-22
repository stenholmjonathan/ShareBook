using Microsoft.EntityFrameworkCore;
using ShareBook.Exceptions;
using ShareBook.Models;
using ShareBook.Repositories.Interfaces;
using ShareBookApi.Context;
using ShareBookApi.Models;

namespace ShareBook.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ShareBookContext _context;
        public UserRepository(ShareBookContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetUser(string userName)
        {
            var result = await _context.Users.ToListAsync();
            return result;
        }
    }
}
