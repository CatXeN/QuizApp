﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using QuizAppMainApi.Controllers;
using QuizAppMainApi.Repositories.Quests;
using QuizAppModels.Models.Informations;
using Xunit;

namespace QuestAppMain.Tests.Unit.ControllersTests
{
    public class QuestControllerTest
    {
        private readonly QuestController _controller;
        private readonly Mock<IQuestRepository> _repository;

        public QuestControllerTest()
        {
            _repository = new Mock<IQuestRepository>();
            _controller = new QuestController(_repository.Object);
        }

        [Fact]
        public async Task AddQuest_ModelIsValid_ReturnObjectResult()
        {
            _repository.Setup(x => x.AddQuest(It.IsAny<QuestInformation>()));

            var result = await _controller.AddQuest(new QuestInformation() 
            { 
                AnswerA = "xyz",
                AnswerB = "xyz",
                AnswerC = "xyz",
                AnswerD = "xyz",
                CorrectAnswer = 0,
                Description = "xyz",
                ImageUrl = "http://exmaplehttplink.pl",
                QuizId = Guid.NewGuid(),
                Time = 30
            });

            result.Should().BeOfType<OkResult>();
        }

        [Fact]
        public async Task AddQuest_ModelIsValid_RepositoryHasBeenCalled()
        {
            _repository.Setup(x => x.AddQuest(It.IsAny<QuestInformation>()));

            await _controller.AddQuest(new QuestInformation()
            {
                AnswerA = "xyz",
                AnswerB = "xyz",
                AnswerC = "xyz",
                AnswerD = "xyz",
                CorrectAnswer = 0,
                Description = "xyz",
                ImageUrl = "http://exmaplehttplink.pl",
                QuizId = Guid.NewGuid(),
                Time = 30
            });

            _repository.Verify(x => x.AddQuest(It.IsAny<QuestInformation>()), Times.Once());
        }

        [Fact]
        public async Task GetQuest_ModelIsValid_ReturnObjectResult()
        {
            _repository.Setup(x => x.GetQuestById(It.IsAny<Guid>()))
                .ReturnsAsync(new QuestInformation() { QuestId = Guid.Empty});

            var result = await _controller.GetQuestById(It.IsAny<Guid>());

            result.Should().BeOfType<OkObjectResult>();
        }

        [Fact]
        public async Task GetQuest_ModelIsValid_RepositoryHasBeenCalled()
        {
            _repository.Setup(x => x.GetQuestById(It.IsAny<Guid>()))
                .ReturnsAsync(new QuestInformation() { QuizId = Guid.Empty});

            await _controller.GetQuestById(It.IsAny<Guid>());

            _repository.Verify(x => x.GetQuestById(It.IsAny<Guid>()), Times.Once);
        }

        [Fact]
        public async Task GetQuests_ModelIsValid_ReturnObjectResult()
        {
            _repository.Setup(x => x.GetQuestsById(It.IsAny<Guid>()))
                .ReturnsAsync(new List<QuestInformation>() {new QuestInformation() { QuestId = Guid.Empty} });

            var result = await _controller.GetQuestsById(It.IsAny<Guid>());

            result.Should().BeOfType<OkObjectResult>();
        }

        [Fact]
        public async Task GetQuests_ModelIsValid_RepositoryHasBeenCalled()
        {
            _repository.Setup(x => x.GetQuestsById(It.IsAny<Guid>()))
                .ReturnsAsync(new List<QuestInformation>() { new QuestInformation() { QuestId = Guid.Empty} });

            await _controller.GetQuestsById(It.IsAny<Guid>());

            _repository.Verify(x => x.GetQuestsById(It.IsAny<Guid>()), Times.Once);
        }
    }
}