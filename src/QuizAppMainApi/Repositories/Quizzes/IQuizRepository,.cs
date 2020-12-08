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
        Task<int> AddQuiz(QuizInformation quizInformation);
        Task<IEnumerable<QuizInformation>> GetQuizzes();
        Task<QuizInformation> GetQuizById(int id);
        Task<IEnumerable<QuizInformation>> GetTwentyQuiz();
        Task<IEnumerable<QuizInformation>> GetQuizFromCategory(int categoryId);
    }
}
