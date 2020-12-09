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
        private readonly IMapper _mapper;

        public HistoryRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task AddHistoryQuiz(QuizHistoryInformation quizHistoryInformation)
        {
            var quizHistoryToAdd = _mapper.Map<QuizHistory>(quizHistoryInformation);
            await _context.QuizHistories.AddAsync(quizHistoryToAdd);

            await _context.SaveChangesAsync();
        }
    }
}
