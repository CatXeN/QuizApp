using Microsoft.AspNetCore.Mvc;
using QuizAppMainApi.Repositories;
using QuizAppModels.Models.Informations;
using QuizAppModels.Models.Validators;
using System;
using System.Threading.Tasks;

namespace QuizAppMainApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly IQuizRepository _repository;
        private readonly QuizValidator _validator;

        public QuizController(IQuizRepository repository)
        {
            _repository = repository;
            _validator = new QuizValidator();
        }

        [HttpPost]
        public async Task<IActionResult> AddQuiz(QuizInformation quizInformation)
        {
            var quiz = await _validator.ValidateAsync(quizInformation);
            if (!quiz.IsValid)
                return BadRequest(quiz.Errors);
                
            var resultOfRepository = await _repository.AddQuiz(quizInformation);
            return Ok(resultOfRepository);
        }

        [HttpGet]
        public async Task<IActionResult> GetQuizzes()
        {
            var quizzes = await _repository.GetQuizzes();
            return Ok(quizzes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuizById(Guid id)
        {
            var quiz = await _repository.GetQuizById(id);
            return Ok(quiz);
        }

        [HttpGet("getQuizzesFromCategory/{categoryId}")]
        public async Task<IActionResult> GetQuizzesFromCategory(Guid categoryId)
        {
            var quizzes = await _repository.GetQuizzesFromCategory(categoryId);
            return Ok(quizzes);
        }
    }
}
