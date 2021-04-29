using AutoMapper;
using EduPlatform.Application.Contracts.Persistance;
using EduPlatform.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EduPlatform.Application.Functions.Posts.Commands.DeletePost
{
    public class DeletePostCommandHandler : IRequestHandler<DeletePostCommand>
    {
        private readonly IAsyncRepository<Post> _postRepository;

        public DeletePostCommandHandler(IAsyncRepository<Post> postRepository)
        {
            _postRepository = postRepository;
        }
        public async Task<Unit> Handle(DeletePostCommand request, CancellationToken cancellationToken)
        {
            var post =await _postRepository.GetByIdAsync(request.Id);

            await _postRepository.DeleteAsync(post);

            return Unit.Value;
        }
    } 
}
