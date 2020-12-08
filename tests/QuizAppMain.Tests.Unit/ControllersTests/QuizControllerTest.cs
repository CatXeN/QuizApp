using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using QuizAppMainApi.Controllers;
using QuizAppMainApi.Repositories;
using QuizAppModels.Models.Informations;
using Xunit;

namespace QuizAppMain.Tests.Unit.ControllersTests
{
    public class QuizControllerTest
    {
        private readonly QuizController _controller;
        private readonly Mock<IQuizRepository> _repository;

        public QuizControllerTest()
        {
                _repository = new Mock<IQuizRepository>();
                _controller = new QuizController(_repository.Object);
        }

        [Fact]
        public async Task AddQuiz_ModelIsValid_ReturnObjctResult()
        {
            _repository.Setup(x => x.AddQuiz(It.IsAny<QuizInformation>()));

            var result = await _controller.AddQuiz(new QuizInformation()
            {
                CategoryId = Guid.NewGuid(),
                Description = "Xyz",
                ImageUrl = "https://www.example.pl",
                Name = "xyz",
                UserId = Guid.NewGuid()
            });

            result.Should().BeOfType<OkObjectResult>();
        }

        [Fact]
        public async Task AddQuiz_ModelIsValid_RepositoryHasBeenCalled()
        {
            _repository.Setup(x => x.AddQuiz(It.IsAny<QuizInformation>()));

            await _controller.AddQuiz(new QuizInformation()
            {
                CategoryId = Guid.NewGuid(),
                Description = "Xyz",
                ImageUrl = "https://www.example.pl",
                Name = "xyz",
                UserId = Guid.NewGuid()
            });

           _repository.Verify(x => x.AddQuiz(It.IsAny<QuizInformation>()), Times.Once());
        }

        [Fact]
        public async Task GetQuiz_ModelIsValid_ReturnObject()
        {
            _repository.Setup(x => x.GetQuizById(It.IsAny<Guid>()))
                .ReturnsAsync(new QuizInformation() { QuizId = Guid.Empty});

            var result = await _controller.GetQuizById(It.IsAny<Guid>());

            result.Should().BeOfType<OkObjectResult>();
        }

        [Fact]
        public async Task GetQuiz_ModelIsValid_RepositoryHasBeenCalled()
        {
            _repository.Setup(x => x.GetQuizById(It.IsAny<Guid>()))
                .ReturnsAsync(new QuizInformation() { QuizId = Guid.Empty});

            await _controller.GetQuizById(It.IsAny<Guid>());

            _repository.Verify(x => x.GetQuizById(It.IsAny<Guid>()), Times.Once);
        }

        [Fact]
        public async Task GetQuizzes_ModelIsValid_ReturnObject()
        {
            _repository.Setup(x => x.GetQuizzes())
                .ReturnsAsync(new List<QuizInformation>() { new QuizInformation() { QuizId = Guid.Empty} });

            var result = await _controller.GetQuizzes();

            result.Should().BeOfType<OkObjectResult>();
        }
        
        [Fact]
        public async Task GetQuizzes_ModelIsValid_RepositoryHasBeenCalled()
        {
            _repository.Setup(x => x.GetQuizzes())
                .ReturnsAsync(new List<QuizInformation>() { new QuizInformation() { QuizId = Guid.Empty} });

            await _controller.GetQuizzes();

            _repository.Verify(x => x.GetQuizzes(), Times.Once);
        }
    }
}