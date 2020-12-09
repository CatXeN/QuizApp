using AutoMapper;
using QuizAppGameApi.Data;
using QuizAppModels.Models.Entities;
using QuizAppModels.Models.Informations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 

namespace QuizAppGameApi.Repositories.HistoryQuizes
{
    public class HistoryRepository : IHistoryRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _maper;

        public HistoryRepository(DataContext context, IMapper maper)
        {
            _context = context;
            _maper = maper;
        }

        public async Task AddHistoryQuiz(QuizHistoryInformation quizHistoryInformation)
        {
            var historyQuiz = _maper.Map<QuizHistory>(quizHistoryInformation);
            await _context.QuizHistories.AddAsync(historyQuiz);

            await _context.SaveChangesAsync();
        }
    }
}
