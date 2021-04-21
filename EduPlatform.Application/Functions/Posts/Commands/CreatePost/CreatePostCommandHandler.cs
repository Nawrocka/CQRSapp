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
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, int>
    {
        private readonly IWebinarRepository<Post> _postRepository;
        private readonly IMapper _mapper;

        public CreatePostCommandHandler(IWebinarRepository<Post> postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var post = _mapper.Map<Post>(request);
            post = await _postRepository.AddAsync(post);

            return post.Id;
        }
    }
}
