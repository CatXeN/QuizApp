using QuizAppModels.Models.Informations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizAppMainApi.Repositories
{
    public interface ICategoryRepository
    {
        Task AddCategory(CategoryInformation categoryInformation);
        Task<IEnumerable<CategoryInformation>> GetCategories();
        Task<CategoryInformation> GetCategoryById(Guid categoryId);
        Task<IEnumerable<CategoryInformation>> GetTopCategories();
    }
}
