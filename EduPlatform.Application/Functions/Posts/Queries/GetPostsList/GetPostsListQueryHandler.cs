using AutoMapper;
using EduPlatform.Application.Contracts.Persistance;
using EduPlatform.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EduPlatform.Application.Functions.Posts.Queries.GetPostsList
{
    public class GetPostsListQueryHandler : IRequestHandler<GetPostsListQuery, List<PostInListViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly IWebinarRepository<Post> _postRepository;

        public GetPostsListQueryHandler(IMapper mapper, IWebinarRepository<Post> postRepository)
        {
            _mapper = mapper;
            _postRepository = postRepository;
        }
        public async Task<List<PostInListViewModel>> Handle(GetPostsListQuery request, CancellationToken cancellationToken)
        {
            var posts = await _postRepository.GetAllAsync();
            var orderedPosts = posts.OrderBy(x => x.Date);

            return _mapper.Map<List<PostInListViewModel>>(orderedPosts);
        }
    }
}
