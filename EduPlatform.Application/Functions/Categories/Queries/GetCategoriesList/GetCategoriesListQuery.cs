using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduPlatform.Application.Functions.Categories.Queries.GetCategoriesList
{
    public class GetCategoriesListQuery : IRequest<List<CategoryInListViewModel>>
    {
    }
}
