using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuizAppMainApi.Repositories.Quests;
using QuizAppModels.Models.Informations;

namespace QuizAppMainApi.Controllers
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
    }
}