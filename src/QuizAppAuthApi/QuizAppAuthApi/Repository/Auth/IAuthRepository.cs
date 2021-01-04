using QuizAppAuthApi.Models.Entities;
using System.Threading.Tasks;

namespace QuizAppAuthApi.Repository.Auth
{
    public interface IAuthRepository
    {
        Task<User> Login(string username, string password);
        Task<User> Register(User user, string password);
        Task<bool> UserExists(string username);
    }
}
