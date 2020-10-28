using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using QuizAppModels.Models.Informations;

namespace QuizAppModels.Models.Validators
{
    public class CategoryValidator : AbstractValidator<CategoryInformation>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Please specify a category name");
        }
    }
}
