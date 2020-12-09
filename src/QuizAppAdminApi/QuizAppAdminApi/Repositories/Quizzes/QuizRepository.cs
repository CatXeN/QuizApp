using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QuizAppAdminApi.Data;
using QuizAppModels.Models.Entities;
using QuizAppModels.Models.Informations;

namespace QuizAppAdminApi.Repositories.Quizzes
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

        public async Task<QuizInformation> GetQuizById(Guid quizId)
        {
            var quiz = await _context.Quizzes.
                Include(x => x.User).
                Include(x => x.Category).
                FirstOrDefaultAsync(x => x.QuizId == quizId);
            return _mapper.Map<QuizInformation>(quiz);
        }

        public async Task UpdateQuiz(QuizInformation quizInformation)
        {
            var quiz = _mapper.Map<Quiz>(quizInformation);
            _context.Update(quiz);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteQuiz(Guid quizId)
        {
            var quiz = await _context.Quizzes.FindAsync(quizId);
            _context.Remove(quiz);

            await _context.SaveChangesAsync();
        }
    }
}
