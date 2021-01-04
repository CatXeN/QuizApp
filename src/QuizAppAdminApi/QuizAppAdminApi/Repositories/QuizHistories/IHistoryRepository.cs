using QuizAppModels.Models.Informations;
using System.Threading.Tasks;

namespace QuizAppAdminApi.Repositories.QuizHistories
{
    public interface IHistoryRepository
    {
        Task AddHistoryQuiz(QuizHistoryInformation quizHistoryInformation);
    }
}
