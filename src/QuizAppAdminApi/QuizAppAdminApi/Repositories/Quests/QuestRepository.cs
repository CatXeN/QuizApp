using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QuizAppAdminApi.Data;
using QuizAppModels.Models.Entities;
using QuizAppModels.Models.Informations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAppAdminApi.Repositories.Quests
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

        public async Task AddQuest(QuestInformation questInformation)
        {
            var quest = _mapper.Map<Quest>(questInformation);
            await _context.Quests.AddAsync(quest);

            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<QuestInformation>> GetQuests()
        {
            var quests = await _context.Quests.ToListAsync();
            return _mapper.Map<IEnumerable<QuestInformation>>(quests);
        }

        public async Task<QuestInformation> GetQuestById(Guid questId)
        {
            var quest = await _context.Quests.
                Include(x => x.Quiz).
                FirstOrDefaultAsync(x => x.QuestId == questId);
            return _mapper.Map<QuestInformation>(quest);
        }
        public async Task UpdateQuest(QuestInformation questInformation)
        {
            var quest = _mapper.Map<Quest>(questInformation);
            _context.Update(quest);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteQuest(Guid questId)
        {
            var quest = await _context.Quests.FindAsync(questId);
            _context.Remove(quest);

            await _context.SaveChangesAsync();
        }
    }
}
