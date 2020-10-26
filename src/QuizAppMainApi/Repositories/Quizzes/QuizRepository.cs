﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QuizAppMainApi.Data;
using QuizAppModels.Models.Entities;
using QuizAppModels.Models.Informations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAppMainApi.Repositories
{
    public class QuizRepository : IQuizRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public QuizRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task AddQuiz(QuizInformation quizInformation)
        {
            var quiz = _mapper.Map<Quiz>(quizInformation);
            await _context.Quizzes.AddAsync(quiz);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<QuizInformation>> GetQuizzes()
        {
            var quizzes = await _context.Quizzes.
                Include(x => x.Category).
                Include(x => x.User).
                ToListAsync();
            return _mapper.Map<IEnumerable<QuizInformation>>(quizzes);
        }

        public async Task<QuizInformation> GetQuizById(int quizId)
        {
            var quiz = await _context.Quizzes.
                Include(x => x.User).
                Include(x => x.Category).
                FirstOrDefaultAsync(x => x.CategoryId == quizId);
            return _mapper.Map<QuizInformation>(quiz);
        }
    }
}