using AutoMapper;
using EduPlatform.Application.Contracts.Persistance;
using EduPlatform.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EduPlatform.Application.Functions.Categories.Queries.GetCategoriesListWithPosts
{
    public class GetCategoriesListWithPostsQueryHandler : IRequestHandler<GetCategoriesListWithPostsQuery, List<CategoryWithPostsInListViewModel>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetCategoriesListWithPostsQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<List<CategoryWithPostsInListViewModel>> Handle(GetCategoriesListWithPostsQuery request, CancellationToken cancellationToken)
        {
            var categoriesWithPosts = await _categoryRepository.GetCategoriesWithPosts(request.SearchCategoryOption);

            return _mapper.Map<List<CategoryWithPostsInListViewModel>>(categoriesWithPosts);
        }
    }
}
