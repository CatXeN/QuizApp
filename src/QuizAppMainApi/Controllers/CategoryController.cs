﻿using Microsoft.AspNetCore.Mvc;
using QuizAppMainApi.Repositories;
using QuizAppModels.Models.Informations;
using QuizAppModels.Models.Validators;
using System;
using System.Threading.Tasks;

namespace QuizAppMainApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _repository;
        private readonly CategoryValidator _validator;

        public CategoryController(ICategoryRepository repository)
        {
            _repository = repository;
            _validator = new CategoryValidator();
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryInformation categoryInformation)
        {
            var category = await _validator.ValidateAsync(categoryInformation);

            if (!category.IsValid) 
                return BadRequest(category.Errors);

            await _repository.AddCategory(categoryInformation);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _repository.GetCategories();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(Guid id)
        {
            var category = await _repository.GetCategoryById(id);
            return Ok(category);
        }

        [HttpGet("topCategories")]
        public async Task<IActionResult> GetTopCategories()
        {
            var categories = await _repository.GetTopCategories();
            return Ok(categories);
        }
    }
}
