﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizAppMainApi.Data;
using QuizAppMainApi.Repositories;
using QuizAppModels.Models.Informations;
using QuizAppModels.Models.Validators;

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
            var result = await _validator.ValidateAsync(categoryInformation);

            if (!result.IsValid) 
                return BadRequest(result.Errors);

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
    }
}
