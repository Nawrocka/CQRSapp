using EduPlatform.Application.Contracts.Persistance;
using EduPlatform.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

using System.Threading.Tasks;

namespace EduPlatform.Persistence.EF.Repositories
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public PostRepository(EduPlatformContext dbContext): base(dbContext)
        {
        }

        public Task<bool> IsTitleAdnAuthorAlreadyExist(string title, string author)
        {
            var matches = _dbContext.Posts
                .Any(p => p.Title.Equals(title) && p.Author.Equals(author));

            return Task.FromResult(matches);
        }
    }
}
