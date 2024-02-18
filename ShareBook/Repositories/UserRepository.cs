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

        public async Task<User> GetUserByEmail(string email)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
            return user;
        }
    }
}
