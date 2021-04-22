using EduPlatform.Application.Contracts.Persistance;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EduPlatform.Application.Functions.Posts.Commands.CreatePost
{
    public class CreatePostCommandValidator : AbstractValidator<CreatePostCommand>
    {
        private readonly IPostRepository _postRepository;
        public CreatePostCommandValidator(IPostRepository postRepository)
        {
            _postRepository = postRepository;

            RuleFor(p => p.Title)
                .NotEmpty()
                .WithMessage("{PropertyName} is required")
                .NotNull()
                .MaximumLength(80)
                .WithMessage("{PropertyName} must not exceeed 80 characters");

            RuleFor(p => p.Date)
                .NotEmpty()
                .WithMessage("{PropertyName} is required")
                .NotNull()
                .LessThan(DateTime.Now.AddDays(1));

            RuleFor(p => p.Rate)
                .InclusiveBetween(0, 100)
                .WithMessage("{PropertyName} is between 0 to 100");

            RuleFor(p => p)
                .MustAsync(IsTitleAndAuthorAlreadyExist)
                .WithMessage("Post with the same Title and Author already exist");
            
        }

        private async Task<bool> IsTitleAndAuthorAlreadyExist(CreatePostCommand e, CancellationToken cancellationToken)
        {
            var check = await _postRepository.IsTitleAdnAuthorAlreadyExist(e.Title, e.Author);

            return !check;
        }
    }
}
