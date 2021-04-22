using EduPlatform.Application.Common;
using EduPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EduPlatform.Application.Contracts.Persistance
{
    public interface ICategoryRepository: IWebinarRepository<Category>
    {
        public Task<List<Category>> GetCategoriesWithPosts(SearchCategoryOptions searchCategoryOption);

        public Task<bool> IsNameAlreadyExist(string name);
    }
}
