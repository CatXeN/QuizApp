using AutoMapper;
using Microsoft.IdentityModel.Tokens;
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
    }
}
