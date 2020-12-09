using Microsoft.AspNetCore.Mvc;
using QuizAppGameApi.Repositories.HistoryQuizes;
using QuizAppModels.Models.Informations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAppGameApi.Controllers
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
