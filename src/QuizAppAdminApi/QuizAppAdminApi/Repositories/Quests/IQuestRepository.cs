using QuizAppModels.Models.Informations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizAppAdminApi.Repositories.Quests
{
    public interface IQuestRepository
    {
        Task AddQuest(QuestInformation questInformation);
        Task<QuestInformation> GetQuestById(Guid questId);
        Task<IEnumerable<QuestInformation>> GetQuests();
        Task UpdateQuest(QuestInformation questInformation);
        Task DeleteQuest(Guid questId);
    }
}
