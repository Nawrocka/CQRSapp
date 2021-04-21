using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduPlatform.Application.Functions.Posts.Queries.GetPostsList
{
    public class GetPostsListQuery: IRequest<List<PostInListViewModel>>
    {
    }
}
