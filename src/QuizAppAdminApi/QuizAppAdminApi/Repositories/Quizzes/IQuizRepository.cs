using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using QuizAppModels.Models.Informations;

namespace QuizAppAdminApi.Repositories.Quizzes
{
    public interface IQuizRepository
    {
        Task AddQuiz(QuizInformation quizInformation);
        Task<IEnumerable<QuizInformation>> GetQuizzes();
        Task<QuizInformation> GetQuizById(Guid quizId);
        Task UpdateQuiz(QuizInformation quizInformation);
        Task DeleteQuiz(Guid quizId);
    }
}
