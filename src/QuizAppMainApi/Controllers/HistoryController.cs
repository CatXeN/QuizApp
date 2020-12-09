using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizAppMainApi.Repositories;
using QuizAppMainApi.Repositories.HistoryQuizes;
using QuizAppModels.Models.Informations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAppMainApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        private readonly IHistoryRepository _repository;

        public HistoryController(IHistoryRepository historyRepository)
        {
            _repository = historyRepository;
        }

        [HttpPost("addQuizHistory")]
        public async Task<IActionResult> AddQuizHistory(QuizHistoryInformation quizHistoryInformation)
        {
            await _repository.AddHistoryQuiz(quizHistoryInformation);
            return Ok();
        }
    }
}
