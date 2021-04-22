using EduPlatform.Application.Responses;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduPlatform.Application.Functions.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommandResponse : BaseResponse
    {
        public int? CategoryId { get; set; }

        public CreateCategoryCommandResponse()
            :base()
        { }

        public CreateCategoryCommandResponse(string message)
            : base(message)
        { }

        public CreateCategoryCommandResponse(string message, bool success)
            :base(message, success)
        { }

        public CreateCategoryCommandResponse(ValidationResult validationResult)
            :base(validationResult)
        { }

        public CreateCategoryCommandResponse(int id)
        {
            CategoryId = id;
        }
    }
}
