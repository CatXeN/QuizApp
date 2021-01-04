using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QuizAppGameApi.Data;
using QuizAppModels.Models.Informations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAppGameApi.Repositories.Quizzes
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

        public async Task<QuizInformation> GetQuizById(Guid quizId)
        {
            var quiz = await _context.Quizzes.
                Include(x => x.User).
                Include(x => x.Category).
                FirstOrDefaultAsync(x => x.QuizId == quizId);
            return _mapper.Map<QuizInformation>(quiz);
        }
    }
}
