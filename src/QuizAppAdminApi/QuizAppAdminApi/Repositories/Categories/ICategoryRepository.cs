using QuizAppModels.Models.Informations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizAppAdminApi.Repositories.Categories
{
    public interface ICategoryRepository
    {
        Task AddCategory(CategoryInformation categoryInformation);
        Task<IEnumerable<CategoryInformation>> GetCategories();
        Task<CategoryInformation> GetCategoryById(Guid categoryId);
        Task UpdateCategory(CategoryInformation categoryInformation);
        Task DeleteCategory(Guid categoryId);
    }
}
