using AutoMapper;
using EduPlatform.Application.Contracts.Persistance;
using EduPlatform.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EduPlatform.Application.Functions.Posts.Queries.GetPostDetail
{
    public class GetPostDetailQueryHandler : IRequestHandler<GetPostDetailQuery, PostDetailViewModel>
    {
        private readonly IAsyncRepository<Post> _postRepository;
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Category> _categoryRepository;

        public GetPostDetailQueryHandler(IAsyncRepository<Post> postRepository, IAsyncRepository<Category> categoryRepository, IMapper mapper )
        {
            _mapper = mapper;
            _postRepository = postRepository;
            _categoryRepository = categoryRepository;
        }
        public async Task<PostDetailViewModel> Handle(GetPostDetailQuery request, CancellationToken cancellationToken)
        {                      
            var post = await _postRepository.GetByIdAsync(request.Id);
            
            var postdetail = _mapper.Map<PostDetailViewModel>(post);

            if (post == null)
                return postdetail;

            var category = await _categoryRepository.GetByIdAsync(post.CategoryId);
            postdetail.Category = _mapper.Map<CategoryDto>(category);

            return postdetail;
        }
    }
}
