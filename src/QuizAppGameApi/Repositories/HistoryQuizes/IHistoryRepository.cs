﻿using QuizAppModels.Models.Informations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAppGameApi.Repositories.HistoryQuizes
{
    public interface IHistoryRepository
    {
        Task AddHistoryQuiz(QuizHistoryInformation quizHistoryInformation);
    }
}
