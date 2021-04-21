﻿using AutoMapper;
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
    class GetPostDetailQueryHandler : IRequestHandler<GetPostDetailQuery, PostDetailViewModel>
    {
        private readonly IWebinarRepository<Post> _postRepository;
        private readonly IMapper _mapper;
        private readonly IWebinarRepository<Category> _categoryRepository;

        public GetPostDetailQueryHandler(IWebinarRepository<Post> postRepository, IWebinarRepository<Category> categoryRepository, IMapper mapper )
        {
            _mapper = mapper;
            _postRepository = postRepository;
            _categoryRepository = categoryRepository;
        }
        public async Task<PostDetailViewModel> Handle(GetPostDetailQuery request, CancellationToken cancellationToken)
        {
            var post = await _postRepository.GetByIdAsync(request.Id);
            var postdetail = _mapper.Map<PostDetailViewModel>(post);

            var category = await _categoryRepository.GetByIdAsync(post.CategoryId);
            postdetail.Category = _mapper.Map<CategoryDto>(category);

            return postdetail;
        }
    }
}