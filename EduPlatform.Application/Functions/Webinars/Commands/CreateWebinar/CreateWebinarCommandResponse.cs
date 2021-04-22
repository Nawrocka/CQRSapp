using EduPlatform.Application.Responses;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduPlatform.Application.Functions.Webinars.Commands.CreateWebinar
{
    public class CreateWebinarCommandResponse : BaseResponse
    {
        public int? WebinarId { get; set; }

        public CreateWebinarCommandResponse()
            :base()
        { }

        public CreateWebinarCommandResponse(string message)
            : base(message)
        { }

        public CreateWebinarCommandResponse(string message, bool success)
            : base(message, success)
        { }

        public CreateWebinarCommandResponse(ValidationResult validationResult)
            : base(validationResult)
        { }

        public CreateWebinarCommandResponse(int id)
        {
            WebinarId = id;
        }
    }
}
