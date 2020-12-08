using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizAppAuthApi.Models.Entities;

namespace QuizAppAuthApi.Repository.Auth
{
    public interface IAuthRepository
    {
        Task<User> Login(string username, string password);
        Task<User> Register(User user, string password);
        Task<bool> UserExists(string username);
    }
}
