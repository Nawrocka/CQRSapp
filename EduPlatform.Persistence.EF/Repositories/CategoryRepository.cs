using EduPlatform.Application.Common;
using EduPlatform.Application.Contracts.Persistance;
using EduPlatform.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlatform.Persistence.EF.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(EduPlatformContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Category>> GetCategoriesWithPosts(SearchCategoryOptions searchCategoryOption)
        {
            var allCategories = await _dbContext.Categories.Include(p => p.Posts).ToListAsync();

            switch (searchCategoryOption)
            {
                case SearchCategoryOptions.All:
                    return allCategories;
                case SearchCategoryOptions.FirstBestThisMonth:
                    {
                        DateTime d = DateTime.Now;
                        allCategories = allCategories.Where(p => p.Posts.Any(p => (p.Date.Month == d.Month && p.Date.Year == d.Date.Year))).ToList();

                        //for every category I'm creating a list and add one best post (list because this is the type where category keeps posts in its property)
                        return GetCategoriesWithTheBestPost(allCategories);
                    }                    
                case SearchCategoryOptions.FirstBestThisTime:
                    {
                        return GetCategoriesWithTheBestPost(allCategories);
                    }
                default:
                    return null;
            }

        }

        public Task<bool> IsNameAlreadyExist(string name)
        {
            var search = _dbContext.Categories.Any(c => c.Name.Equals(name));

            return Task.FromResult(search);
        }

        private static List<Category> GetCategoriesWithTheBestPost(List<Category> allCategories)
        {
            foreach (var c in allCategories)
            {
                Post withMaxRate = null;
                
                if (c.Posts.Count != 0)
                {
                    withMaxRate = c.Posts.Aggregate<Post>((r1, r2) => r1.Rate > r2.Rate ? r1 : r2);
                }

                c.Posts = new List<Post>();

                if (withMaxRate != null)
                    c.Posts.Add(withMaxRate);
            }
            return allCategories;
        }
    }
}
