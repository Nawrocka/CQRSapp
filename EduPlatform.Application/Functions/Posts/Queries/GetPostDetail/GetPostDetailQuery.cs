﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduPlatform.Application.Functions.Posts.Queries.GetPostDetail
{
    class GetPostDetailQuery:IRequest<PostDetailViewModel>
    {
        public int Id { get; set; }
    }
}
