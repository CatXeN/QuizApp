using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QuizAppAuthApi.Models.Entities;
using QuizAppAuthApi.Models.Informations;
using QuizAppAuthApi.Models.Validators;
using QuizAppAuthApi.Repository.Auth;
using QuizAppAuthApi.Service.Auth;

namespace QuizAppAuthApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repository;
        private readonly IAuthService _service;
        private readonly UserValidator _validator;

        public AuthController(IAuthRepository repository, IAuthService service)
        {
            _repository = repository;
            _service = service;
            _validator = new UserValidator();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserInformation userInformation)
        {
            var result = await _validator.ValidateAsync(userInformation);
            if (!result.IsValid)
                return BadRequest(result.Errors);

            userInformation.Username = userInformation.Username.ToLower();

            if (await _repository.UserExists(userInformation.Username))
                return BadRequest("User exist");

            var userToCreate = new User
            {
                Username = userInformation.Username,
                Role = userInformation.Role,
                Email = userInformation.Email
            };

            var createdUser = await _repository.Register(userToCreate, userInformation.Password);

            return StatusCode(201);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserInformation userInformation)
        {
            var token = await _service.GetToken(userInformation.Username, userInformation.Password);

            if (token == null)
                return Unauthorized();

            return Ok(token);
        }
    }
}
