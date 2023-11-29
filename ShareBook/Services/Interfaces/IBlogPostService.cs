using ShareBookApi.Models;
﻿using Microsoft.AspNetCore.Mvc;
using ShareBookApi.Models;

namespace ShareBook.Repositories.Interfaces
{
    public interface IBlogPostService
    {
        Task<IEnumerable<BlogPost>> GetBlogPostByProfileId(int profileId);
        Task<IEnumerable<BlogPost>> GetAllBlogPosts();
    }
}
