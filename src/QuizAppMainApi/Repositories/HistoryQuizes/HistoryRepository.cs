using AutoMapper;
using QuizAppMainApi.Data;
using QuizAppModels.Models.Entities;
using QuizAppModels.Models.Informations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAppMainApi.Repositories.HistoryQuizes
{
    public class HistoryRepository : IHistoryRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public HistoryRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task AddHistoryQuiz(QuizHistoryInformation quizHistoryInformation)
        {
            var historyQuiz = _mapper.Map<QuizHistory>(quizHistoryInformation);
            await _context.QuizHistories.AddAsync(historyQuiz);

            await _context.SaveChangesAsync();
        }
    }
}
