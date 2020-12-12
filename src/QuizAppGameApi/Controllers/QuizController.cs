using Microsoft.AspNetCore.Mvc;
using QuizAppGameApi.Repositories.Quizzes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAppGameApi.Controllers
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuizById(Guid quizId)
        {
            var quiz = await _repository.GetQuizById(quizId);
            return Ok(quiz);
        }
    }
}
