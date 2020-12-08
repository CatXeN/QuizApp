using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using QuizAppModels.Models.Informations;

namespace QuizAppMainApi.Repositories.Quests
{
    public interface IQuestRepository
    {
        Task<IEnumerable<QuestInformation>> GetQuests(Guid quizId);
        Task<QuestInformation> GetQuest(Guid questId);
        Task AddQuest(QuestInformation questInformation);
    }
}