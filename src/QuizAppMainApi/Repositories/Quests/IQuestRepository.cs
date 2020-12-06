using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using QuizAppModels.Models.Informations;

namespace QuizAppMainApi.Repositories.Quests
{
    public interface IQuestRepository
    {
        Task<IEnumerable<QuestInformation>> GetQuests(int quizId);
        Task<QuestInformation> GetQuest(int questId);
        Task AddQuest(QuestInformation questInformation);
        Task<IEnumerable<QuestInformation>> GetTenQuests();
    }
}