using Microsoft.AspNetCore.Mvc;
using QuizAppAdminApi.Repositories.Categories;
using QuizAppModels.Models.Informations;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace QuizAppAdminApi.Controllers
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

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _repository.GetCategories();
            return Ok(categories);
        }

        [HttpGet("{categoryId}")]
        public async Task<IActionResult> GetCategoryById(Guid categoryId)
        {
            var category = await _repository.GetCategoryById(categoryId);
            return Ok(category);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(CategoryInformation categoryInformation)
        {
            await _repository.UpdateCategory(categoryInformation);
            return Ok();
        }

        [HttpDelete("{categoryId}")]
        public async Task<IActionResult> DeleteCategory(Guid categoryId)
        {
            await _repository.DeleteCategory(categoryId);
            return Ok();
        }
    }
}
