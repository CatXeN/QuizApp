using QuizAppModels.Models.Informations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAppGameApi.Repositories.Quizzes
{
    public interface IQuizRepository
    {
        Task<QuizInformation> GetQuizById(Guid quizId);
    }
}
