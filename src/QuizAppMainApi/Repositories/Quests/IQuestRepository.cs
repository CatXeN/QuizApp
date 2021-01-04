using QuizAppModels.Models.Informations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizAppMainApi.Repositories.Quests
{
    public interface IQuestRepository
    {
        Task<IEnumerable<QuestInformation>> GetQuestsById(Guid quizId);
        Task<QuestInformation> GetQuestById(Guid questId);
        Task AddQuest(QuestInformation questInformation);
    }
}