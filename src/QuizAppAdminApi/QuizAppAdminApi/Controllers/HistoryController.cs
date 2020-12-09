using Microsoft.AspNetCore.Mvc;
using QuizAppAdminApi.Repositories.QuizHistories;
using QuizAppModels.Models.Informations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace QuizAppAdminApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        private readonly IHistoryRepository _repository;
        public HistoryController(IHistoryRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> AddQuizHistory(QuizHistoryInformation quizHistoryInformation)
        {
            await _repository.AddHistoryQuiz(quizHistoryInformation);
            return Ok();
        }
    }
}
