using Microsoft.AspNetCore.Server.HttpSys;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using QuizAppMainApi.Repositories.Auth;
using QuizAppModels.Config;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppMainApi.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _repository;
        private readonly AuthConfig _authConfig;

        public AuthService(IAuthRepository repository, IOptions<AuthConfig> authConfig)
        {
            _repository = repository;
            _authConfig = authConfig.Value;
        }

        public async Task<Object> GetToken(string username, string password)
        {
            var userRepository = await _repository.Login(username.ToLower(), password);

            if (userRepository == null)
                return null;

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, userRepository.UserId.ToString()),
                new Claim(ClaimTypes.Name, userRepository.Username),
                new Claim(ClaimTypes.Role, userRepository.Role)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_authConfig.SecurityKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddHours(24),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            var tokenToReturn = new
            {
                token = tokenHandler.WriteToken(token)
            };

            return tokenToReturn;
        }
    }
}
