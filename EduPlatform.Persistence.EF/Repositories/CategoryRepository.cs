using EduPlatform.Application.Common;
using EduPlatform.Application.Contracts.Persistance;
using EduPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlatform.Persistence.EF.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public Task<Category> AddAsync(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Category>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetCategoriesWithPosts(SearchCategoryOptions searchCategoryOption)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsNameAlreadyExist(string name)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
