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
        public async Task AddQuiz_ModelIsValid_ReturnObjctResault()
        {
            _repository.Setup(x => x.AddQuiz(It.IsAny<QuizInformation>()));

            var result = await _controller.AddQuiz(new QuizInformation());

            result.Should().BeOfType<OkResult>();
        }

        [Fact]
        public async Task AddQuiz_ModelIsValid_RepositoryHasBeenCalled()
        {
            _repository.Setup(x => x.AddQuiz(It.IsAny<QuizInformation>()));

            await _controller.AddQuiz(new QuizInformation());

           _repository.Verify(x => x.AddQuiz(It.IsAny<QuizInformation>()), Times.Once());
        }

        [Fact]
        public async Task GetQuiz_ModelIsValid_ReturnObject()
        {
            _repository.Setup(x => x.GetQuizById(It.IsAny<int>()))
                .ReturnsAsync(new QuizInformation() { QuizId = 0});

            var result = await _controller.GetQuizById(It.IsAny<int>());

            result.Should().BeOfType<OkObjectResult>();
        }

        [Fact]
        public async Task GetQuiz_ModelIsValid_RepositoryHasBeenCalled()
        {
            _repository.Setup(x => x.GetQuizById(It.IsAny<int>()))
                .ReturnsAsync(new QuizInformation() { QuizId = 0 });

            await _controller.GetQuizById(It.IsAny<int>());

            _repository.Verify(x => x.GetQuizById(It.IsAny<int>()), Times.Once);
        }

        [Fact]
        public async Task GetQuizzes_ModelIsValid_ReturnObject()
        {
            _repository.Setup(x => x.GetQuizzes())
                .ReturnsAsync(new List<QuizInformation>() { new QuizInformation() { QuizId = 0 } });

            var result = await _controller.GetQuizzes();

            result.Should().BeOfType<OkObjectResult>();
        }
        
        [Fact]
        public async Task GetQuizzes_ModelIsValid_RepositoryHasBeenCalled()
        {
            _repository.Setup(x => x.GetQuizzes())
                .ReturnsAsync(new List<QuizInformation>() { new QuizInformation() { QuizId = 0 } });

            await _controller.GetQuizzes();

            _repository.Verify(x => x.GetQuizzes(), Times.Once);
        }
    }
}