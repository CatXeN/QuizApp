using QuizAppModels.Models.Entities;
using QuizAppModels.Models.Informations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAppMainApi.Repositories
{
    public interface IQuizRepository 
    {
        Task<Guid> AddQuiz(QuizInformation quizInformation);
        Task<IEnumerable<QuizInformation>> GetQuizzes();
        Task<QuizInformation> GetQuizById(Guid id);
        Task<IEnumerable<QuizInformation>> GetTwentyQuiz();
    }
}
