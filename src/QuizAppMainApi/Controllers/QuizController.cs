using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizAppMainApi.Repositories;
using QuizAppModels.Models.Informations;
using QuizAppModels.Models.Validators;

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
            var result = await _validator.ValidateAsync(quizInformation);
            if (!result.IsValid)
                return BadRequest(result.Errors);
                
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
        public async Task<IActionResult> GetQuizById(int id)
        {
            var quiz = await _repository.GetQuizById(id);
            return Ok(quiz);
        }

        [HttpGet("twenty")]
        public async Task<IActionResult> GetTwentyQuizzes()
        {
            var quizzes = await _repository.GetTwentyQuiz();
            return Ok(quizzes);
        }

        [HttpGet("getQuizFromCategory/{categoryId}")]
        public async Task<IActionResult> getQuizFromCategory(int categoryId)
        {
            var quizzes = await _repository.GetQuizFromCategory(categoryId);
            return Ok(quizzes);
        }
    }
}
