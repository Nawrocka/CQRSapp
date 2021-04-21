using System;
using System.Collections.Generic;
using System.Text;

namespace EduPlatform.Application.Functions.Categories.Queries.GetCategoriesListWithPosts
{
    public class CategoryWithPostsInListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public List<CategoryPostDto> Posts { get; set; }
    }
}
