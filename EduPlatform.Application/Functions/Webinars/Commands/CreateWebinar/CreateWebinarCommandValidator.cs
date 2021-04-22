using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduPlatform.Application.Functions.Webinars.Commands.CreateWebinar
{
    public class CreateWebinarCommandValidator : AbstractValidator<CreateWebinarCommand>
    {
        public CreateWebinarCommandValidator()
        {
            RuleFor(w => w.Date)
                .NotEmpty()
                .WithMessage("{PropertyName} is required")
                .GreaterThan(DateTime.Now.AddDays(-1)); //from existing day to infinit in the future

            RuleFor(w => w.Title)
                .NotEmpty().NotNull()
                .MinimumLength(5).MaximumLength(80)
                .WithMessage("{PropertyName} must be between 2 and 15");

            RuleFor(w => w.ImageUrl)
                .NotEmpty().NotNull();

            RuleFor(w => w.FacebookUrl)
                .NotEmpty().NotNull();
        }
    }
}
