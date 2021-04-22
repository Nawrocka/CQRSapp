using EduPlatform.Application.Contracts.Persistance;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EduPlatform.Application.Functions.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
    {
        private readonly ICategoryRepository _categoryRepository;
        public CreateCategoryCommandValidator(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;

            RuleFor(c => c.Name)
                 .NotEmpty()
                 .WithMessage("{PropertyName} is required.")
                 .MinimumLength(2).MaximumLength(15)
                 .WithMessage("{PropertyName} length should be between 2 and 15");

            RuleFor(c => c.DisplayName)
                 .NotEmpty()
                 .WithMessage("{PropertyName} is required.")
                 .MinimumLength(2).MaximumLength(15)
                 .WithMessage("{PropertyName} length should be between 2 and 15");

            RuleFor(c => c)
                .MustAsync(IsNameAlreadyExist)
                .WithMessage("Category with the same Name already exist");
               
        }

        private async Task<bool> IsNameAlreadyExist(CreateCategoryCommand e, CancellationToken cancellationToken)
        {
            var check = await _categoryRepository.IsNameAlreadyExist(e.Name);

            return !check;
        }
    }
}
