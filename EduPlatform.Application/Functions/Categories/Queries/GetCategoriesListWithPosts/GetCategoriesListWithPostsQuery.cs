using EduPlatform.Application.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduPlatform.Application.Functions.Categories.Queries.GetCategoriesListWithPosts
{
    public class GetCategoriesListWithPostsQuery : IRequest<List<CategoryWithPostsInListViewModel>>
    {
        public SearchCategoryOptions SearchCategoryOption { get; set; }
    }
}
