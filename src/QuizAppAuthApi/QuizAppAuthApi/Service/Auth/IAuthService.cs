using System.Threading.Tasks;

namespace QuizAppAuthApi.Service.Auth
{
    public interface IAuthService
    {
        Task<object> GetToken(string username, string password);
    }
}
