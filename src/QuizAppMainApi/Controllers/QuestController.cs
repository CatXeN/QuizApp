using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuizAppMainApi.Repositories.Quests;
using QuizAppModels.Models.Informations;
using QuizAppModels.Models.Validators;

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
            var result = await _validator.ValidateAsync(questInformation);

            if (!result.IsValid)
                return BadRequest(result.Errors);
            
            await _repository.AddQuest(questInformation);
            return Ok();
        }

        [HttpGet("single/{questId}")]
        public async Task<IActionResult> GetQuest(int questId)
        {
            var quest = await _repository.GetQuest(questId);
            return Ok(quest);
        }

        [HttpGet("{quizId}")]
        public async Task<IActionResult> GetQuests(int quizId)
        {
            var quests = await _repository.GetQuests(quizId);
            return Ok(quests);
        }

        [HttpGet("getQuestsForCatergory/{id}")]
        public async Task<IActionResult> GetQuestsForCatergory(int id)
        {
            var Quests = await _repository.GetQuestsForCatergory(id);
            return Ok(Quests);
        }
    }
}