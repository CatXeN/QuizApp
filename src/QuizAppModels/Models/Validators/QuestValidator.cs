﻿using FluentValidation;
using QuizAppModels.Models.Informations;
using System;

namespace QuizAppModels.Models.Validators
{
    public class QuestValidator : AbstractValidator<QuestInformation>
    {
        public QuestValidator()
        {
            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Please specify a description");
            RuleFor(x => x.Time)
                .GreaterThan(0).WithMessage("Time must be greater than 0");
            RuleFor(x => x.AnswerA)
                .NotEmpty().WithMessage("Please specify a answer");
            RuleFor(x => x.AnswerB)
                .NotEmpty().WithMessage("Please specify a answer");
            RuleFor(x => x.AnswerC)
                .NotEmpty().WithMessage("Please specify a answer");
            RuleFor(x => x.AnswerD)
                .NotEmpty().WithMessage("Please specify a answer");
            RuleFor(x => x.CorrectAnswer)
                .GreaterThanOrEqualTo(0);
            RuleFor(x => x.QuizId)
                .NotEqual(Guid.Empty).WithMessage("Contact with administration");
        }
    }
}
