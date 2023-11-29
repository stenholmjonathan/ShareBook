using Microsoft.AspNetCore.Mvc;
using ShareBookApi.Models;

namespace ShareBook.Repositories.Interfaces
{
    public interface IProfileService
    {
        Task<IEnumerable<Profile>> GetAllProfiles();
    }
}
