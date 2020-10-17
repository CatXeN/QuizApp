using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizAppMainApi.Data;
using QuizAppMainApi.Repositories;
using QuizAppModels.Models.Informations;

namespace QuizAppMainApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _repository;
        public CategoryController(ICategoryRepository repository)
        {
            _repository = repository;
        } 

        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryInformation categoryInformation)
        {
            await _repository.AddCategory(categoryInformation);
            return Ok();
        }
    }
}
