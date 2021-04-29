using EduPlatform.Application.Contracts.Persistance;
using EduPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlatform.Persistence.EF.Repositories
{
    public class PostRepository : IPostRepository
    {
        public Task<Post> AddAsync(Post entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Post entity)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Post>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsTitleAdnAuthorAlreadyExist(string title, string author)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Post entity)
        {
            throw new NotImplementedException();
        }
    }
}
