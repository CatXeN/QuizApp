using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAppMainApi.Services
{
    public interface IAuthService
    {
        Task<Object> GetToken(string username, string password);
    }
}
