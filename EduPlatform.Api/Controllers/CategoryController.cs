using EduPlatform.Application.Common;
using EduPlatform.Application.Functions.Categories.Commands.CreateCategory;
using EduPlatform.Application.Functions.Categories.Queries.GetCategoriesList;
using EduPlatform.Application.Functions.Categories.Queries.GetCategoriesListWithPosts;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduPlatform.Api.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class CategoryController: Controller
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name ="GetAllCategories")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<CategoryInListViewModel>> GetAllCategories()
        {
            var result = await _mediator.Send(new GetCategoriesListQuery());
            return Ok(result);
        }

        [HttpGet("allwithposts", Name = "GetCategoriesWithPosts")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<CategoryWithPostsInListViewModel>>> GetCategoriesWithPosts(SearchCategoryOptions searchCategoryOption)
        {
            var getCategoriesListWithPostsQuery = new GetCategoriesListWithPostsQuery()
            { SearchCategoryOption = searchCategoryOption };

            var result = await _mediator.Send(getCategoriesListWithPostsQuery);

            return Ok(result);
        }

        [HttpPost(Name ="AddCategory")]

        public async Task<ActionResult<CreateCategoryCommandResponse>> Create([FromBody] CreateCategoryCommand createCategoryCommand)
        {
            var response = await _mediator.Send(createCategoryCommand);
            return Ok(response);            
        }
    }
}
