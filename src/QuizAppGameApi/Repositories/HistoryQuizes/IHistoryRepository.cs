using QuizAppModels.Models.Informations;
using System.Threading.Tasks;

namespace QuizAppGameApi.Repositories.HistoryQuizes
{
    public interface IHistoryRepository
    {
        Task AddHistoryQuiz(QuizHistoryInformation quizHistoryInformation);
    }
}
