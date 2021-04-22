using EduPlatform.Application.Responses;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduPlatform.Application.Functions.Posts.Commands.CreatePost
{
    public class CreatePostCommandResponse : BaseResponse
    {
        public int? PostId { get; set; }

        public CreatePostCommandResponse() 
            : base()
        { }

        public CreatePostCommandResponse(string message) 
            : base(message)
        { }

        public CreatePostCommandResponse(string message, bool success)
            : base(message, success)
        { }

        public CreatePostCommandResponse(ValidationResult validationResult)
            : base(validationResult)
        { }

        public CreatePostCommandResponse(int postId)
        {
            PostId = postId;
        }
    }
}
