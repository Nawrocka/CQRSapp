using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduPlatform.Application.Functions.Posts.Commands.DeletePost
{
    public class DeletePostCommand : IRequest
    {
        public int Id { get; set; }
    }
}
