using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Moq;
using QuizAppMainApi.Controllers;
using QuizAppMainApi.Repositories;
using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using QuizAppModels.Models.Informations;

namespace QuizAppMain.Tests.Unit.ControllersTests
{
    public class CategoryControllerTest
    {
        private readonly CategoryController _controller;
        private readonly Mock<ICategoryRepository> _repository;

        public CategoryControllerTest()
        {
            _repository = new Mock<ICategoryRepository>();
            _controller = new CategoryController(_repository.Object);
        }

        [Fact]
        public async Task AddCategory_ModelIsValid_ReturnObjectResult()
        {
            _repository.Setup(x => x.AddCategory(It.IsAny<CategoryInformation>()));

            var result = await _controller.AddCategory(new CategoryInformation());

            result.Should().BeOfType<OkResult>();
        }

        [Fact]
        public async Task AddCategory_ModelIsValid_RepositoryHasBeenCalled()
        {
            _repository.Setup(x => x.AddCategory(It.IsAny<CategoryInformation>()));

            await _controller.AddCategory(new CategoryInformation());

            _repository.Verify(x => x.AddCategory(It.IsAny<CategoryInformation>()), Times.Once);
        }

        [Fact]
        public async Task GetCategory_ModelIsValid_ReturnObject()
        {
            _repository.Setup(x => x.GetCategoryById(It.IsAny<int>()))
                .ReturnsAsync(new CategoryInformation() {CategoryId = 0});

            var result = await _controller.GetCategoryById(It.IsAny<int>());

            result.Should().BeOfType<OkObjectResult>();
        }

        [Fact]
        public async Task GetCategory_ModelIsValid_RepositoryHasBeenCalled()
        {
            _repository.Setup(x => x.GetCategoryById(It.IsAny<int>()))
                .ReturnsAsync(new CategoryInformation() { CategoryId = 0 });

            await _controller.GetCategoryById(It.IsAny<int>());

            _repository.Verify(x => x.GetCategoryById(It.IsAny<int>()), Times.Once);
        }

        [Fact]
        public async Task GetCategories_ModelIsValid_ReturnObject()
        {
            _repository.Setup(x => x.GetCategories())
                .ReturnsAsync(new List<CategoryInformation>() { new CategoryInformation(){ CategoryId = 0 }});

            var result = await _controller.GetCategories();

            result.Should().BeOfType<OkObjectResult>();
        }

        [Fact]
        public async Task GetCategories_ModelIsValid_RepositoryHasBeenCalled()
        {
            _repository.Setup(x => x.GetCategories())
                .ReturnsAsync(new List<CategoryInformation>() { new CategoryInformation() { CategoryId = 0 } });

            await _controller.GetCategories();

            _repository.Verify(x => x.GetCategories(), Times.Once);
        }
    }
}
