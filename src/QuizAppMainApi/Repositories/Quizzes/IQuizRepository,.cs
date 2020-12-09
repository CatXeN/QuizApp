using QuizAppModels.Models.Informations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizAppMainApi.Repositories
{
    public interface IQuizRepository 
    {
        Task<Guid> AddQuiz(QuizInformation quizInformation);
        Task<IEnumerable<QuizInformation>> GetQuizzes();
        Task<QuizInformation> GetQuizById(Guid quizId);
        Task<IEnumerable<QuizInformation>> GetQuizzesFromCategory(Guid categoryId);
    }
}
