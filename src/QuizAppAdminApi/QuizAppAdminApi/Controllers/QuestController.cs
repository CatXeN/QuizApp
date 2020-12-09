using Microsoft.AspNetCore.Mvc;
using QuizAppAdminApi.Repositories.Quests;
using QuizAppModels.Models.Informations;
using QuizAppModels.Models.Validators;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace QuizAppAdminApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestController : ControllerBase
    {
        private readonly IQuestRepository _repository;
        private readonly QuestValidator _validator;
        public QuestController(IQuestRepository repository)
        {
            _repository = repository;

        }

        [Authorize(Policy = "Admin")]
        [HttpPost]
        public async Task<IActionResult> AddQuest(QuestInformation questInformation)
        {
            await _repository.AddQuest(questInformation);
            return Ok();
        }

        [Authorize(Policy = "Admin")]
        [HttpGet]
        public async Task<IActionResult> GetQuests()
        {
            var quests = await _repository.GetQuests();
            return Ok(quests);
        }

        [Authorize(Policy = "Admin")]
        [HttpGet("{questId}")]
        public async Task<IActionResult> GetQuestById(Guid questId)
        {
            var quest = await _repository.GetQuestById(questId);
            return Ok(quest);
        }

        [Authorize(Policy = "Admin")]
        [HttpPut]
        public async Task<IActionResult> UpdateQuest(QuestInformation questInformation)
        {
            await _repository.UpdateQuest(questInformation);
            return Ok();
        }

        [Authorize(Policy = "Admin")]
        [HttpDelete("{questId}")]
        public async Task<IActionResult> DeleteQuest(Guid questId)
        {
            await _repository.DeleteQuest(questId);
            return Ok();
        }
    }
}
