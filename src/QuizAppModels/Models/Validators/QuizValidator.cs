using FluentValidation;
using QuizAppModels.Models.Informations;

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
                .GreaterThan(0).WithMessage("Contact with administrators");
            RuleFor(x => x.CategoryId)
                .GreaterThan(0).WithMessage("Contact with administrators");
        }
    }
}
