using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuizAppAdminApi.Repositories.Quizzes;
using QuizAppModels.Models.Informations;
using QuizAppModels.Models.Validators;

namespace QuizAppAdminApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly IQuizRepository _repository;

        public QuizController(IQuizRepository repository)
        {
            _repository = repository;
        }

        [Authorize(Policy = "Admin")]
        [HttpPost]
        public async Task<IActionResult> AddQuiz(QuizInformation quizInformation)
        {
            await _repository.AddQuiz(quizInformation);
            return Ok();
        }

        [Authorize(Policy = "Admin")]
        [HttpGet]
        public async Task<IActionResult> GetQuizzes()
        {
            var quizzes = await _repository.GetQuizzes();
            return Ok(quizzes);
        }

        [Authorize(Policy = "Admin")]
        [HttpGet("{quizId}")]
        public async Task<IActionResult> GetQuizById(Guid quizId)
        {
            var quiz = await _repository.GetQuizById(quizId);
            return Ok(quiz);
        }

        [Authorize(Policy = "Admin")]
        [HttpPut]
        public async Task<IActionResult> UpdateQuiz(QuizInformation quizInformation)
        {
            await _repository.UpdateQuiz(quizInformation);
            return Ok();
        }

        [Authorize(Policy = "Admin")]
        [HttpDelete("{quizId}")]
        public async Task<IActionResult> DeleteQuiz(Guid quizId)
        {
            await _repository.DeleteQuiz(quizId);
            return Ok();
        }
    }
}
