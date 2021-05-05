using EduPlatform.Application.Functions.Posts.Commands.CreatePost;
using EduPlatform.Application.Functions.Posts.Queries.GetPostsList;
using EduPlatform.Application.Functions.Posts.Queries.GetPostDetail;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using EduPlatform.Application.Functions.Posts.Commands.UpdatePost;
using EduPlatform.Application.Functions.Posts.Commands.DeletePost;

namespace EduPlatform.Api.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class PostController: Controller
    {
        private readonly IMediator _mediator;

        public PostController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name ="AddPost")]
        public async Task<ActionResult<CreatePostCommandResponse>> Create([FromBody] CreatePostCommand createPostCommand)
        {
            var response = await _mediator.Send(createPostCommand);
            return Ok(response);
        }

        [HttpGet(Name ="GetAllPosts")]
        public async Task<ActionResult<PostInListViewModel>> GetAllPosts()
        {
            var result = await _mediator.Send(new GetPostsListQuery());
            return Ok(result);
        }

        [HttpGet("{id}", Name ="GetPostById")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<PostDetailViewModel>> GetPostById(int id)
        {
            var result = await _mediator.Send(new GetPostDetailQuery() { Id = id });
            return Ok(result);
        }

        [HttpPut(Name ="UpdatePost")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdatePostCommand updatePostCommand)
        {
            await _mediator.Send(updatePostCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeletePost")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            await _mediator.Send(new DeletePostCommand() { Id = id });
            return NoContent();
        }



    }
}
