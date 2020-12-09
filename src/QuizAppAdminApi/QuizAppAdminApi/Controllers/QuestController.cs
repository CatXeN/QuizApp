using Microsoft.AspNetCore.Mvc;
using QuizAppAdminApi.Repositories.Quests;
using QuizAppModels.Models.Informations;
using System;
using System.Threading.Tasks;

namespace QuizAppAdminApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestController : ControllerBase
    {
        private readonly IQuestRepository _repository;
        public QuestController(IQuestRepository repository)
        {
            _repository = repository;

        }

        [HttpPost]
        public async Task<IActionResult> AddQuest(QuestInformation questInformation)
        {
            await _repository.AddQuest(questInformation);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetQuests()
        {
            var quests = await _repository.GetQuests();
            return Ok(quests);
        }

        [HttpGet("{questId}")]
        public async Task<IActionResult> GetQuestById(Guid questId)
        {
            var quest = await _repository.GetQuestById(questId);
            return Ok(quest);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateQuest(QuestInformation questInformation)
        {
            await _repository.UpdateQuest(questInformation);
            return Ok();
        }

        [HttpDelete("{questId}")]
        public async Task<IActionResult> DeleteQuest(Guid questId)
        {
            await _repository.DeleteQuest(questId);
            return Ok();
        }
    }
}
