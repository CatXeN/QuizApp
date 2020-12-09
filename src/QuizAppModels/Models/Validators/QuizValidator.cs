using FluentValidation;
using QuizAppModels.Models.Informations;
using System;

namespace QuizAppModels.Models.Validators
{
    public class QuizValidator : AbstractValidator<QuizInformation>
    {
        public QuizValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Please specify a name");
            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Please specify a description");
            RuleFor(x => x.UserId)
                .NotEqual(Guid.Empty).WithMessage("Contact with administrators");
            RuleFor(x => x.CategoryId)
                .NotEqual(Guid.Empty).WithMessage("Contact with administrators");
        }
    }
}
