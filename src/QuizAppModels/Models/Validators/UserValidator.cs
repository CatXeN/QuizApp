using FluentValidation;
using QuizAppModels.Models.Informations;

namespace QuizAppModels.Models.Validators
{
    public class UserValidator : AbstractValidator<UserInformation>
    {
        public UserValidator()
        {
            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("Please specify a username");
            RuleFor(x => x.Email)
                .EmailAddress().WithMessage("This is not an email address");
            RuleFor(x => x.Password)
                .MinimumLength(4).WithMessage("Password is too short");
            RuleFor(x => x.Role)
                .NotEmpty().WithMessage("Contact with administrators");
        }
    }
}
