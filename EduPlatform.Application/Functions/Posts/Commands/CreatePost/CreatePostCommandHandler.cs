using AutoMapper;
using EduPlatform.Application.Contracts.Persistance;
using EduPlatform.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EduPlatform.Application.Functions.Posts.Commands.CreatePost
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, CreatePostCommandResponse>
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public CreatePostCommandHandler(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        public async Task<CreatePostCommandResponse> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreatePostCommandValidator(_postRepository);
            var validatorResult = await validator.ValidateAsync(request);

            if(!validatorResult.IsValid)
                return new CreatePostCommandResponse(validatorResult);

            var post = _mapper.Map<Post>(request);
            post = await _postRepository.AddAsync(post);

            return new CreatePostCommandResponse(post.Id);
        }
    }
}
