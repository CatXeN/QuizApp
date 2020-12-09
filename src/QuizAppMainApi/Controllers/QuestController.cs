using Microsoft.AspNetCore.Mvc;
using QuizAppMainApi.Repositories.Quests;
using QuizAppModels.Models.Informations;
using QuizAppModels.Models.Validators;
using System;
using System.Threading.Tasks;

namespace QuizAppMainApi.Controllers
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
            _validator = new QuestValidator();
        }
        
        [HttpPost]
        public async Task<IActionResult> AddQuest(QuestInformation questInformation)
        {
            var quest = await _validator.ValidateAsync(questInformation);

            if (!quest.IsValid)
                return BadRequest(quest.Errors);
            
            await _repository.AddQuest(questInformation);
            return Ok();
        }

        [HttpGet("single/{questId}")]
        public async Task<IActionResult> GetQuestById(Guid questId)
        {
            var quest = await _repository.GetQuestById(questId);
            return Ok(quest);
        }

        [HttpGet("getQuestsById/{quizId}")]
        public async Task<IActionResult> GetQuestsById(Guid quizId)
        {
            var quests = await _repository.GetQuestsById(quizId);
            return Ok(quests);
        }
    }
}