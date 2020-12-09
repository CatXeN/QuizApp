using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using QuizAppAuthApi.Config;
using QuizAppAuthApi.Repository.Auth;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppAuthApi.Service.Auth
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

        public async Task<object> GetToken(string username, string password)
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
