using AutoMapper;
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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CategoryRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task AddCategory(CategoryInformation categoryInformation)
        {
            var category = _mapper.Map<Category>(categoryInformation);
            await _context.Categories.AddAsync(category);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<CategoryInformation>> GetCategories()
        {
            var categories = await _context.Categories.ToListAsync();
            return _mapper.Map<IEnumerable<CategoryInformation>>(categories);
        }

        public async Task<CategoryInformation> GetCategoryById(Guid categoryId)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(x => x.CategoryId == categoryId);
            return _mapper.Map<CategoryInformation>(category);
        }

        public async Task<IEnumerable<CategoryInformation>> GetTopCategories()
        {
            var categories = await _context.Categories.
                OrderByDescending(x => x.DoneQuizzess).
                Take(5).
                ToListAsync();
            return _mapper.Map<IEnumerable<CategoryInformation>>(categories);
        }
    }
}
