using QuizAppModels.Models.Informations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizAppAdminApi.Repositories.Users
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserInformation>> GetUsers();
        Task<UserInformation> GetUserById(Guid userId);
    }
}
