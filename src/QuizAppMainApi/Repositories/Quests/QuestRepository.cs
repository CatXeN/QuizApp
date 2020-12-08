using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QuizAppMainApi.Data;
using QuizAppModels.Models.Entities;
using QuizAppModels.Models.Informations;

namespace QuizAppMainApi.Repositories.Quests
{
    public class QuestRepository : IQuestRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        
        public QuestRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        public async Task<IEnumerable<QuestInformation>> GetQuestsByQuizId(Guid quizId)
        {
            var quests = await _context.Quests.
                Include(x => x.Quiz).
                Where(x => x.QuizId == quizId).
                ToListAsync();
            return _mapper.Map<IEnumerable<QuestInformation>>(quests);
        }

        public async Task<QuestInformation> GetQuestById(Guid questId)
        {
            var quest = await _context.Quests.
                Include(x => x.Quiz).
                FirstOrDefaultAsync(x => x.QuestId == questId);
            return _mapper.Map<QuestInformation>(quest);
        }

        public async Task AddQuest(QuestInformation questInformation)
        {
            var quest = _mapper.Map<Quest>(questInformation);
            await _context.Quests.AddAsync(quest);

            await _context.SaveChangesAsync();
        }
    }
}