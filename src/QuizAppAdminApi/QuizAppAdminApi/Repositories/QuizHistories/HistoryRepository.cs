using AutoMapper;
using QuizAppAdminApi.Data;
using QuizAppModels.Models.Entities;
using QuizAppModels.Models.Informations;
using System.Threading.Tasks;

namespace QuizAppAdminApi.Repositories.QuizHistories
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
